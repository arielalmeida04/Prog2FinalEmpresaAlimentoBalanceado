using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalEmpresaAlimentoBalanceado
{
    [Serializable]
    internal class Premiun : Producto
    {

        public Premiun(string descripcion, double precioA,double precioB) 
        { 
            this.descripcion = descripcion;
            this.precioBaseA = precioA;
            this.precioBaseB = precioB;
        }
        public override string Descripcion()
        {
            return descripcion + " " + precioBaseA + " " + precioBaseB;
        }

        public override double Precio()
        {
            return 70 + (precioBaseA * 0.85 + precioBaseB * 0.15) * 1.8;
        }
    }
}
