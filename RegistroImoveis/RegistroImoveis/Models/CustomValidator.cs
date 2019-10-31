using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroImoveis.Models
{
    public class CustomValidator : ValidationAttribute
    {

        private string FildName { get; set; }

        public CustomValidator(string field)
        {
            FildName = field;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (FildName == "Nome")
            {
                RegistroContext db = new RegistroContext();

                if (db.Proprietarios.FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Usúario já cadastrado");
            }

            if(FildName == "Giomar")
                return new ValidationResult("Segue o lider");

            return ValidationResult.Success;
        }
    }
}