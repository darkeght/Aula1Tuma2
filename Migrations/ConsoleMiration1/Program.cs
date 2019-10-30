using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleMiration1.Model;

namespace ConsoleMiration1
{
    class Program
    {
        static MigrationContext db = new MigrationContext();

        static void Main(string[] args)
        {
            //Iniciamos nossa base de dados
            db.Usuarios.ToList().ForEach(x => 
            Console.WriteLine(x.Nome));

            Console.ReadKey();
        }
    }
}
