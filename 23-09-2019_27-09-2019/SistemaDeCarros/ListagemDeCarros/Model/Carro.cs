using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    public class Carro
    {
	   public int Id { get; set; }
       public string  Marca        {get;set;}
       public string  Modelo       {get;set;}
       public int Ano          {get;set;}
       public int Cilindradas  {get;set;}
	   public int Portas       {get;set;}
    }
}
