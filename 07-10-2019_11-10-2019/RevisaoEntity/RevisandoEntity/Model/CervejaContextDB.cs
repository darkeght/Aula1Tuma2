using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RevisandoEntity.Model
{
    //Deixamos nossa classe public
    public class CervejaContextDB :
        DbContext // Herdamos nossa classe DbContext que faz 
        //toda a parte do banco de dados
    {
        //Definimos nossa tabela dentro do banco de dados
        public DbSet<Cerveja> Cervejas { get; set; }
    }
}
