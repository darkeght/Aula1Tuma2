using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroImoveis.Models
{
    public class Proprietario
    {
        [Key]
        public int Id { get; set; }

        [CustomValidator]
        public string Nome { get; set; } = string.Empty;

        [CustomValidator]
        public DateTime DataNascimento { get; set; } = DateTime.MinValue;

        public string Email { get; set; } = string.Empty;

    }
}