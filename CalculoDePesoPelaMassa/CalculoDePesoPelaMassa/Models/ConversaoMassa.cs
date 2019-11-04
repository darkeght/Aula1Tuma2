using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculoDePesoPelaMassa.Models
{
    public class ConversaoMassa
    {
        public double Densidade { get; set; }

        public double Volume { get;set; }

        public double Gravidade { get; set; } = 9.8;

        public double Peso { get { return Densidade * Volume * Gravidade; } }
    }
}
