using FluentValidation;

namespace Accounting.Application.Commands.InvoiceCommands
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
