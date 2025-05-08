using Soenneker.Dtos.Email;
using Soenneker.Enums.Email.Format;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.Emails;

/// <summary>
/// An AutoFaker (AutoBogus) override for the DTO EmailDto
/// </summary>
public sealed class EmailDtoOverride : AutoFakerOverride<EmailDto>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as EmailDto)!;
        target.To = [context.Faker.Internet.Email()];
        target.Cc = context.Faker.Random.Bool() ? [context.Faker.Internet.Email()] : null;
        target.Bcc = context.Faker.Random.Bool() ? [context.Faker.Internet.Email()] : null;
        target.ReplyTo = context.Faker.Internet.Email();
        target.Name = context.Faker.Name.FullName();
        target.Address = context.Faker.Internet.Email();
        target.Subject = context.Faker.Lorem.Sentence();
        target.Body = context.Faker.Lorem.Paragraphs(2);
        target.Format = context.Faker.PickRandom<EmailFormat>();
    }
}