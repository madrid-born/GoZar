const fs=require('fs');
const sharp=require('sharp');
const path=require('path');
(async()=>{const jobs=JSON.parse(fs.readFileSync(path.join(__dirname,'jobs.json')));for(const j of jobs){let im=sharp(j.svg,{density:300}).resize({width:j.width});if(j.background)im=im.flatten({background:j.background}).jpeg({quality:95,chromaSubsampling:'4:4:4'});else im=im.png();await im.toFile(j.out);}console.log(`Rendered ${jobs.length} assets`);})().catch(e=>{console.error(e);process.exit(1)});
