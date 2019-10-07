using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB :
        DbContext // DbContext classe pronta que contem todo os processo
        // de conexão com o banco de dados listagem das tabelas 
        // seleção das informações
    {
        public DbSet//Palavra reservada para o Entity que indica 
            //que vamos definir uma tabela do nosso banco de dados
            <Pessoa>//Aqui definimos nossa tabela pessoa
            //ou seja especificamos qual de nossas classe será 
            // uma referencia de uma tabela no banco de dados
            // ela vai ao banco com o nome que definimos em nossa classe
            ListaDePessoas { get; set; } // nesta parte liberamos nossa tabela 
        //para acessar

    }
}
