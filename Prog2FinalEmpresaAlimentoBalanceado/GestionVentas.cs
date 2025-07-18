using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2FinalEmpresaAlimentoBalanceado
{
    [Serializable]
    internal class GestionVentas
    {
        Empresa dueño;
        double montoFactura=0;
        readonly DateTime inicioOperacion;
        List<ClienteCuenta> listacliente = new List<ClienteCuenta>();
        List<Producto> listaProductos = new List<Producto>();
        List<Pedido> listaPedido = new List<Pedido>();
        public GestionVentas(long cuit, string razonsocial, string direccion)
        {
            dueño = new Empresa(cuit, razonsocial, direccion);
            inicioOperacion = DateTime.Now;
        }
        public double AgreagarCliente(ClienteCuenta unCliente)
        {
            if (unCliente != null) listacliente.Add(unCliente);
            return unCliente.SaldoCuenta;
        }
        public ClienteCuenta Buscar(long cuit)
        {
            listacliente.Sort();
            ClienteCuenta c = new ClienteCuenta("", cuit, 0);
            int indice = listacliente.BinarySearch(c);
            if (indice >= 0)
            {
                ClienteCuenta encontrado = listacliente[indice];
                return encontrado;
            }
            return null;
        }
        public Pedido GenerarPedido(int nro, List<Producto> lista)
        {
            Pedido p = new Pedido(nro, lista);

            listaPedido.Add(p);
            return p;

        }
        public bool SumarPedido(ClienteCuenta unCliente, Pedido unPedido)
        {
            bool resultado = false;
            ClienteCuenta buscar = Buscar(unCliente.Cuit);
            if (buscar != null)
            {
                buscar.AgregarPedido(unPedido);
                resultado = true;
            }

            return resultado;
        }

        public bool AgregarPago(long cuit, double monto)
        {
            bool pagado;
            montoFactura += monto;
            ClienteCuenta cuenta = Buscar(cuit);
            pagado = cuenta.AgregarPago(monto);
            return pagado;
        }
        public double VerSaldo(long cuit)
        {
            ClienteCuenta buscado = Buscar(cuit);
            return buscado.SaldoCuenta;
        }
        public List<Pedido> ObtenerPedidos()
        {
            return listaPedido;
        }
        public List<ClienteCuenta> ObtenerClientes()
        {
            return listacliente;
        }
    }
}
