/* Set NODE_PATH to your node_modules directory if playwright is not installed locally. */
const fs=require('fs'),path=require('path'),{pathToFileURL}=require('url');
const {chromium}=require('playwright');
const root=path.resolve(__dirname,'..');
(async()=>{
 const browser=await chromium.launch({executablePath:process.env.GOZAR_BROWSER||'C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe',headless:true});
 const page=await browser.newPage({viewport:{width:390,height:844},deviceScaleFactor:2});
 const errors=[];page.on('pageerror',e=>{errors.push(e.message);console.error('PAGE ERROR:',e.message)});page.on('requestfailed',r=>console.error('REQUEST FAILED:',r.url(),r.failure()?.errorText));
 const url=pathToFileURL(path.join(root,'01-prototype/index.html')).href;
 await page.goto(url+'?capture=1');await page.waitForFunction(()=>window.GozarDesign);
 const screens=await page.evaluate(()=>GozarDesign.screens.map(s=>({id:s[0],title:s[1]})));
 let results=[];
 for(const [i,s] of screens.entries()){
  await page.evaluate(id=>GozarDesign.render(id),s.id);
  await page.screenshot({path:path.join(root,'02-screens/mobile',`${String(i+1).padStart(2,'0')}-${s.id}.png`),fullPage:true});
  const box=await page.evaluate(()=>({viewport:innerWidth,scroll:document.documentElement.scrollWidth,height:document.documentElement.scrollHeight}));
  if(box.scroll>box.viewport+1)throw Error(`Horizontal overflow: ${s.id}`);
  results.push({...s,...box});
 }
 for(const s of ['home','map','lesson','profile']){
  await page.setViewportSize({width:1440,height:960});await page.goto(url+'?capture=1&layout=desktop#'+s);
  await page.screenshot({path:path.join(root,'02-screens/desktop',s+'-1440.png'),fullPage:true});
 }
 await page.setViewportSize({width:390,height:844});await page.goto(url+'?capture=1&theme=dark#home');
 await page.screenshot({path:path.join(root,'02-screens/mobile','25-home-dark.png'),fullPage:true});
 // Check the core actions, including both feedback branches and route reordering.
 await page.goto(url+'?capture=1#quiz');
 await page.locator('[data-answer="1"]').click();await page.locator('[data-action="check"]').click();
 if(!page.url().endsWith('#incorrect'))throw Error('Incorrect answer branch failed');
 await page.locator('[data-go="quiz"]').last().click();await page.locator('[data-answer="0"]').click();await page.locator('[data-action="check"]').click();
 if(!page.url().endsWith('#correct'))throw Error('Correct answer branch failed');
 await page.locator('#app [data-go="locate"]').click();await page.locator('[data-target="north"]').click();await page.locator('[data-action="locate-check"]').click();
 if(!page.url().endsWith('#complete'))throw Error('Location exercise failed');
 await page.evaluate(()=>GozarDesign.render('anchors'));let before=await page.locator('.anchor').count();await page.locator('#anchor-name').fill('محله نمونه');await page.locator('[data-action="add-anchor"]').click();if(await page.locator('.anchor').count()!==before+1)throw Error('Anchor creation failed');await page.locator('[data-remove]').last().click();
 await page.evaluate(()=>GozarDesign.render('route'));await page.locator('[data-move="1"]').click();await page.locator('[data-move="2"]').click();await page.locator('[data-action="route-check"]').click();if(!page.url().endsWith('#complete'))throw Error('Route ordering failed');
 await page.evaluate(()=>GozarDesign.render('offline'));await page.locator('[data-action="reconnect"]').last().click();if(!page.url().endsWith('#home'))throw Error('Reconnect action failed');
 await page.setViewportSize({width:320,height:740});for(const s of screens){await page.evaluate(id=>GozarDesign.render(id),s.id);if(await page.evaluate(()=>document.documentElement.scrollWidth>innerWidth+1))throw Error('320px overflow: '+s.id)}
 await page.goto(url+'#home');await page.setViewportSize({width:1440,height:1000});await page.screenshot({path:path.join(root,'05-overview','prototype-studio.png'),fullPage:true});
 await page.goto(pathToFileURL(path.join(root,'03-design-system/components.html')).href);await page.screenshot({path:path.join(root,'03-design-system','components.png'),fullPage:true});
 if(errors.length)throw Error(errors.join('\n'));
 fs.writeFileSync(path.join(root,'04-handoff','verification.json'),JSON.stringify({checkedAt:new Date().toISOString(),browser:'Microsoft Edge / Playwright',screens:results,checks:['24 light screens + 1 dark screen rendered','4 desktop adaptations rendered','No horizontal overflow at 390px and 320px','Wrong and correct answer feedback','Location question completion','Add and remove personal anchor','Reorder route and check','Offline reconnect simulation','No JavaScript runtime errors'],limitations:['Concept only: sample counts and simplified sessions, no server or real authentication','Maps are illustrative diagrams, not navigation geometry','No MAUI compilation or native device testing']},null,2));
 await browser.close();console.log('Rendered screens and passed interaction/layout checks.');
})().catch(e=>{console.error(e);process.exit(1)});
