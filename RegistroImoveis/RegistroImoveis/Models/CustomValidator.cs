using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {
        RegistroContext db = new RegistroContext();

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(validationContext.DisplayName == "Nome")
            {
                if (db.Proprietarios
                    .FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Usuário já existe");

                if (value.ToString().Contains("Giomar"))
                    return new ValidationResult("Não é possivel registar esse nome em nossa base de dados porque ele é unico.");
            }

            return ValidationResult.Success;
        }
    }
}