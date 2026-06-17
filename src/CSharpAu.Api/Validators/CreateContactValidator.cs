using CSharpAu.Api.Models;
using FluentValidation;

namespace CSharpAu.Api.Validators;

public class CreateContactValidator : AbstractValidator<CreateContactDto> {
    public CreateContactValidator() {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Email).NotEmpty().EmailAddress().MaximumLength(100);
        RuleFor(x => x.Message).NotEmpty().MinimumLength(10).MaximumLength(5000);
    }
}