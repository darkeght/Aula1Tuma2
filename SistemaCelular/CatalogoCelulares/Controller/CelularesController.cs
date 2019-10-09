using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoCelulares.Model;

namespace CatalogoCelulares.Controller
{
    //1 - Usar nossa pasta model 'using CatalogoCelulares.Model;'
    //2 - Criar uma instancia nova da nossa Context
    
    //Primeiro dixamos nossa classe publica
    public class CelularesController
    {   //Iniciamos nossa instancia com a base de dados dentro da 
        //controller
        CelularesContextDB contextDB = new CelularesContextDB();
        //Listagem
        /// <summary>
        /// Metodo que retorna nossa lista de celulares ativos apenas
        /// </summary>
        /// <returns>QueryList de celulares filtrado por ativo</returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB //Nosso acesso ao banco de dados
                .Celulares //Mossa tabela do banco de dados
                .Where //Indicamos que vamos realizar um filtro
                (x => x.Ativo == true); //As condições do filtro
        }
        //Atualização
        /// <summary>
        /// Metodo que atualiza um registro valido do nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>Retorna verdadeiro caso item exista</returns>
        public bool AtualizarCelular(Celular item)
        {
            var celular = //Definimos uma variavel para o celular
                 contextDB //Usamos o banco de dados
                .Celulares //Nossa Tabela que tem os celulares
                .FirstOrDefault //Buscamo em nossa tabela o celular
                (x => x.Id == item.Id); //Regra para realizar a busca

            //Falamos que nosso celular da tabela vai ser igual
            //Nosso celular que estamos passando 
            if (celular == null)//Verificamos ele realmente encontrou um celular
                return false;//Caso não tenha encontrado retornamos falso
            else
            {
                celular = item; //Encontrou ele atualiza a informação
                celular.DataAlteracao = DateTime.Now;//atualizamos 
                //a data da alteração do nosso celular
            }

            contextDB.SaveChanges();//Salvamos a informação no banco

            return true;//retornamos que foi atualizado 
        }
        //Inserção
        /// <summary>
        /// Metodo que  valida e insere os registros dentro do sistema
        /// </summary>
        /// <param name="item">Nosso novo celular</param>
        /// <returns>Retorna verdadeiro para um item valido</returns>
        public bool InserirCelular(Celular item)
        {
            if (string  //Nosso tipo que contem varios metodos prontos para string
                .IsNullOrWhiteSpace //Metodo que identifica espaços em branco 
                                    //apenas ou Valor null
                (item.Marca)) //Nosso campo que vamos validar 
                return false;

            if (string
                .IsNullOrWhiteSpace
                (item.Modelo))
                return false;

            if (item.Preco <= 0)//Verificamos se o valor informado
                //é maior que 0 
                return false; //Caso não ele ja retorna para fora do metodo

            //Salvamos nosso item dentro de nossa tabela em memoria
            contextDB.Celulares.Add(item);
            //Salvamos agora no banco esta informação
            contextDB.SaveChanges();
            //Retornamos verdadeiro para indicar sucesso na insersão do registro
            return true;
        }
        //'Remoção'
        /// <summary>
        /// Metodo utilizado para apenas desativar o item dentro de nosso sistema
        /// </summary>
        /// <param name="id">Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular = //Nossa variavel
                contextDB //Nossa base de dados
                .Celulares //Tabela de celular
                .FirstOrDefault //Buscamos o item para desativar
                (x => x.Id == id);//Informamos a regra de busca por Id

            if (celular == null)//Verificamos se este item existe 
                return false;//Caso não ele sai de nosso metodo

            celular.Ativo = false; //Desativamos o item

            contextDB.SaveChanges();//Salvamos em nosso banco

            return true;//Retornamos verdadeiro
        }
    }
}
