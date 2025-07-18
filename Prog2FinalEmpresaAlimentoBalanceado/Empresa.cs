using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalEmpresaAlimentoBalanceado
{
    [Serializable]
    internal class Empresa
    {
        long cuit;
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }

        public Empresa(long cuit, string razonSocial, string direccion)
        {
            this.cuit = cuit;
            RazonSocial = razonSocial;
            Direccion = direccion;
        }

        public override string ToString()
        {
            return cuit + " " + RazonSocial + " " + Direccion;
        }
    }
}
