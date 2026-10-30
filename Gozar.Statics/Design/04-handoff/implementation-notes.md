# Implementation handoff

## Scope and priorities

These are proposed product screens, not a specification to automatically implement in full. Phase 1: onboarding, Today, one chapter, place introduction, recognition, feedback, session completion, due reviews and map. Phase 2: richer locating/tracing, route exercises, editorial stories and deeper personalization. Make offline behavior real only after choosing synchronization and content versioning rules.

## Screen index and responsibilities

| ID | Screen | Main input / action | Production data / rule |
|---|---|---|---|
| 01 | Welcome | Start or try a lesson | Guest/local profile; defer account requirement |
| 02 | City | Choose published city | City availability and downloaded content version |
| 03 | Goals | Select multiple interests | User learning goals; affect future candidate mix |
| 04 | Anchors | Add approximate important locations | User anchors separate from prior knowledge; resolve against catalog/geocoder later |
| 05 | Placement | Answer optional questions | Multiple evidence-based checks; never mark mastered from one guess |
| 06 | Today | Begin planned session | Server-created stable session; due reviews + relevant new content |
| 07 | Path | Continue chapter | Published curriculum, prerequisites, completed/reviewable lessons |
| 08 | Lesson | Study place and continue | Place geometry, aliases, references; record introduction, not mastery |
| 09 | Recognition | Select then submit answer | Session/question IDs; no correct answer leakage before submission |
| 10 | Correct | Read explanation and continue | Server-accepted result; update relevant skill evidence |
| 11 | Correction | Retry or return to teaching | Schedule earlier review; preserve existing knowledge |
| 12 | Locate | Choose a geographic target | Segment-aware geometry, touch tolerance, keyboard alternative |
| 13 | Complete | Map, review more or stop | Real introduced/reviewed counts; streak awarded once per local date |
| 14 | Map | Change layer, inspect place | Faint context plus introduced/remembered places; scale and orientation stability |
| 15 | Place | Study, save, inspect connections | Geometry, aliases, reviewed relationships, skill progress |
| 16 | Journey | Order landmarks | Curated valid educational route; distinguish from live navigation |
| 17 | Reviews | Start review-only session | Due date, difficulty, prior attempts, skill; not relevance ranking alone |
| 18 | Stories | Browse editorial content | Published city facts, illustrations, reviewed sources |
| 19 | Story | Read, save, locate | Source provenance; tie narrative to a place and future exercise |
| 20 | Progress | Inspect skill summaries | Separate introduced vs remembered; avoid fabricated precise mastery percentages |
| 21 | Preferences | Goal, reminders, download, account | Per-user settings, explicit OS permissions, account/sync flow later |
| 22 | Offline | Continue cached session | Download manifest, versioned geometry and local pending answer outbox |
| 23 | Empty map | Start first lesson | Show geographic context even when progress is zero |
| 24 | Interrupted download | Retry or use local content | Keep old content until replacement validated; resumable/atomic downloads |

## Learning and personalization rules

- Candidate relevance: general importance + proximity to personal anchors + useful connections to familiar places + selected goals − difficulty/redundancy. Tune weights using evidence, not arbitrary precision.
- Review scheduling is independent. New content must not displace overdue practice indefinitely.
- Maintain per-target, per-skill evidence: recognizing name, locating, shape/orientation, relationships and journey reasoning.
- “Introduced” records exposure. “Remembered” needs successful recall across different sessions and suitable question types. Neither is an irreversible boolean.
- Stable session IDs/question order allow resuming after interruption. Use idempotency keys for offline submissions, point awards and daily streak updates.
- Do not infer long-road relationships solely from a center point. Filter ambiguous direction questions; use explicit road segments and reviewed connections.

## Suggested boundaries

- MAUI views: rendering, input, accessibility, local cache/outbox and network status.
- API learning service: plan session, validate/accept answer, update skill progress, choose next review.
- Content/catalog: published places, geometry, localized aliases, chapters, facts, sources and relationships.
- Persistence: user anchors, goals, sessions, answers, skill progress, content versions and optional sync account.

## Visual implementation mapping

- Buttons, switches, labels and lists should be real native accessible controls.
- Share color/spacing resources and reusable components: TopBar, PrimaryAction, ChoiceRow, LearningMap, ProgressStrip, FeedbackPanel, BottomNavigation, PlaceRow and OfflineBanner.
- Use semantic RTL layout and test mixed Persian/Latin text. English place aliases get their own LTR text block.
- Keep tappable controls at least 44 logical pixels; do not shrink all content to fit a reference phone. Scroll long lessons, respect safe areas and keyboard insets.
- Avoid encoding knowledge exclusively through color. Pair state with text, shape or an icon.
- Native font scaling and screen-reader reading order still need device testing. Prototype labels and focus behavior are starting points, not accessibility certification.
- Desktop should rearrange map and details side by side; it should not simply enlarge a phone. Four exported wide frames explore this direction.

## Missing before production

Real map rendering and attribution; reviewed content and aliases; placement calibration; authentication/recovery screens; data deletion/export; notifications permission flow; error taxonomy; localization; content licensing; app store screenshots; real offline conflict handling; and native accessibility testing. No conclusions about these can be inferred from the visual mockups alone.
