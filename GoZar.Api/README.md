# Go Zar API scaffold

The existing authentication system remains functional. New learning/catalog/profile/content features are **typed scaffolds**, not completed endpoints. Their services explicitly throw `NotImplementedException`; the exception handler returns HTTP **501 ProblemDetails**, not fake data or success.

## Start here

- `Configuration/ServiceRegistration.cs`: new feature/service registration, options and content-administration policy.
- `Features/*/*Controller.cs`: HTTP operation signatures and authorization boundaries.
- `Features/*/*Service.cs`: operations to implement one at a time, with cancellation and `// TODO :` notes.
- `Features/*/Contracts`: proposed API request/response contracts, separate from EF entities.
- `Domain`: geography, curriculum, learning state, user personalization and editorial/offline content.
- `Data/Configurations`: explicit EF table mappings, indexes, keys, restricted relationships and concurrency tokens.
- `Data/AppDbContext.Learning.cs`: new DbSets on the existing context.
- `Requests`: endpoint inventory and manual HTTP examples.
- `DECISIONS.md`: provisional choices, alternatives and implementation checkpoints.

## Scope

The scaffold covers catalog/city search, aliases/geometry/transit, onboarding goals and personal anchors, placement, Today/session previews, curriculum, stable learning sessions, introduction, exercises/answers/completion, due reviews, skill progress/streaks, stories, saved places/stories, preferences, offline manifests/answer batches, and role-protected content administration/imports.

Existing authentication already supports registration, confirmed-email login, token refresh, verification/resend, password recovery/change, email change, authenticator management, current account/roles, logout and account deletion. Do not replace it with the frontend placeholders or add a duplicate authentication flow. See `AUTHENTICATION.md`.

## Compatibility decisions

- `Models/ApplicationUser.cs`, `Models/AppDbContext.cs`, the existing Identity migrations and `Controllers/AuthenticationController.cs` retain their original namespaces and locations. `AppDbContext` is now partial and applies the new configurations.
- The existing email implementation and its local edits were preserved. The new `Infrastructure/Email` and `Features/Authentication` notes explain where a later physical reorganization could go.
- All new controllers require authentication. Content administration additionally requires the `Administrator` role. Provision roles through trusted operations; no public role-assignment endpoint was added.
- Per-user methods obtain the user ID from authenticated claims. The MAUI app cannot choose the effective user ID in its request body.
- API consumers use DTOs. Correct-answer JSON and option correctness remain persistence-only. They are never included in the public exercise DTO.
- Deletion of referenced entities is restricted by default. Application-data deletion/retention needs an explicit implementation before existing account deletion is used with learning records.

## Database: nothing has been applied

**No migration was generated or applied. No database or seed data was changed.** New entity/mapping definitions describe a proposed schema and must be reviewed first.

The existing migrations still describe Identity only. New operations remain unimplemented, so the scaffold does not pretend the new tables already exist. Before implementing persistence against a real database:

1. Review `DECISIONS.md` and the entity relationships.
2. Finalize the first feature's fields, validation, indexes and deletion policy.
3. Generate and inspect a migration deliberately.
4. Apply it to the chosen development database when ready.

No automatic `Database.Migrate`, `EnsureCreated`, import or seeding startup task was added.

## Suggested implementation order

1. Catalog read models and a reviewed Tehran snapshot.
2. Profile/onboarding persistence and personal anchors.
3. One complete persisted lesson/session, including accepted-answer transactions and idempotency.
4. Review scheduling and per-skill progress; streaks derived from accepted activity.
5. Richer exercise types, stories and moderation/publication.
6. Versioned offline packs and synchronization through the same answer-processing service.

Keep controllers thin. Services may use `AppDbContext` directly; no generic repository layer was added. Call planner/evaluator/scheduler policies from the feature service, and commit related writes atomically. Do not simply remove `throw` statements without implementing ownership, publication and transaction rules.

## Validation

```powershell
dotnet build GoZar.Api/GoZar.Api.csproj --no-restore
dotnet run --project work/api-scaffold-smoke/ApiScaffoldSmoke.csproj --no-launch-profile --no-restore
```

The separate smoke host uses synthetic test identities only, never the application's SMTP settings, user secrets or database. Its authentication handler is outside the API project and is not registered in production. It validates EF relational metadata without making a SQL connection, and checks HTTP authorization, validation, 501 ProblemDetails and OpenAPI output. It is not a test of real Identity login, SQL migrations or completed learning algorithms.
