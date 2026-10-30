# Decisions to review before implementing features

Everything below is provisional and also reflected in nearby `// TODO :` comments.

| Area | Scaffold choice | Reconsider / implement |
|---|---|---|
| Project structure | One feature-organized API project | Split projects only when real boundaries justify the overhead |
| Existing Identity | Reuse its user type, context namespace, token scheme and migrations | Keep MAUI contracts aligned with the existing non-JWT Identity tokens |
| Entity identifiers | GUID app entities; existing Identity string user IDs | Confirm public ID format and stable IDs across OSM snapshot updates |
| Place types and skills | String codes | Central code registry, enums or lookup tables once supported values settle |
| Shared place identity | Global importance, representative coordinate and type-specific details | Add detail tables only for real fields; landmarks/neighborhoods can initially use Place + geometry |
| Geometry | Versioned GeoJSON text, decimal representative coordinates | SQL Server spatial types/indexing, simplified vector tiles, segment-aware roads; validate actual geometry before publishing |
| Schemas | Catalog, Curriculum, Learning, Profiles, Content | Review naming with the existing Identity schema before migrations |
| Dates/timezones | UTC instants + user-local daily dates + timezone IDs | Audit timestamps, timezone conversion, midnight and timezone-change policy; no fixed UTC offsets |
| Relationships | Explicit FK relations, restrictive deletes | Same-city checks, type checks, dependency-cycle checks, archival and account-data retention |
| Target identity | Either one place or one relationship | The check constraint enforces exactly one reference; validate kind consistency and uniqueness |
| Curriculum | Chapters, lessons, places and prerequisites | Curated coherent lesson ordering; avoid teaching solely by road length or score |
| Personalization | Separate anchors, goals and prior-knowledge placement | Define self-report evidence, eligibility, distance to geometry and ranking weights |
| Sessions | Persist items/exercises; unique user + client request ID | Resumption, abandonment, content snapshots and concurrent requests |
| Answer payload | Provisional JSON by exercise type | Discriminated validated contracts, payload size limits and strict per-type validation |
| Answer storage | One accepted answer per persisted exercise; unique client submission ID per user | Retry exercises versus repeated attempts, identical-payload replay rules and stale offline submissions |
| Rewards | Optional score transaction linked once to accepted answer | Decide whether points exist; transactionally enforce no duplicate rewards |
| Correct-answer secrecy | Private entity fields; public exercise DTO has no answer keys | Mapping must be explicit; never serialize entities or shared packs containing answer keys |
| Review scheduler | Dedicated placeholder, state JSON reserved | Choose algorithm/calibration and limits; reviews are not just relevance-ranked content |
| Mastery | Per-target, per-skill progress | Define meaningful states using evidence across sessions, not three lifetime correct answers |
| Streak | Daily activity records, separate calculation service | Review-only activity qualification, grace days, local-day boundaries and time changes |
| HTTP contracts | Proposed typed DTOs and routes | Finalize response codes, versioning, row-version/concurrency headers, pagination and 404/409 semantics |
| Catalog access | All scaffold endpoints require login | Explicitly choose anonymous published catalog access if guest onboarding becomes a requirement |
| Administration | Administrator role; create/update/publication methods | Trusted role provisioning, draft reads, audit actor, conflict handling, archive versus deletion |
| Imports | Uploaded storage key, dry-run flag and validation service | Safe uploads, maximum sizes/types, stable external IDs, provenance and durable job status |
| Editorial content | Stories, facts and source relations | Source review, licensing, historical accuracy and publishing permissions |
| Offline | Published versioned manifests and per-answer batch results | Package storage/URLs, checksums, downloads, limits, compatibility and stale content policy |
| Sync | Must call the online accepted-answer logic | Ownership per item, authoritative server time, partial failures and transactional deduplication |
| Reminders | Preferences only | Device-local notifications versus server push; no sender or fake device registration implemented |
| Data protection | Existing authentication setup preserved | Deployment key persistence and account deletion/export must include app data before production |
| Contracts reuse | DTOs currently inside features | Introduce GoZar.Contracts later if both frontend/backend should reference common types |

The framework plumbing (current-user claims, pagination validation, DI and explicit 501 responses) works. Learning, catalog, moderation, imports, storage and synchronization operations are intentional TODOs and throw until implemented. The absence of an implementation is never treated as successful persistence.
