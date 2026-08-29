[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.emails.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.emails/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.emails/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.emails/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.emails.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.emails/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.emails/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.emails/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Emails

An AutoFaker override that produces a populated `EmailDto` suitable for tests and fixtures.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Emails
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Emails;
using Soenneker.Dtos.Email;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new EmailDtoOverride()];

EmailDto email = autoFaker.Generate<EmailDto>();
```

The result always has a `To` recipient, reply-to address, sender name and address, subject, body, and a randomly selected `EmailFormat`. `Cc` and `Bcc` are independently optional. Values are synthetic Bogus data; they are not intended for delivery.
