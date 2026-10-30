# Existing email infrastructure

`Services/IdentityEmailSender.cs` and its SMTP options are reused as-is; existing local edits were not moved or overwritten.
TODO : Consider separating options and physically relocating this implementation without changing existing email behavior.
