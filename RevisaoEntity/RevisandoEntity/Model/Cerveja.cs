using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisandoEntity.Model
{
    //Inicialmente devemos deixar a classe publica 
    public class Cerveja
    {
        //Chamada pelo (control + ".") ponto ou podemos usar using System.ComponentModel.DataAnnotations;
        [Key] // Chave primaria, auto incrementada
        public int Id { get; set; }
        //Aqui definimos a quantidade maxima de caracteres 
        [StringLength(50)]//para nosso campo "Nome" dentro do banco
        [Required]//Identifica que este campo e obrigatorio
        public string Nome { get; set; }
        [StringLength(30)]//Tamanho maximo de caracteres para o tipo 
        public string Tipo { get; set; }
        public double Teor { get; set; }

    }
}
