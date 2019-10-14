using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Deixamos a classe publica
    public class Celular : ControleUsuario
    {
        [Key]//Chave primaria
        public int Id { get; set; }
        [MaxLength(30)]//Definição de tamanho maximo do campo
        [Required] //Definindo campo obrigatorio
        public string Marca { get; set; }
        [MaxLength(30)]//Definição de tamanho maximo do campo
        [Required]//Deifinindo campo obrigatorio
        public string Modelo { get; set; }
        [Required]//Deifinindo campo obrigatorio
        public double Preco { get; set; }
    }
}
