from pathlib import Path
from PIL import Image,ImageDraw,ImageFont
import struct,json,hashlib,shutil,xml.etree.ElementTree as ET
ROOT=Path(__file__).resolve().parent;OUT=ROOT.parent
def u16(n):return struct.pack('>H',n)
def u32(n):return struct.pack('>I',n)
def psd(path,items,size):
    w,h=size; records=[];pixels=[]
    # PSD layers are ordered top to bottom.
    merged=Image.new('RGBA',size)
    for _,im in reversed(items):merged.alpha_composite(im)
    for name,im in items:
        bounds=im.getbbox() or (0,0,1,1);l,t,r,b=bounds;im=im.crop(bounds).convert('RGBA')
        channels=[im.getchannel(c).tobytes() for c in ['R','G','B','A']]
        record=struct.pack('>iiiiH',t,l,b,r,4)
        for cid,data in zip([0,1,2,-1],channels):record+=struct.pack('>hI',cid,len(data)+2)
        nm=name.encode('ascii');pas=bytes([len(nm)])+nm;pas+=b'\0'*((-len(pas))%4)
        extra=u32(0)+u32(0)+pas
        record+=b'8BIMnorm'+bytes([255,0,0,0])+u32(len(extra))+extra
        records.append(record);pixels.extend(u16(0)+d for d in channels)
    layerinfo=struct.pack('>h',-len(items))+b''.join(records)+b''.join(pixels)
    if len(layerinfo)%2:layerinfo+=b'\0'
    lm=u32(len(layerinfo))+layerinfo+u32(0)
    header=b'8BPS'+u16(1)+b'\0'*6+u16(4)+u32(h)+u32(w)+u16(8)+u16(3)
    path.write_bytes(header+u32(0)+u32(0)+u32(len(lm))+lm+u16(0)+b''.join(merged.getchannel(c).tobytes() for c in ['R','G','B','A']))
    check=Image.open(path);check.load();assert check.size==size

psdir=OUT/'06-photoshop';psdir.mkdir(exist_ok=True)
names=['Terracotta upper module','Terracotta passage left','Terracotta passage right','Chocolate rosette module','Outlined wordmark']
imgs=[Image.open(ROOT/'layers'/f'{i}.png').convert('RGBA') for i in range(5)]
psd(psdir/'gozar-horizontal-layered.psd',list(reversed(list(zip(names,imgs)))),(2240,800))
base=Image.new('RGBA',(800,800))
symitems=[]
for i in range(4):
    b=imgs[i].getbbox();crop=imgs[i].crop(b);layer=Image.new('RGBA',(800,800));layer.alpha_composite(crop,((b[0]-80)+78,(b[1]-70)+68));symitems.append((names[i],layer))
psd(psdir/'gozar-symbol-layered.psd',list(reversed(symitems)),(800,800))

web=OUT/'07-web';web.mkdir(exist_ok=True)
icon=Image.open(OUT/'04-app-icons'/'gozar-app-icon-1024.png').convert('RGBA')
icon.save(web/'favicon.ico',sizes=[(16,16),(32,32),(48,48),(64,64),(128,128),(256,256)])
for size,name in [(180,'apple-touch-icon.png'),(192,'icon-192.png'),(512,'icon-512.png')]:icon.resize((size,size),Image.Resampling.LANCZOS).save(web/name)
for layout in ['horizontal','stacked','symbol','wordmark']:
    Image.open(OUT/'02-png'/layout/f'gozar-{layout}-primary-1024w.png').save(web/f'gozar-{layout}.webp',lossless=True)
(web/'site.webmanifest').write_text(json.dumps({'name':'Go Zar','short_name':'Go Zar','icons':[{'src':f'icon-{s}.png','sizes':f'{s}x{s}','type':'image/png'} for s in [192,512]],'theme_color':'#B85E3C','background_color':'#FFFCF4','display':'standalone'},indent=2),encoding='utf-8')

