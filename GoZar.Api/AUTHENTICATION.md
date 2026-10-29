# Authentication API

All routes are under `/api/Authentication`. No Identity pages are registered.

| Method | Route | Purpose |
| --- | --- | --- |
| POST | register | Email and password registration; sends confirmation email |
| POST | login | Email/password plus optional twoFactorCode or twoFactorRecoveryCode |
| POST | refresh | Exchange refreshToken for new tokens |
| GET | confirm-email | Follow emailed userId/code link; also confirms changedEmail |
| POST | resend-confirmation-email | Send another confirmation link |
| POST | forgot-password | Send an encoded password reset code by email |
| POST | reset-password | Submit email, resetCode, newPassword |
| GET | me | Current account and roles |
| POST | change-password | Submit currentPassword and newPassword |
| POST | change-email | Send confirmation link to newEmail |
| POST | 2fa | Set up or manage authenticator and recovery codes |
| POST | logout | Invalidate all refresh tokens for the account |
| DELETE | me | Delete account after verifying password |

Routes starting with `me`, `change-`, `2fa`, and `logout` require an Authorization header: `Bearer <accessToken>`.
Tokens are ASP.NET Core Identity protected tokens, not JWTs. Access tokens last 15 minutes; refresh tokens last 7 days. Logout and password changes invalidate refresh tokens. Already-issued access tokens remain valid until expiration. Persist ASP.NET Core Data Protection keys for deployments that restart containers or use multiple instances.

## Database

Apply the generated Identity migration when ready:

All seven Identity tables use the `Identity` schema. The `MoveIdentityToIdentitySchema` migration transfers existing tables into that schema while preserving their data. Future application tables retain their normal schema.

```powershell
dotnet ef database update --project GoZar.Api
```

## Email

Configure `Email:Host`, `Email:Port` (default 587), `Email:From`, `Email:UserName`, `Email:Password`, and `Email:EnableSsl` (default true) using environment variables or a secret provider. For environment variables use double underscores, such as `Email__Host`. Confirmed email is required for login. No email tokens are returned by the API. Missing SMTP configuration causes email operations to fail; a registered account can request another confirmation once configuration is fixed.

Confirmation links use the request host and scheme. Configure allowed hosts and trusted reverse proxy settings to match the deployment.

## Authenticator setup

POST `{}` to `2fa` to get the shared key. Add it to an authenticator app, then POST `{ "enable": true, "twoFactorCode": "123456" }`. Store the returned recovery codes securely. The same endpoint supports `enable: false`, `resetSharedKey: true`, and `resetRecoveryCodes: true`.

Identity roles are stored and included in the authenticated profile. This controller deliberately exposes no public role-assignment or administrator user-management operations. External OAuth providers, SMS delivery, and passkeys need provider-specific configuration and are not implemented here.

All seven Identity tables use the `Identity` schema. Apply the `MoveIdentityToIdentitySchema` migration with the database update command above to transfer existing tables while preserving their data. Future application tables keep their normal schema.


The development Gmail sender uses MailKit on port 465 with TLS from connection start. Port 587 uses mandatory STARTTLS instead. The app password remains in .NET user secrets. SMTP failures log their stage (connecting, authenticating, or sending) without logging credentials or message content. Gmail TLS, authentication, and an authenticated NOOP command were verified without sending email.
