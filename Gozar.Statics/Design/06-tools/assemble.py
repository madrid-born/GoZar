from pathlib import Path
from PIL import Image,ImageDraw,ImageFont
import json,hashlib
root=Path(__file__).resolve().parent.parent
font=ImageFont.truetype('C:/Windows/Fonts/arial.ttf',22)
small=ImageFont.truetype('C:/Windows/Fonts/arial.ttf',16)
big=ImageFont.truetype('C:/Windows/Fonts/georgia.ttf',38)
groups=[('01-onboarding','Start somewhere familiar',0,6),('02-daily-learning','Learn, retrieve, understand',6,12),('03-exploration','Build a city in your mind',12,18),('04-progress-and-states','Return, review, recover',18,24)]
files=sorted((root/'02-screens/mobile').glob('*.png'))
for name,title,start,end in groups:
    sheet=Image.new('RGB',(1500,1570),'#ECE8DF');d=ImageDraw.Draw(sheet)
    d.text((55,35),'GO ZAR / PRODUCT DESIGN',font=small,fill='#79675C');d.text((55,67),title,font=big,fill='#512D1D')
    for j,p in enumerate(files[start:end]):
        x=55+(j%3)*480;y=155+(j//3)*690
        im=Image.open(p).convert('RGB');im.thumbnail((380,600),Image.Resampling.LANCZOS)
        sheet.paste(im,(x+(420-im.width)//2,y))
        label=p.stem.replace('-',' ').title();d.text((x+15,y+615),label,font=font,fill='#512D1D')
    sheet.save(root/'05-overview'/f'{name}.jpg',quality=94)
    sheet.save(root/'05-overview'/f'{name}.png')
# JPG duplicates are convenient for non-design tools; PNG remains the reference.
jdir=root/'02-screens'/'jpg';jdir.mkdir(exist_ok=True)
for p in files:Image.open(p).convert('RGB').save(jdir/(p.stem+'.jpg'),quality=94)
cards=[]
for i,p in enumerate(files):
    sid=p.stem.split('-',1)[1]
    cards.append(f'<a href="index.html#{"home" if sid=="home-dark" else sid}"><img loading="lazy" src="../02-screens/mobile/{p.name}" alt="{p.stem}"/><span>{p.stem.replace("-"," ").title()}</span></a>')
gallery='''<!doctype html><html lang="en"><head><meta charset="utf-8"><meta name="viewport" content="width=device-width,initial-scale=1"><title>Go Zar · Screen gallery</title><style>*{box-sizing:border-box}body{margin:0;padding:40px;background:#ECE8DF;color:#512D1D;font-family:Arial,sans-serif}h1{font:36px Georgia,serif}p{color:#79675C}a{color:#B85E3C}.grid{display:grid;grid-template-columns:repeat(auto-fill,minmax(240px,1fr));gap:35px;margin-top:35px}.grid a{display:block;text-decoration:none}.grid img{display:block;width:100%;height:610px;object-fit:contain;object-position:top;background:#FFFCF4;border-radius:15px;box-shadow:0 10px 30px #512D1D0C}.grid span{display:block;font-size:13px;margin-top:14px}@media(max-width:600px){body{padding:20px}.grid img{height:auto}}</style></head><body><a href="index.html">← Clickable prototype</a> · <a href="../03-design-system/components.html">Design system</a><h1>A city becomes familiar.</h1><p>24 proposed screens + a dark home preview. Click any screen to explore it.</p><div class="grid">'''+''.join(cards)+'''</div></body></html>'''
(root/'01-prototype/gallery.html').write_text(gallery,encoding='utf-8')
manifest=[]
for p in sorted(root.rglob('*')):
    if p.is_file() and p.name!='MANIFEST.json':manifest.append({'file':p.relative_to(root).as_posix(),'bytes':p.stat().st_size,'sha256':hashlib.sha256(p.read_bytes()).hexdigest()})
(root/'MANIFEST.json').write_text(json.dumps(manifest,indent=2),encoding='utf-8')
print(f'Assembled overview sheets and gallery; {len(manifest)} files indexed.')
