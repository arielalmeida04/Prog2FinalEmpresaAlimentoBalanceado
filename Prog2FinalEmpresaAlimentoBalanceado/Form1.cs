using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2FinalEmpresaAlimentoBalanceado
{
    public partial class Form1 : Form
    {
        GestionVentas gv = new GestionVentas(123, "Empresario", "Urquiza");
        Premiun p1 = new Premiun("Best Dog", 500, 800);
        Premiun p2 = new Premiun("Best Cat", 250, 400);
        Producto c1 = new Clasico(300, 450, "Gatitos");
        Producto c2 = new Clasico(150, 225, "Perritos");
        ClienteCuenta client1 = new ClienteCuenta("Josi", 444, 15000);
        ClienteCuenta client2 = new ClienteCuenta("Ariel", 777, 30000);
        ClienteCuenta client3 = new ClienteCuenta("Tuki", 999, 70000);
        ClienteCuenta seleccionado;

        List<Producto> listaProductosSeleccionados = new List<Producto>();
        List<Pedido> listaPedidos;
        int nroOrden = 0;

        public Form1()
        {
            InitializeComponent();
            cbProductos.Items.Add(p1);
            cbProductos.Items.Add(p2);
            cbProductos.Items.Add(c1);
            cbProductos.Items.Add(c2);

            gv.AgreagarCliente(client1);
            gv.AgreagarCliente(client2);
            gv.AgreagarCliente(client3);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("archivos.dat", FileMode.OpenOrCreate, FileAccess.Read);
                bf = new BinaryFormatter();

                gv = bf.Deserialize(fs) as GestionVentas;
            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void bttAgregarSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                long cuit = Convert.ToInt64(txbCUIT.Text);
                ClienteCuenta nuevo = gv.Buscar(cuit);
                if (nuevo != null)
                {
                    seleccionado = nuevo;

                    txbMonto.Enabled = true;
                    lbProductos.Enabled = true;
                    cbProductos.Enabled = true;
                    bttRealizarPago.Enabled = true;
                    bttVerSaldo.Enabled = true;
                    bttExportarClientes.Enabled = true;
                    bttExportarPEdidos.Enabled = true;
                    bttImportar.Enabled = true;
                    txbKG.Enabled = true;
                    bttAgregarPedido.Enabled = true;
                    bttAgregarSeleccionar.Enabled = true;
                    bttElegrirProducto.Enabled = true;
                }
                else
                {
                    AgregarClientemv ag = new AgregarClientemv();
                    if (ag.ShowDialog() == DialogResult.OK)
                    {
                        string nombre = ag.txbNombre.Text;
                        long cuit2 = Convert.ToInt64(ag.txbCuit.Text);
                        double tope = Convert.ToDouble(ag.txbTope.Text);
                        ClienteCuenta nuevisimo = new ClienteCuenta(nombre, cuit2, tope);
                        gv.AgreagarCliente(nuevisimo);

                        lbProductos.Enabled = true;
                        cbProductos.Enabled = true;
                        bttRealizarPago.Enabled = true;
                        bttVerSaldo.Enabled = true;
                        txbMonto.Enabled = true;
                        bttImportar.Enabled = true;
                        txbKG.Enabled = true;
                        bttAgregarPedido.Enabled = true;
                        bttAgregarSeleccionar.Enabled = true;
                        bttElegrirProducto.Enabled = true;

                        cbProductos.Items.Add(nuevisimo);

                    }
                }

            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
        }

        private void bttVerSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                long cuit = Convert.ToInt64(txbCUIT.Text);
                MessageBox.Show("El saldo es: " + gv.VerSaldo(cuit));
            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
        }

        private void bttRealizarPago_Click(object sender, EventArgs e)
        {
            try
            {
                long cuit = Convert.ToInt64(txbCUIT.Text);
                double monto = Convert.ToDouble(txbMonto.Text);
                bool result;
                result = gv.AgregarPago(cuit, monto);
                if (result == true)
                {
                    MessageBox.Show("Se realizo el pago con exito");

                }
                else
                {
                    MessageBox.Show("No se realizo el pago con exito");
                }
            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = null;
            try
            {
                fs = new FileStream("archivos.dat", FileMode.Create, FileAccess.Write);
                bf = new BinaryFormatter();

                bf.Serialize(fs, gv);
            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }

            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void bttElegrirProducto_Click(object sender, EventArgs e)
        {

            try
            {
                double kg = Convert.ToDouble(txbKG.Text);

                Producto producto = cbProductos.SelectedItem as Producto;
                producto.CantidadKilos = kg;
                lbProductos.Items.Add(producto);
            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }
        }

        private void bttAgregarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Producto item in lbProductos.SelectedItems)
                {
                    listaProductosSeleccionados.Add(item);
                }
                nroOrden++;
                Pedido p = gv.GenerarPedido(nroOrden, listaProductosSeleccionados);
                bool pedido = gv.SumarPedido(seleccionado, p);
                if (pedido == true)
                {

                    MessageBox.Show(p.ToString());
                }
                else
                {
                    MessageBox.Show("No se logro el pedido");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bttExportarClientes_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.CreateNew, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    List<ClienteCuenta> lista = gv.ObtenerClientes();
                    foreach (ClienteCuenta item in lista)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

            }
            catch (Exception ez)
            {

                MessageBox.Show(ez.Message);
            }

            finally
            {
                if (fs != null)
                {
                    if (sw != null)
                    {
                        sw.Close();
                        fs.Close();
                    }
                }

            }
        }

        private void bttImportar_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();

                        cbProductos.Items.Add(linea);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                if (fs != null)
                {
                    if (sr != null)
                    {
                        sr.Close();
                        fs.Close();
                    }
                }
            }
        }

        private void bttExportarPEdidos_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sr = null;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    sr = new StreamWriter(fs);
                    listaPedidos = gv.ObtenerPedidos();
                    foreach (var item in listaPedidos)
                    {
                        sr.WriteLine(item);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (fs != null)
                {
                    if (sr != null)
                    {
                        sr.Close();
                        fs.Close();
                    }
                }
            }
        }
    }
}
