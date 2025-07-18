namespace Prog2FinalEmpresaAlimentoBalanceado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.txbCUIT = new System.Windows.Forms.TextBox();
            this.bttAgregarSeleccionar = new System.Windows.Forms.Button();
            this.bttVerSaldo = new System.Windows.Forms.Button();
            this.bttRealizarPago = new System.Windows.Forms.Button();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.bttExportarClientes = new System.Windows.Forms.Button();
            this.bttExportarPEdidos = new System.Windows.Forms.Button();
            this.bttImportar = new System.Windows.Forms.Button();
            this.bttElegrirProducto = new System.Windows.Forms.Button();
            this.bttAgregarPedido = new System.Windows.Forms.Button();
            this.txbKG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbProductos
            // 
            this.lbProductos.Enabled = false;
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.Location = new System.Drawing.Point(240, 208);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(173, 160);
            this.lbProductos.TabIndex = 0;
            // 
            // cbProductos
            // 
            this.cbProductos.Enabled = false;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(66, 208);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(152, 21);
            this.cbProductos.TabIndex = 1;
            this.cbProductos.Text = "Productos a seleccionar";
            // 
            // txbCUIT
            // 
            this.txbCUIT.Location = new System.Drawing.Point(66, 53);
            this.txbCUIT.Name = "txbCUIT";
            this.txbCUIT.Size = new System.Drawing.Size(249, 20);
            this.txbCUIT.TabIndex = 2;
            this.txbCUIT.Text = "CUIT";
            // 
            // bttAgregarSeleccionar
            // 
            this.bttAgregarSeleccionar.Location = new System.Drawing.Point(66, 104);
            this.bttAgregarSeleccionar.Name = "bttAgregarSeleccionar";
            this.bttAgregarSeleccionar.Size = new System.Drawing.Size(89, 35);
            this.bttAgregarSeleccionar.TabIndex = 3;
            this.bttAgregarSeleccionar.Text = "Agregar / Seleccionar";
            this.bttAgregarSeleccionar.UseVisualStyleBackColor = true;
            this.bttAgregarSeleccionar.Click += new System.EventHandler(this.bttAgregarSeleccionar_Click);
            // 
            // bttVerSaldo
            // 
            this.bttVerSaldo.Enabled = false;
            this.bttVerSaldo.Location = new System.Drawing.Point(164, 104);
            this.bttVerSaldo.Name = "bttVerSaldo";
            this.bttVerSaldo.Size = new System.Drawing.Size(89, 35);
            this.bttVerSaldo.TabIndex = 4;
            this.bttVerSaldo.Text = "Ver Saldo";
            this.bttVerSaldo.UseVisualStyleBackColor = true;
            this.bttVerSaldo.Click += new System.EventHandler(this.bttVerSaldo_Click);
            // 
            // bttRealizarPago
            // 
            this.bttRealizarPago.Enabled = false;
            this.bttRealizarPago.Location = new System.Drawing.Point(288, 104);
            this.bttRealizarPago.Name = "bttRealizarPago";
            this.bttRealizarPago.Size = new System.Drawing.Size(100, 35);
            this.bttRealizarPago.TabIndex = 5;
            this.bttRealizarPago.Text = "Realizar Pago";
            this.bttRealizarPago.UseVisualStyleBackColor = true;
            this.bttRealizarPago.Click += new System.EventHandler(this.bttRealizarPago_Click);
            // 
            // txbMonto
            // 
            this.txbMonto.Enabled = false;
            this.txbMonto.Location = new System.Drawing.Point(288, 145);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(100, 20);
            this.txbMonto.TabIndex = 6;
            this.txbMonto.Text = "monto";
            // 
            // bttExportarClientes
            // 
            this.bttExportarClientes.Enabled = false;
            this.bttExportarClientes.Location = new System.Drawing.Point(627, 53);
            this.bttExportarClientes.Name = "bttExportarClientes";
            this.bttExportarClientes.Size = new System.Drawing.Size(125, 74);
            this.bttExportarClientes.TabIndex = 7;
            this.bttExportarClientes.Text = "Exportar Clientes";
            this.bttExportarClientes.UseVisualStyleBackColor = true;
            this.bttExportarClientes.Click += new System.EventHandler(this.bttExportarClientes_Click);
            // 
            // bttExportarPEdidos
            // 
            this.bttExportarPEdidos.Enabled = false;
            this.bttExportarPEdidos.Location = new System.Drawing.Point(627, 133);
            this.bttExportarPEdidos.Name = "bttExportarPEdidos";
            this.bttExportarPEdidos.Size = new System.Drawing.Size(125, 74);
            this.bttExportarPEdidos.TabIndex = 8;
            this.bttExportarPEdidos.Text = "Exportar Pedidos";
            this.bttExportarPEdidos.UseVisualStyleBackColor = true;
            // 
            // bttImportar
            // 
            this.bttImportar.Enabled = false;
            this.bttImportar.Location = new System.Drawing.Point(627, 220);
            this.bttImportar.Name = "bttImportar";
            this.bttImportar.Size = new System.Drawing.Size(125, 74);
            this.bttImportar.TabIndex = 9;
            this.bttImportar.Text = "Importar Productos";
            this.bttImportar.UseVisualStyleBackColor = true;
            // 
            // bttElegrirProducto
            // 
            this.bttElegrirProducto.Enabled = false;
            this.bttElegrirProducto.Location = new System.Drawing.Point(66, 280);
            this.bttElegrirProducto.Name = "bttElegrirProducto";
            this.bttElegrirProducto.Size = new System.Drawing.Size(152, 23);
            this.bttElegrirProducto.TabIndex = 10;
            this.bttElegrirProducto.Text = "Elegir Producto";
            this.bttElegrirProducto.UseVisualStyleBackColor = true;
            this.bttElegrirProducto.Click += new System.EventHandler(this.bttElegrirProducto_Click);
            // 
            // bttAgregarPedido
            // 
            this.bttAgregarPedido.Enabled = false;
            this.bttAgregarPedido.Location = new System.Drawing.Point(240, 374);
            this.bttAgregarPedido.Name = "bttAgregarPedido";
            this.bttAgregarPedido.Size = new System.Drawing.Size(173, 23);
            this.bttAgregarPedido.TabIndex = 11;
            this.bttAgregarPedido.Text = "Agregar Pedido";
            this.bttAgregarPedido.UseVisualStyleBackColor = true;
            this.bttAgregarPedido.Click += new System.EventHandler(this.bttAgregarPedido_Click);
            // 
            // txbKG
            // 
            this.txbKG.Enabled = false;
            this.txbKG.Location = new System.Drawing.Point(176, 254);
            this.txbKG.Name = "txbKG";
            this.txbKG.Size = new System.Drawing.Size(42, 20);
            this.txbKG.TabIndex = 12;
            this.txbKG.Text = "KG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbKG);
            this.Controls.Add(this.bttAgregarPedido);
            this.Controls.Add(this.bttElegrirProducto);
            this.Controls.Add(this.bttImportar);
            this.Controls.Add(this.bttExportarPEdidos);
            this.Controls.Add(this.bttExportarClientes);
            this.Controls.Add(this.txbMonto);
            this.Controls.Add(this.bttRealizarPago);
            this.Controls.Add(this.bttVerSaldo);
            this.Controls.Add(this.bttAgregarSeleccionar);
            this.Controls.Add(this.txbCUIT);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.lbProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.TextBox txbCUIT;
        private System.Windows.Forms.Button bttAgregarSeleccionar;
        private System.Windows.Forms.Button bttVerSaldo;
        private System.Windows.Forms.Button bttRealizarPago;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Button bttExportarClientes;
        private System.Windows.Forms.Button bttExportarPEdidos;
        private System.Windows.Forms.Button bttImportar;
        private System.Windows.Forms.Button bttElegrirProducto;
        private System.Windows.Forms.Button bttAgregarPedido;
        private System.Windows.Forms.TextBox txbKG;
    }
}

