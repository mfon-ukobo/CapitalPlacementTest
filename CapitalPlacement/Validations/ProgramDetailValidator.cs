using CapitalPlacement.Models.ProgramDetailModels;
using FluentValidation;

namespace CapitalPlacement.Validations
{
    public class ProgramDetailValidator : AbstractValidator<ProgramDetail>
    {
        public ProgramDetailValidator()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull().WithMessage("Title is required");
        }
    }
}
