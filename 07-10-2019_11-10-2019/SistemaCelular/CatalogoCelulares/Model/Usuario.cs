using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoCelulares.Model
{
    //Deixar publica
    public class Usuario : ControleUsuario
    {
        [Key] //Definindo como primary key e identity(1,1)
        public int Id { get; set; }
        [MaxLength(50)] //delimitamos um tamanho maximo para o campo string
        public string Nome { get; set; }
        [MaxLength(30)] //delimitamos tamanho do campo
        [Required] //Definimos que este campo é obrigatorio
        public string Login { get; set; }
        [MaxLength(30)]//delimitamos tamanho do campo
        [Required] //Definimos que este campo é obrigatorio
        public string Senha { get; set; }
    }
}
