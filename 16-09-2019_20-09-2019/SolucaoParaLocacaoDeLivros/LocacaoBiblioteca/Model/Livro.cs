using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    /// <summary>
    /// Nossa Class que contem as informações que nossos livros vão apresentar
    /// </summary>
    public class Livro : ControleUsuario
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Nome { get; set; }
    }
}
