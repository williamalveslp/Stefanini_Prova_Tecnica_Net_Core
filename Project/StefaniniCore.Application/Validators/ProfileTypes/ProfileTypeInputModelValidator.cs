using FluentValidation;
using StefaniniCore.Application.InputModels.ProfileTypes;

namespace StefaniniCore.Application.Validators.ProfileTypes
{
    public class ProfileTypeInputModelValidator : AbstractValidator<ProfileTypeInputModel>
    {
        public ProfileTypeInputModelValidator()
        {
            RuleFor(f => f).NotNull().WithMessage("Erro no envio dos dados.");

            RuleFor(f => f.Name).NotNull().WithMessage("Campo 'Nome do Perfil' está inválido.");
            RuleFor(f => f.Name).NotEmpty().WithMessage("Campo 'Nome do Perfil' não foi preenchido.");
            RuleFor(f => f.Name).MinimumLength(3).WithMessage("Campo 'Nome do Perfil' deve possuir no mínimo 3 caracteres.");
            RuleFor(f => f.Name).MaximumLength(30).WithMessage("Campo 'Nome do Perfil' deve possuir no máximo 30 caracteres.");
            
            RuleFor(f => f.TaskIds).NotNull().WithMessage("Seleção de 'Funcionalidades' está inválido.");
            RuleFor(f => f.TaskIds).NotEmpty().WithMessage("É necessário pelo menos 1 Funcionalidade associada.");
        }
    }
}
