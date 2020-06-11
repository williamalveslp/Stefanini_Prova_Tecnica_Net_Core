using FluentValidation;
using StefaniniCore.Application.InputModels.Tasks;

namespace StefaniniCore.Services.Validators
{
    public class TaskInputModelValidator : AbstractValidator<TaskInputModel>
    {
        public TaskInputModelValidator()
        {
            RuleFor(f => f).NotNull().WithMessage("Erro no envio dos dados.");

            RuleFor(f => f.Name).NotNull().WithMessage("Campo 'Nome' está inválido.");
            RuleFor(f => f.Name).NotEmpty().WithMessage("Campo 'Nome' não foi preenchido.");
            RuleFor(f => f.Name).MinimumLength(3).WithMessage("Campo 'Nome' deve possuir no mínimo 3 caracteres.");
            RuleFor(f => f.Name).MaximumLength(30).WithMessage("Campo 'Nome' deve possuir no máximo 30 caracteres.");
        }
    }
}
