using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Controller;

namespace ListarCarrosDoAmigo
{
    class Program
    {
        static CarroController carroController = new CarroController();
        static void Main(string[] args)
        {
            carroController.GetCarros().ForEach(
                x => Console.WriteLine($"{x.Id} {x.Marca} {x.Modelo} {x.Portas}"));

            Console.ReadKey();
        }
    }
}
