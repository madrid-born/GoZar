# Go Zar MAUI frontend scaffold

This is a **starting structure**, not the implemented design or an API-connected application. Pages share a temporary branded shell so each feature can be developed independently.

## Start here

- `App.xaml.cs`: creates the application window. Startup currently goes to the authentication welcome page.
- `AppShell.xaml` / `.cs`: authentication root, main tabs and dependency-injected page factories.
- `Services/ServiceRegistration.cs`: page, view-model and service registrations, plus Shell routes.
- `Services/Navigation/Routes.cs`: route names. Do not scatter route strings through pages.
- `Features/Authentication/LoginPage.xaml` and `LoginViewModel.cs`: a practical first feature to finish.
- `Shared/Controls/ScaffoldView.xaml`: the temporary shared layout. Replace it inside individual feature pages as their real UI is implemented.
- `../Gozar.Statics/Design/START-HERE.html`: the earlier visual prototype, not native app code.

## Implemented foundations

- 23 XAML page/view-model pairs grouped by feature.
- Six authentication screens: welcome, login, registration, email verification, forgot password and reset password.
- Form fields in authentication pages where obvious; submission remains disabled until real validation and API integration exist.
- Onboarding, Today, curriculum, lessons/exercises, map, place details, reviews, stories, progress, preferences and downloads.
- Reusable control shells and three exercise-view shells.
- MVVM property notification and navigation commands; loading/error properties.
- Brand colors, typography/spacing dictionaries, basic RTL and the approved logo.
- API client boundaries with no invented endpoint paths or DTO shapes.
- Secure token-storage wrapper and a device-preference wrapper.
- Localization resource files; string migration is a TODO.

## Inspect pages before API integration

In **Debug**, Welcome includes a clearly labeled developer-only screen catalog. It links to all page shells and lets you inspect the main tabs. This does **not** authenticate a user and does not load data. The catalog class and entry point are excluded from Release.

Main tabs are initially hidden. Login and registration do not fake success or navigate into an authenticated session. The session-restoration service is intentionally unfinished and is not called at startup.

## Responsibilities

```text
Page / reusable view → ViewModel → feature API client → server
                                      ↓
                            request/response contracts
```

The server owns catalogs, lesson ordering, personalization, correctness, reviews, mastery, points and streaks. The frontend owns presentation, input state, navigation, cancellation and eventual cache/outbox handling.

`Models/Api/*/Contracts.cs` reserves a location for agreed contracts; these files intentionally contain no guessed DTOs. Reference a shared contracts project instead if introduced. Never reference EF entities or the API persistence layer.

Offline classes and the exercise-template selector are placeholders. They perform no downloads, synchronization, routing calculations or learning decisions. Error/empty/offline/correct/incorrect states belong to their shared controls rather than separate full pages.

## TODO convention

Search for `TODO :` to find undecided or unimplemented work. Most importantly:

1. Agree authentication endpoints, request/response shapes, token lifecycle and password policy.
2. Configure `ApiOptions.BaseAddress`, error envelopes and the authentication HTTP handler.
3. Implement login/registration and validated session restoration; route new users to onboarding and returning users to Today.
4. Add page activation, cancellation and API loading to one feature at a time.
5. Replace shared placeholder shells with native layouts from the design pack.
6. Choose the map renderer, Persian font/localization binding and offline storage strategy.

`RestoreSessionAsync` explicitly throws until implemented. The authentication HTTP handler is not registered yet. `SignOutAsync` currently clears the local access token only; server revocation/cache clearing/navigation remain TODOs. Do not treat any of these placeholders as production authentication.

The original `MainPage` starter remains in the project but is no longer routed. Platform folders, application identity, targets and the existing publish script were retained. No backend project was modified.

## Build

```powershell
dotnet build GoZar.Maui/GoZar.Maui.csproj -f net10.0-windows10.0.19041.0 --no-restore
```

Other targets require their existing platform workloads/toolchains. A successful Windows build does not verify mobile rendering or server integration.
