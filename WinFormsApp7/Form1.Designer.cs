namespace WinFormsApp7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHuesped = new Label();
            txtHuesped = new TextBox();
            lblNoches = new Label();
            lblTarifa = new Label();
            chkTemporadaAlta = new CheckBox();
            btnImperativo = new Button();
            btnObjetos = new Button();
            gbCotizador = new GroupBox();
            nudTarifa = new NumericUpDown();
            nudNoches = new NumericUpDown();
            gbTotales = new GroupBox();
            lblTotal0 = new Label();
            lblITBIS0 = new Label();
            lblSERVICIOS0 = new Label();
            lblDescuento0 = new Label();
            lblSudtotal0 = new Label();
            lbltotal = new Label();
            lblITBIS = new Label();
            lblServicios = new Label();
            lblDescuento = new Label();
            lblsubtotal = new Label();
            btnFuncional = new Button();
            lstResultados = new ListView();
            resultados = new Label();
            btnLimpiar = new Button();
            gbCotizador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).BeginInit();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(8, 35);
            lblHuesped.Margin = new Padding(4, 0, 4, 0);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(114, 32);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            // 
            // txtHuesped
            // 
            txtHuesped.AccessibleRole = AccessibleRole.None;
            txtHuesped.Location = new Point(122, 27);
            txtHuesped.Margin = new Padding(4);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(325, 39);
            txtHuesped.TabIndex = 1;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(8, 101);
            lblNoches.Margin = new Padding(4, 0, 4, 0);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(99, 32);
            lblNoches.TabIndex = 2;
            lblNoches.Text = "Noches:";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Location = new Point(6, 188);
            lblTarifa.Margin = new Padding(4, 0, 4, 0);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(245, 32);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa por Noche (US):";
            // 
            // chkTemporadaAlta
            // 
            chkTemporadaAlta.AutoSize = true;
            chkTemporadaAlta.Location = new Point(8, 250);
            chkTemporadaAlta.Margin = new Padding(4);
            chkTemporadaAlta.Name = "chkTemporadaAlta";
            chkTemporadaAlta.Size = new Size(293, 36);
            chkTemporadaAlta.TabIndex = 6;
            chkTemporadaAlta.Text = "Temporada alta (+25%)";
            chkTemporadaAlta.UseVisualStyleBackColor = true;
            // 
            // btnImperativo
            // 
            btnImperativo.BackColor = Color.Cyan;
            btnImperativo.Location = new Point(460, 419);
            btnImperativo.Margin = new Padding(4);
            btnImperativo.Name = "btnImperativo";
            btnImperativo.Size = new Size(146, 44);
            btnImperativo.TabIndex = 7;
            btnImperativo.Text = "Imperativo";
            btnImperativo.UseVisualStyleBackColor = false;
            btnImperativo.Click += btnImperativo_Click;
            // 
            // btnObjetos
            // 
            btnObjetos.BackColor = Color.FromArgb(128, 128, 255);
            btnObjetos.Location = new Point(460, 497);
            btnObjetos.Margin = new Padding(4);
            btnObjetos.Name = "btnObjetos";
            btnObjetos.Size = new Size(146, 44);
            btnObjetos.TabIndex = 8;
            btnObjetos.Text = "Objetos";
            btnObjetos.UseVisualStyleBackColor = false;
            btnObjetos.Click += btnObjetos_Click;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(nudTarifa);
            gbCotizador.Controls.Add(nudNoches);
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(txtHuesped);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(chkTemporadaAlta);
            gbCotizador.Controls.Add(lblTarifa);
            gbCotizador.Location = new Point(16, 28);
            gbCotizador.Margin = new Padding(4);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Padding = new Padding(4);
            gbCotizador.Size = new Size(532, 349);
            gbCotizador.TabIndex = 9;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            // 
            // nudTarifa
            // 
            nudTarifa.DecimalPlaces = 2;
            nudTarifa.Location = new Point(258, 181);
            nudTarifa.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudTarifa.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTarifa.Name = "nudTarifa";
            nudTarifa.Size = new Size(189, 39);
            nudTarifa.TabIndex = 15;
            nudTarifa.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nudNoches
            // 
            nudNoches.Location = new Point(114, 94);
            nudNoches.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudNoches.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudNoches.Name = "nudNoches";
            nudNoches.Size = new Size(127, 39);
            nudNoches.TabIndex = 14;
            nudNoches.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lblTotal0);
            gbTotales.Controls.Add(lblITBIS0);
            gbTotales.Controls.Add(lblSERVICIOS0);
            gbTotales.Controls.Add(lblDescuento0);
            gbTotales.Controls.Add(lblSudtotal0);
            gbTotales.Controls.Add(lbltotal);
            gbTotales.Controls.Add(lblITBIS);
            gbTotales.Controls.Add(lblServicios);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblsubtotal);
            gbTotales.Location = new Point(23, 419);
            gbTotales.Margin = new Padding(4);
            gbTotales.Name = "gbTotales";
            gbTotales.Padding = new Padding(4);
            gbTotales.Size = new Size(390, 262);
            gbTotales.TabIndex = 10;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lblTotal0
            // 
            lblTotal0.AutoSize = true;
            lblTotal0.Location = new Point(161, 169);
            lblTotal0.Margin = new Padding(4, 0, 4, 0);
            lblTotal0.Name = "lblTotal0";
            lblTotal0.Size = new Size(27, 32);
            lblTotal0.TabIndex = 9;
            lblTotal0.Text = "0";
            // 
            // lblITBIS0
            // 
            lblITBIS0.AutoSize = true;
            lblITBIS0.Location = new Point(161, 110);
            lblITBIS0.Margin = new Padding(4, 0, 4, 0);
            lblITBIS0.Name = "lblITBIS0";
            lblITBIS0.Size = new Size(27, 32);
            lblITBIS0.TabIndex = 8;
            lblITBIS0.Text = "0";
            // 
            // lblSERVICIOS0
            // 
            lblSERVICIOS0.AutoSize = true;
            lblSERVICIOS0.Location = new Point(161, 137);
            lblSERVICIOS0.Margin = new Padding(4, 0, 4, 0);
            lblSERVICIOS0.Name = "lblSERVICIOS0";
            lblSERVICIOS0.Size = new Size(27, 32);
            lblSERVICIOS0.TabIndex = 7;
            lblSERVICIOS0.Text = "0";
            // 
            // lblDescuento0
            // 
            lblDescuento0.AutoSize = true;
            lblDescuento0.Location = new Point(161, 78);
            lblDescuento0.Margin = new Padding(4, 0, 4, 0);
            lblDescuento0.Name = "lblDescuento0";
            lblDescuento0.Size = new Size(27, 32);
            lblDescuento0.TabIndex = 6;
            lblDescuento0.Text = "0";
            // 
            // lblSudtotal0
            // 
            lblSudtotal0.AutoSize = true;
            lblSudtotal0.Location = new Point(161, 46);
            lblSudtotal0.Margin = new Padding(4, 0, 4, 0);
            lblSudtotal0.Name = "lblSudtotal0";
            lblSudtotal0.Size = new Size(27, 32);
            lblSudtotal0.TabIndex = 5;
            lblSudtotal0.Text = "0";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(31, 169);
            lbltotal.Margin = new Padding(4, 0, 4, 0);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(65, 32);
            lbltotal.TabIndex = 4;
            lbltotal.Text = "Total";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(29, 110);
            lblITBIS.Margin = new Padding(4, 0, 4, 0);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(66, 32);
            lblITBIS.TabIndex = 3;
            lblITBIS.Text = "ITBIS";
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(29, 137);
            lblServicios.Margin = new Padding(4, 0, 4, 0);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(107, 32);
            lblServicios.TabIndex = 2;
            lblServicios.Text = "Servicios";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(29, 78);
            lblDescuento.Margin = new Padding(4, 0, 4, 0);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(128, 32);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento";
            // 
            // lblsubtotal
            // 
            lblsubtotal.AutoSize = true;
            lblsubtotal.Location = new Point(29, 46);
            lblsubtotal.Margin = new Padding(4, 0, 4, 0);
            lblsubtotal.Name = "lblsubtotal";
            lblsubtotal.Size = new Size(103, 32);
            lblsubtotal.TabIndex = 0;
            lblsubtotal.Text = "Subtotal";
            // 
            // btnFuncional
            // 
            btnFuncional.BackColor = Color.Lime;
            btnFuncional.Location = new Point(460, 565);
            btnFuncional.Margin = new Padding(4);
            btnFuncional.Name = "btnFuncional";
            btnFuncional.Size = new Size(146, 44);
            btnFuncional.TabIndex = 11;
            btnFuncional.Text = "Funcional";
            btnFuncional.UseVisualStyleBackColor = false;
            btnFuncional.Click += btnFuncional_Click;
            // 
            // lstResultados
            // 
            lstResultados.Location = new Point(639, 103);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(501, 551);
            lstResultados.TabIndex = 12;
            lstResultados.UseCompatibleStateImageBehavior = false;
            // 
            // resultados
            // 
            resultados.AutoSize = true;
            resultados.Location = new Point(639, 55);
            resultados.Name = "resultados";
            resultados.Size = new Size(133, 32);
            resultados.TabIndex = 13;
            resultados.Text = "Resultados:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(460, 635);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 696);
            Controls.Add(btnLimpiar);
            Controls.Add(resultados);
            Controls.Add(lstResultados);
            Controls.Add(btnFuncional);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Controls.Add(btnObjetos);
            Controls.Add(btnImperativo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa coral - Enmanuel Chalas 2024-2062";
            Load += Form1_Load;
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTarifa).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNoches).EndInit();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHuesped;
        private TextBox txtHuesped;
        private Label lblNoches;
        private Label lblTarifa;
        private CheckBox chkTemporadaAlta;
        private Button btnImperativo;
        private Button btnObjetos;
        private GroupBox gbCotizador;
        private GroupBox gbTotales;
        private Label lblsubtotal;
        private Label lblTotal0;
        private Label lblITBIS0;
        private Label lblSERVICIOS0;
        private Label lblDescuento0;
        private Label lblSudtotal0;
        private Label lbltotal;
        private Label lblITBIS;
        private Label lblServicios;
        private Label lblDescuento;
        private Button btnFuncional;
        private ListView lstResultados;
        private Label resultados;
        private NumericUpDown nudNoches;
        private NumericUpDown nudTarifa;
        private Button btnLimpiar;
    }
}
