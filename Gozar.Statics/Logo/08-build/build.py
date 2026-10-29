from pathlib import Path
from PIL import Image, ImageFilter
import numpy as np, json, math, struct, shutil

ROOT=Path(__file__).resolve().parent
OUT=ROOT.parent
OUT.mkdir(exist_ok=True)
SRC=OUT/'00-source'/'approved-ai-concept.png'
C={'terracotta':'#B85E3C','chocolate':'#512D1D','ivory':'#FFFCF4','white':'#FFFFFF','black':'#171411'}

def simplify(pts,eps=.7):
    if len(pts)<3:return pts
    a,b=pts[0],pts[-1]; dx=b[0]-a[0];dy=b[1]-a[1]
    ds=[abs(dy*(p[0]-a[0])-dx*(p[1]-a[1]))/max(1,math.hypot(dx,dy)) for p in pts]
    i=max(range(len(ds)),key=ds.__getitem__)
    if ds[i]<=eps:return [a,b]
    return simplify(pts[:i+1],eps)[:-1]+simplify(pts[i:],eps)

# Trace only the approved English lettering, preserving its custom appearance.
im=np.array(Image.open(SRC).convert('RGB'))
mask=(im[420:620,630:1270,:].mean(2)<150)
edges={}
for y,x in zip(*np.where(mask)):
    for a,b,inside in [((x,y),(x+1,y),y>0 and mask[y-1,x]),((x+1,y),(x+1,y+1),x<mask.shape[1]-1 and mask[y,x+1]),((x+1,y+1),(x,y+1),y<mask.shape[0]-1 and mask[y+1,x]),((x,y+1),(x,y),x>0 and mask[y,x-1])]:
        if not inside:edges.setdefault(a,[]).append(b)
paths=[]
while edges:
    start=next(iter(edges));p=start;pts=[p]
    while True:
        nxt=edges[p].pop()
        if not edges[p]:del edges[p]
        p=nxt;pts.append(p)
        if p==start:break
        if p not in edges:break
    if len(pts)>20:
        mid=len(pts)//2
        q=simplify(pts[:mid+1])+simplify(pts[mid:]) [1:]
        q=q[:-1]
        mids=[((q[i][0]+q[(i+1)%len(q)][0])/2,(q[i][1]+q[(i+1)%len(q)][1])/2) for i in range(len(q))]
        paths.append(f'M{mids[-1][0]},{mids[-1][1]} '+' '.join(f'Q{x},{y} {mids[i][0]},{mids[i][1]}' for i,(x,y) in enumerate(q))+' Z')
TEXT=' '.join(paths)
(ROOT/'wordmark-path.txt').write_text(TEXT)

def symbol(primary,secondary):
    # Deliberately redrawn as clean, editable paths with consistent seams.
    parts=[('Terracotta upper module',primary,'M18 94 L82 17 Q89 10 101 10 H160 Q172 10 172 22 V94 Q172 106 160 106 H23 Q8 106 18 94 Z'),
    ('Terracotta passage left',primary,'M20 116 H78 Q90 116 90 128 V200 H132 Q140 200 140 208 V242 H181 Q190 242 190 251 V286 H236 Q244 286 244 294 V322 H44 Q0 322 0 278 V138 Q0 116 20 116 Z'),
    ('Terracotta passage right',primary,'M193 166 H310 Q322 166 322 178 V285 Q322 322 291 322 H264 V278 Q264 267 253 267 H211 V233 Q211 222 200 222 H184 V178 Q184 166 193 166 Z'),
    ('Chocolate rosette module',secondary,'M194 10 H290 Q322 10 322 42 V142 Q322 156 308 156 H194 Q182 156 182 144 V22 Q182 10 194 10 Z')]
    # Six solid ivory petals, cut out using evenodd so transparent export remains real transparency.
    holes=''
    for i in range(6):
        angle=math.radians(i*60);cx,cy=252,83
        def tr(x,y):return f'{cx+x*math.cos(angle)-y*math.sin(angle):.3f},{cy+x*math.sin(angle)+y*math.cos(angle):.3f}'
        holes+=' M'+tr(0,-13)+' C'+tr(-24,-34)+' '+tr(-12,-58)+' '+tr(0,-54)+' C'+tr(16,-54)+' '+tr(17,-33)+' '+tr(0,-13)+' Z'
    holes+=' M258,83 A6,6 0 1 0 246,83 A6,6 0 1 0 258,83 Z'
    parts[-1]=(parts[-1][0],secondary,parts[-1][2]+holes)
    return parts

