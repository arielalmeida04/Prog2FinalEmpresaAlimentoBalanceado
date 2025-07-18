using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2FinalEmpresaAlimentoBalanceado
{
    [Serializable]
    internal class ClienteCuenta: IComparable<ClienteCuenta>
    {
        Queue<Pedido> listaPedidos = new Queue<Pedido>();
        public string Nombre { get; set; }
        public long Cuit { get; set; }
        public double SaldoCuenta {get; set;}

        public double Tope { get; set; }


        public ClienteCuenta(string nombre, long cuit, double topeCuenta)
        {
            Nombre= nombre;
            Cuit= cuit;
            Tope= topeCuenta;
        }
        public bool AgregarPedido(Pedido unPedido)
        {
            bool paga=false;    
            if (SaldoCuenta<Tope)
            {
                if (unPedido != null) listaPedidos.Enqueue(unPedido);
                SaldoCuenta+= unPedido.Valor;
                return paga=true;
            }
            else
            {
                return paga;
            }
            
        }
        public Pedido RetirarPedidoQueue()
        {
            return listaPedidos.Dequeue();
        }    
        public bool AgregarPago(double monto)
        {
            bool sepaga= false;
            if (SaldoCuenta>monto)
            {
              
                SaldoCuenta -= monto;
              sepaga = true;
            }
            
            return sepaga;
        }

        public int CompareTo(ClienteCuenta other)
        {
            return this.Cuit.CompareTo(other.Cuit); 
        }

        public override string ToString()
        {
            return Nombre+";"+Cuit+";"+Tope;
        }
    }
}
