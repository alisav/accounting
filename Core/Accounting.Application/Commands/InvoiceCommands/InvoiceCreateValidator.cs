using FluentValidation;

namespace App.Application.Commands.InvoiceCommands
{
    public class InvoiceCreateValidator : AbstractValidator<InvoiceCreateCommand>
    {
        public InvoiceCreateValidator()
        {
            RuleFor(v => v.InvoiceDate)
                .NotEmpty();

            RuleFor(v => v.InvoiceNumber)
                .NotEmpty();
        }
    }
}
