using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalEmpresaAlimentoBalanceado
{
    [Serializable]
    internal abstract class Producto
    {
        protected string descripcion;
        protected double precioBaseA;
        protected double precioBaseB;
        public double CantidadKilos {  get; set; }

        public abstract double Precio();
        public abstract string Descripcion();

        public override string ToString()
        {
            return descripcion+";"+precioBaseA+";"+precioBaseB;
        }
    }
}
