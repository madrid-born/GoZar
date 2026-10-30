$ErrorActionPreference = 'Stop'
$projectFile = Join-Path $PSScriptRoot 'GoZar.Maui.csproj'
dotnet publish $projectFile -f net10.0-windows10.0.19041.0 -c Release -p:RuntimeIdentifierOverride=win-x64 -p:WindowsPackageType=None -p:WindowsAppSDKSelfContained=true -p:SelfContained=true
exit $LASTEXITCODE