jobs=[];sources={}
def svg(layout,variant='primary'):
    p,s=C['terracotta'],C['chocolate']
    if variant=='reversed':s=C['ivory']
    if variant=='mono-dark':p=s=C['chocolate']
    if variant=='mono-white':p=s=C['white']
    sym=''.join(f'<path id="part-{i}" fill="{color}" fill-rule="evenodd" d="{d}"/>' for i,(_,color,d) in enumerate(symbol(p,s)))
    text=f'<path id="outlined-wordmark" fill="{s}" fill-rule="evenodd" d="{TEXT}"/>'
    if layout=='horizontal':w,h=1120,400;body=f'<g id="symbol" transform="translate(40 35)">{sym}</g><g id="wordmark" transform="translate(398 105)">{text}</g>'
    elif layout=='stacked':w,h=800,800;body=f'<g id="symbol" transform="translate(239 85)">{sym}</g><g id="wordmark" transform="translate(80 500)">{text}</g>'
    elif layout=='wordmark':w,h=720,280;body=f'<g id="wordmark" transform="translate(40 40)">{text}</g>'
    else:w=h=400;body=f'<g id="symbol" transform="translate(39 34)">{sym}</g>'
    return f'<svg xmlns="http://www.w3.org/2000/svg" width="{w}" height="{h}" viewBox="0 0 {w} {h}" role="img" aria-label="Go Zar {layout} logo"><title>Go Zar — {layout} — {variant}</title>{body}</svg>'

for layout in ['horizontal','stacked','symbol','wordmark']:
    for variant in ['primary','reversed','mono-dark','mono-white']:
        name=f'gozar-{layout}-{variant}'
        content=svg(layout,variant); sources[name]=content
        path=OUT/'01-vector'/layout/f'{name}.svg';path.parent.mkdir(parents=True,exist_ok=True);path.write_text(content)
        for width in ([512,1024,2048,4096] if layout in ['horizontal','wordmark'] else [256,512,1024,2048]):
            dest=OUT/'02-png'/layout/f'{name}-{width}w.png';dest.parent.mkdir(parents=True,exist_ok=True)
            jobs.append({'svg':str(path),'out':str(dest),'width':width})
        dest=OUT/'03-jpg'/layout/f'{name}-2048w.jpg';dest.parent.mkdir(parents=True,exist_ok=True)
        jobs.append({'svg':str(path),'out':str(dest),'width':2048,'background':C['chocolate'] if variant in ['reversed','mono-white'] else C['ivory']})

# App icon has a genuine full-bleed background, safe inset for OS masking.
sym=''.join(f'<path fill="{col}" fill-rule="evenodd" d="{d}"/>' for _,col,d in symbol(C['terracotta'],C['chocolate']))
icon=f'<svg xmlns="http://www.w3.org/2000/svg" width="1024" height="1024" viewBox="0 0 1024 1024"><rect width="1024" height="1024" fill="{C["ivory"]}"/><g transform="translate(222 222) scale(1.8)">{sym}</g></svg>'
icons=OUT/'04-app-icons';icons.mkdir(exist_ok=True);(icons/'gozar-app-icon.svg').write_text(icon)
for size in [16,32,48,64,96,128,180,192,256,512,1024]:
    jobs.append({'svg':str(icons/'gozar-app-icon.svg'),'out':str(icons/f'gozar-app-icon-{size}.png'),'width':size})
maui=OUT/'05-maui';maui.mkdir(exist_ok=True)
(maui/'appicon.svg').write_text(f'<svg xmlns="http://www.w3.org/2000/svg" width="512" height="512" viewBox="0 0 512 512"><rect width="512" height="512" fill="{C["ivory"]}"/></svg>')
(maui/'appiconfg.svg').write_text(f'<svg xmlns="http://www.w3.org/2000/svg" width="512" height="512" viewBox="0 0 512 512"><g transform="translate(111 111) scale(.9)">{sym}</g></svg>')
(maui/'splash.svg').write_text(svg('symbol'))
sourcesdir=OUT/'00-source';sourcesdir.mkdir(exist_ok=True);None # Reference already resides in source directory
shutil.copy2(OUT/'01-vector'/'horizontal'/'gozar-horizontal-primary.svg',sourcesdir/'gozar-master-outlined.svg')
# Photoshop will contain independently movable transparent symbol modules and wordmark.
layers=ROOT/'layers';layers.mkdir(exist_ok=True)
for i,(label,col,d) in enumerate(symbol(C['terracotta'],C['chocolate'])):
    content=f'<svg xmlns="http://www.w3.org/2000/svg" width="2240" height="800" viewBox="0 0 1120 400"><g transform="translate(40 35)"><path fill="{col}" fill-rule="evenodd" d="{d}"/></g></svg>'
    p=layers/f'{i}.svg';p.write_text(content);jobs.append({'svg':str(p),'out':str(layers/f'{i}.png'),'width':2240})
p=layers/'4.svg';p.write_text(f'<svg xmlns="http://www.w3.org/2000/svg" width="2240" height="800" viewBox="0 0 1120 400"><g transform="translate(398 105)">{"<path fill="+chr(34)+C["chocolate"]+chr(34)+" fill-rule="+chr(34)+"evenodd"+chr(34)+" d="+chr(34)+TEXT+chr(34)+"/>"}</g></svg>');jobs.append({'svg':str(p),'out':str(layers/'4.png'),'width':2240})
(ROOT/'jobs.json').write_text(json.dumps(jobs))
(OUT/'palette.json').write_text(json.dumps(C,indent=2))
print(f'Prepared {len(jobs)} renders')
