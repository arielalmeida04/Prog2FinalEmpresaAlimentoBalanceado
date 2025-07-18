namespace Prog2FinalEmpresaAlimentoBalanceado
{
    partial class AgregarClientemv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCuit = new System.Windows.Forms.TextBox();
            this.txbTope = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(11, 12);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(178, 20);
            this.txbNombre.TabIndex = 0;
            this.txbNombre.Text = "nombre";
            // 
            // txbCuit
            // 
            this.txbCuit.Location = new System.Drawing.Point(11, 38);
            this.txbCuit.Name = "txbCuit";
            this.txbCuit.Size = new System.Drawing.Size(178, 20);
            this.txbCuit.TabIndex = 1;
            this.txbCuit.Text = "cuit";
            // 
            // txbTope
            // 
            this.txbTope.Location = new System.Drawing.Point(11, 64);
            this.txbTope.Name = "txbTope";
            this.txbTope.Size = new System.Drawing.Size(178, 20);
            this.txbTope.TabIndex = 2;
            this.txbTope.Text = "tope";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(11, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(114, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AgregarClientemv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 125);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbTope);
            this.Controls.Add(this.txbCuit);
            this.Controls.Add(this.txbNombre);
            this.Name = "AgregarClientemv";
            this.Text = "AgregarClientemv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txbNombre;
        public System.Windows.Forms.TextBox txbCuit;
        public System.Windows.Forms.TextBox txbTope;
    }
}