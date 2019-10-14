using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTeste.Model;

namespace CodeFirstTeste.Controller
{
    public class CervejaController
    {
        CervejaContextDb contextDb = 
            //Aqui passamos a nossa conexão com o banco de dados para  o contrutor 
            //com isso selamos a informação do banco de dados somente pelo 
            //controller e não passamos a informação para a aplicação visual
            new CervejaContextDb(@"data source=(localdb)\MSSQLLocalDB;initial catalog=RevisandoEntity.Model.CervejaContextDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        /// <summary>
        /// Adicionamos aqui a cerveja dentro de nossa base de dados
        /// </summary>
        /// <param name="item"></param>
        public void AddCerveja(Cerveja item)
        {
            //adicionamos em nossa lista de memoria a cerveja
            contextDb.Cervejas.Add(item);
            //aqui adicionamos ao banco de dados a nossa cerveja
            contextDb.SaveChanges();
        }
    }
}
