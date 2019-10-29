using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaPessoa.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }
    }
}