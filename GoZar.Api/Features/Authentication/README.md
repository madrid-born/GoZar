# Existing authentication

Authentication is already implemented in `Controllers/AuthenticationController.cs`.
Its request records, namespace, routes and Identity behavior were preserved.
See `../../AUTHENTICATION.md` for contracts. Do not build a second authentication system.

TODO : Relocate the controller/contracts here only if desired, preserving routes and existing clients.
TODO : Add account data export and coordinate account deletion with restricted application foreign keys.
