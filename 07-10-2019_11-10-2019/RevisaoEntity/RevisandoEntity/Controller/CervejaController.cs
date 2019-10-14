using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisandoEntity.Model;

namespace RevisandoEntity.Controller
{
    //Primeiro passo deixar ela publica
    public class CervejaController
    {
        //Iniciamos nossa base de dados na controller
        CervejaContextDB contextDB = new CervejaContextDB();
        public void AddCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDB.Cervejas.Add(item);
                contextDB.SaveChanges();
            }
        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDB
                .Cervejas
                .Where(x => x.Nome.Contains("Cerveja"));
        }
    }
}
