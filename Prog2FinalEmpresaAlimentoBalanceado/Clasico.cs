using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalEmpresaAlimentoBalanceado
{
    [Serializable]
    internal class Clasico : Producto
    {

        public Clasico(double precioA, double precioB, string descripcion) 
        { 
            this.precioBaseB = precioB;
            this.precioBaseA = precioA;
            this.descripcion=descripcion;
        }    

        public override string Descripcion()
        {
            return descripcion + " " + precioBaseA + " " + precioBaseB;
        }

        public override double Precio()
        {
            return 50 + (precioBaseA * 1.4);
        }
    }
}