preview=Image.new('RGB',(1600,1150),'#FFFCF4');d=ImageDraw.Draw(preview);font=ImageFont.truetype('C:/Windows/Fonts/arial.ttf',24)
tiles=[('Horizontal - primary','horizontal','primary',(50,65,1500,430)),('Square / stacked','stacked','primary',(45,500,650,550)),('Symbol only','symbol','primary',(745,500,400,450)),('Dark background','symbol','reversed',(1180,500,360,450))]
for label,layout,var,(x,y,w,h) in tiles:
    d.text((x,y-35),label,font=font,fill='#512D1D')
    if var=='reversed':d.rounded_rectangle((x,y,x+w,y+h),radius=20,fill='#512D1D')
    im=Image.open(OUT/'02-png'/layout/f'gozar-{layout}-{var}-1024w.png').convert('RGBA');im.thumbnail((w,h),Image.Resampling.LANCZOS);preview.paste(im,(x+(w-im.width)//2,y+(h-im.height)//2),im)
preview.save(OUT/'PREVIEW.jpg',quality=94)
guide='''# Go Zar logo pack

Start with PREVIEW.jpg. This pack develops the approved AI concept into clean vector artwork: rounded stepped modules, simplified six-petal rosette, terracotta and chocolate colors. It is a faithful production redraw, not a pixel-identical reproduction of the textured concept image. The original is retained in 00-source.

## Folder map

- 00-source: approved concept and editable outlined SVG master.
- 01-vector: scalable SVGs organized by horizontal, stacked (square), symbol and wordmark.
- 02-png: transparent RGBA exports in multiple sizes. The number is width in pixels. Stacked and symbol files are square.
- 03-jpg: flattened exports at 2048 px wide, on ivory or chocolate backgrounds.
- 04-app-icons: full-bleed ivory app icon, SVG and PNG sizes 16 through 1024. Let the OS apply its own mask.
- 05-maui: separate background and foreground icon SVGs plus splash symbol; usage example below. These assets have not been compiled in a MAUI application.
- 06-photoshop: real layered PSDs for the horizontal logo and symbol. Modules and wordmark are separate raster layers at fixed resolution. The rosette is a transparent cutout within its module. These are not vector shape layers or live text. Use the SVG master for unlimited scaling and path editing.
- 07-web: favicon ICO, Apple touch icon, PWA icons and manifest, lossless WebP logos.
- 08-build: reproducible build scripts. Requirements: Python 3 with Pillow and NumPy; Node.js with sharp. Run build.py, render.cjs, finish.py in order with UTF-8 enabled. The approved concept must remain in 00-source.
- palette.json: exact sRGB hex colors.
- MANIFEST.json: file sizes and SHA-256 hashes for delivery verification.

## Choose a variant

primary: terracotta symbol, chocolate rosette block and wordmark; use on white or ivory.
reversed: terracotta symbol, ivory rosette block and wordmark; use on chocolate/dark backgrounds.
mono-dark: chocolate single-color artwork; use on light backgrounds.
mono-white: white single-color artwork; use on dark backgrounds.

SVG and PNG backgrounds and the passage/rosette cutouts are genuinely transparent. JPG cannot contain transparency. Prefer SVG in software; PNG for image-only workflows; JPG for sharing; PSD for layered Photoshop work. The wordmark is outlined to retain the approved letter shapes without a font dependency. It is not keyboard-editable text. Persian lettering was not part of the approved final concept, so this pack does not invent a Persian wordmark.

## Brand colors

- Terracotta: #B85E3C
- Chocolate: #512D1D
- Ivory: #FFFCF4

Keep at least one rosette-width of clear space around the mark. Avoid stretching, drop shadows or rearranging individual modules. Use symbol-only artwork for compact interfaces. At 16-32 pixels the rosette detail will naturally soften; use the larger source for high-density displays.

## MAUI integration example

Copy appicon.svg and appiconfg.svg into your app's Resources/AppIcon directory, and splash.svg into Resources/Splash. Replace existing icon/splash declarations rather than adding duplicates:

```xml
<MauiIcon Include="Resources\\AppIcon\\appicon.svg"
          ForegroundFile="Resources\\AppIcon\\appiconfg.svg" />
<MauiSplashScreen Include="Resources\\Splash\\splash.svg"
                  Color="#FFFCF4" BaseSize="128,128" />
```

No application project or build configuration was modified. Preview icon masking on actual target devices before release. Store listing screenshots and promotional banners require app UI and copy, so they are outside this logo pack.

All supplied artwork uses sRGB colors. Obtain a printer-specific CMYK conversion for physical printing.
'''
(OUT/'README.md').write_text(guide,encoding='utf-8')
print('Finished PSD, web and preview assets')
