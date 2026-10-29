# Go Zar logo pack

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
<MauiIcon Include="Resources\AppIcon\appicon.svg"
          ForegroundFile="Resources\AppIcon\appiconfg.svg" />
<MauiSplashScreen Include="Resources\Splash\splash.svg"
                  Color="#FFFCF4" BaseSize="128,128" />
```

No application project or build configuration was modified. Preview icon masking on actual target devices before release. Store listing screenshots and promotional banners require app UI and copy, so they are outside this logo pack.

All supplied artwork uses sRGB colors. Obtain a printer-specific CMYK conversion for physical printing.
