# Go Zar · screen design pack

**Start here:** open `01-prototype/index.html` in Edge or Chrome. No installation or server is needed. Pick a screen from the left panel, or follow the Persian buttons inside the phone. This is a design proposal, not the working MAUI application.

## What you have

| Folder | What it is | When to use it |
|---|---|---|
| `00-assets` | Copies of the approved vector logo | Keep the prototype self-contained |
| `01-prototype` | Clickable Persian-first screens; editable HTML, CSS and JavaScript | Understand and discuss the experience |
| `02-screens/mobile` | Individual full-screen PNGs, plus a dark home example | Review, share or import as references into Figma/Photoshop |
| `02-screens/desktop` | Four wider adaptations | Explore desktop layout direction |
| `03-design-system` | Colors, typography, spacing and reusable component reference | Keep later implementation consistent |
| `04-handoff` | Screen requirements, learning rules and verification results | Translate the design into MAUI and API work |
| `05-overview` | Contact sheets, studio preview and user-flow diagram | See the entire proposal at a glance |
| `06-tools` | Reproducible browser rendering/checking and contact-sheet scripts | Update exports after editing the prototype |

## The suggested journey

1. **Welcome → choose Tehran → choose interests.** No account wall before trying a lesson.
2. **Important places.** Choose approximate public places or neighborhoods. Exact home location and GPS are not required.
3. **Optional familiarity check.** Existing knowledge influences the starting point; it is separate from personal importance.
4. **Today.** One small recommended session: a little new material, plus reviews.
5. **Lesson → recognition → feedback → locating.** Explain first, then ask for recall. An introduction does not imply mastery.
6. **Session complete.** Celebrate progress, reveal the growing map, and allow more practice.
7. **Explore.** Place details, a route-ordering exercise and stories connect the pieces.
8. **Return.** Due reviews get their own queue; preferences and offline support make the habit practical.

The chapter path is a friendly curriculum view. The API's planner would still choose relevant new places and schedule reviews separately behind it.

## How to use the prototype

- Click Persian action buttons to move through the main journey.
- Use the screen list to inspect alternative feedback and edge states directly.
- In a question, pick an answer before checking. Correct and incorrect responses have different screens.
- Add/remove important places; toggle learning interests; reorder a route with up arrows.
- Use **Dark preview** and **Desktop preview** in the studio to compare adaptations.
- **All screens** opens the visual gallery once the included PNGs are present.
- **Reset demo** returns to the initial sample state. State is in memory and resets when reloaded.

## What is intentionally illustrative

- Maps are hand-drawn teaching diagrams, **not geographically accurate maps** and not safe for navigation. Their sample labels communicate interaction and hierarchy. Production should use reviewed OSM geometry and appropriate attribution.
- The route activity teaches ordering on a schematic. It does not calculate a walking, driving, metro or BRT journey.
- Progress, review counts, streaks, estimated time and downloaded data are sample values. The prototype condenses a longer session to show the interaction; its completion numbers are not calculated from clicks.
- The familiarity check does not calculate a real placement score. The resulting notice says so.
- Only Tehran is selectable. Other cities show “coming soon.”
- Settings are local demonstrations. No real GPS permission, account, push notification, download, API call or synchronization occurs.
- The story is editorial placeholder content. Historical claims and sources require review before release.
- Dark mode is an exploratory treatment; the exported dark home is a reference rather than a complete native dark-mode audit.
- This pack contains no Figma project or layered screen PSD. UI editing happens in the HTML/CSS sources; the PNGs are flattened references. The earlier logo PSDs remain in the Logo folder.

## Brand direction

Warm ivory, terracotta and chocolate; soft architectural corners; generous space; restrained rosette/step motifs. Ancient Persian identity is expressed through the approved logo and a few geometric details, rather than decorating every control. The phone app is Persian and RTL; English text around it explains design decisions for you as the developer.

## Next implementation decisions

Before coding all screens, agree on onboarding inputs, the definition of remembered knowledge, review scheduling and the minimum useful Tehran chapter. Begin with screens 01–13 plus basic map and reviews. The rest clarifies future scope and edge behavior. Authentication may follow the first useful session, with account recovery and synchronization designed as a separate flow.

No application code, solution configuration, database or existing logo artwork was changed by this design pack.
