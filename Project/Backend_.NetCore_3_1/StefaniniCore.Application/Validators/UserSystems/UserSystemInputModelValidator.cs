﻿using FluentValidation;
using StefaniniCore.Application.InputModels.UserSystemInputModel;

namespace StefaniniCore.Application.Validators
{
    public class UserSystemInputModelValidator : AbstractValidator<UserSystemInputModel>
    {
        public UserSystemInputModelValidator()
        {
            RuleFor(f => f).NotNull().WithMessage("Erro no envio dos dados.");

            RuleFor(f => f.UserName).NotNull().NotEmpty().WithMessage("Campo 'Nome de Usuário' não foi preenchido.");
            RuleFor(f => f.UserName).MinimumLength(3).WithMessage("Campo 'Nome de Usuário' deve possuir no mínimo 3 caracteres.");
            RuleFor(f => f.UserName).MaximumLength(30).WithMessage("Campo 'Nome de Usuário' deve possuir no máximo 30 caracteres.");

            RuleFor(f => f.Password).NotNull().NotEmpty().WithMessage("Campo 'Senha' não foi preenchido.");
            RuleFor(f => f.Password).MinimumLength(3).WithMessage("Campo 'Senha' deve possuir no mínimo 3 caracteres.");
            RuleFor(f => f.Password).MaximumLength(30).WithMessage("Campo 'Senha' deve possuir no máximo 30 caracteres.");

            RuleFor(f => f.ProfileTypeId).Must(f=> f > 0).WithMessage("Seleção de 'Perfil' está inválido.");
        }
    }
}
