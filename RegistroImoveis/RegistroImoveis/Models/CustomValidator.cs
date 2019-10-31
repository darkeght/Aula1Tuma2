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
        //"object value" e toda a informação colocada em nossa propriedade 
        //la no nosso postman a informação que colocamos para salvar 
        //no nosso banco
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            /*if(validationContext.DisplayName == "Nome")
            {
                if (db.Proprietarios
                    .FirstOrDefault(x => x.Nome == value.ToString()) != null)
                    return new ValidationResult("Usuário já existe");

                if (value.ToString().Contains("Giomar"))
                    return new ValidationResult("Não é possivel registar esse nome em nossa base de dados porque ele é unico.");
            }*/

            //Realizamos a comparação do atributo que estamos realizando as validações
            if(validationContext.DisplayName == "DataNascimento")
            {
                //conversão da data que foi informada em nossa propriedade
                var dataInformada = DateTime.Parse(value.ToString());
                //calculamos a idade que foi gerada
                var idade = DateTime.Now.Year - dataInformada.Year;

                if (idade < 18)//Retornamos para menor de 18 anos
                    return new ValidationResult("É preciso ser maior ou igual a 18 anos!.");

                if (idade > 150)//Retornamos  para maior de 150
                    return new ValidationResult("Idade apresentada e superior ao maximo permitido");
            }

            return ValidationResult.Success;
        }
    }
}