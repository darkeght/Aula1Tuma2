using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CorreiosWebApi.Models
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cep { get; set; }

        public string Uf { get; set; }

        public string Municipio { get; set; }

        public string Complemento { get; set; }
    }
}