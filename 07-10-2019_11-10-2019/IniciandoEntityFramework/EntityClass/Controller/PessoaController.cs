using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;

namespace EntityClass.Controller
{

    public class PessoaController
    {
        // Realizo minha conexão com o banco de dados
        EntityContextDB contextDB = new EntityContextDB();


        public 
            IQueryable // Aqui temos nossa primeira Interface com a classe
                       // IQueryable essa classe contem varioas funcionalidades
                       // prontas para usar igual ao banco de dados como os selects
            <Pessoa> //Definimos o tipo que ira retornar 
            GetPessoas() // Damos um nome ao nosso metodo
        {
            return contextDB.ListaDePessoas;//retornamos nossa lista de pessoas
        }

        /// <summary>
        /// Metodo para adicionar Pessoa no banco de dados
        /// </summary>
        /// <param name="item">Item Pessoa</param>
        public void AddPessoa(Pessoa item)
        {
            contextDB //Nosso banco de dados 
                .ListaDePessoas //nossa tabela Pessoa
                .Add(item); //Adicionamos o item

            contextDB.SaveChanges(); //Salvamos no banco
        }
    }
}
