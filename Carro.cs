using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Carro : ICloneable
    {
        public string Marca { get; set; }
        public int Año { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
