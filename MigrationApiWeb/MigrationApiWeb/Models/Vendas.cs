using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MigrationApiWeb.Models
{
    public class Vendas
    {
        [Key]
        public int Id { get; set; }
        public string Produto { get; set; }
        public double Valor { get; set; }

        public int UsuarioId { get; set; }
    }
}