using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalEmpresaAlimentoBalanceado
{
    [Serializable]
    internal class Pedido
    {
        public double Valor { get; set; }

        public int Nro { get; set; }
        public DateTime fechahora { get; set; }
        public string detalle { get; set; }
        List<Producto> productos;
        public Pedido(int nro, List<Producto> list)
        {
            foreach (Producto item in list)
            {
                Valor += item.Precio();
            }
            productos = list;
            Nro = nro;
            fechahora = DateTime.Now;

        }

        public string[] VerResumen()
        {
            List<string> pedidoString = new List<string>();
            foreach (Producto item in productos)
            {
                pedidoString.Add(item.ToString());
            }

            return pedidoString.ToArray();
        }

        public override string ToString()
        {
            return detalle + " " + Nro + " " + fechahora.ToString() + " " + Valor;
        }
    }
}
