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
            txthuesped = new TextBox();
            lblNoches = new Label();
            textBox1 = new TextBox();
            lbltarifa = new Label();
            txt = new TextBox();
            chebox = new CheckBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            gbCotizador = new GroupBox();
            gbTotales = new GroupBox();
            lblsudtotal = new Label();
            lblDescuento = new Label();
            lblServicios = new Label();
            lblITBIS = new Label();
            lbltotal = new Label();
            lblTotal0 = new Label();
            lblITBIS0 = new Label();
            lblSERVICIOS0 = new Label();
            lblDescuento0 = new Label();
            lblsudtotal0 = new Label();
            gbCotizador.SuspendLayout();
            gbTotales.SuspendLayout();
            SuspendLayout();
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(6, 27);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(87, 25);
            lblHuesped.TabIndex = 0;
            lblHuesped.Text = "Huesped:";
            // 
            // txthuesped
            // 
            txthuesped.Location = new Point(94, 21);
            txthuesped.Name = "txthuesped";
            txthuesped.Size = new Size(251, 31);
            txthuesped.TabIndex = 1;
            // 
            // lblNoches
            // 
            lblNoches.AutoSize = true;
            lblNoches.Location = new Point(0, 79);
            lblNoches.Name = "lblNoches";
            lblNoches.Size = new Size(75, 25);
            lblNoches.TabIndex = 2;
            lblNoches.Text = "Noches:";
            lblNoches.Click += lblNoches_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(265, 31);
            textBox1.TabIndex = 3;
            // 
            // lbltarifa
            // 
            lbltarifa.AutoSize = true;
            lbltarifa.Location = new Point(5, 147);
            lbltarifa.Name = "lbltarifa";
            lbltarifa.Size = new Size(183, 25);
            lbltarifa.TabIndex = 4;
            lbltarifa.Text = "Tarifa por Noche (US):";
            // 
            // txt
            // 
            txt.Location = new Point(195, 141);
            txt.Name = "txt";
            txt.Size = new Size(187, 31);
            txt.TabIndex = 5;
            // 
            // chebox
            // 
            chebox.AutoSize = true;
            chebox.Location = new Point(6, 195);
            chebox.Name = "chebox";
            chebox.Size = new Size(222, 29);
            chebox.TabIndex = 6;
            chebox.Text = "Temporada alta (+25%)";
            chebox.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Cyan;
            btnCalcular.Location = new Point(354, 369);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            btnLimpiar.Location = new Point(354, 434);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // gbCotizador
            // 
            gbCotizador.Controls.Add(lblHuesped);
            gbCotizador.Controls.Add(txthuesped);
            gbCotizador.Controls.Add(lblNoches);
            gbCotizador.Controls.Add(textBox1);
            gbCotizador.Controls.Add(chebox);
            gbCotizador.Controls.Add(txt);
            gbCotizador.Controls.Add(lbltarifa);
            gbCotizador.Location = new Point(12, 22);
            gbCotizador.Name = "gbCotizador";
            gbCotizador.Size = new Size(409, 273);
            gbCotizador.TabIndex = 9;
            gbCotizador.TabStop = false;
            gbCotizador.Text = "Cotizador";
            gbCotizador.Enter += gbCotizador_Enter;
            // 
            // gbTotales
            // 
            gbTotales.Controls.Add(lblTotal0);
            gbTotales.Controls.Add(lblITBIS0);
            gbTotales.Controls.Add(lblSERVICIOS0);
            gbTotales.Controls.Add(lblDescuento0);
            gbTotales.Controls.Add(lblsudtotal0);
            gbTotales.Controls.Add(lbltotal);
            gbTotales.Controls.Add(lblITBIS);
            gbTotales.Controls.Add(lblServicios);
            gbTotales.Controls.Add(lblDescuento);
            gbTotales.Controls.Add(lblsudtotal);
            gbTotales.Location = new Point(18, 327);
            gbTotales.Name = "gbTotales";
            gbTotales.Size = new Size(300, 205);
            gbTotales.TabIndex = 10;
            gbTotales.TabStop = false;
            gbTotales.Text = "Totales";
            // 
            // lblsudtotal
            // 
            lblsudtotal.AutoSize = true;
            lblsudtotal.Location = new Point(22, 36);
            lblsudtotal.Name = "lblsudtotal";
            lblsudtotal.Size = new Size(79, 25);
            lblsudtotal.TabIndex = 0;
            lblsudtotal.Text = "Sudtotal";
            lblsudtotal.Click += lbl_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(22, 61);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(96, 25);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento";
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(22, 107);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(81, 25);
            lblServicios.TabIndex = 2;
            lblServicios.Text = "Servicios";
            // 
            // lblITBIS
            // 
            lblITBIS.AutoSize = true;
            lblITBIS.Location = new Point(22, 86);
            lblITBIS.Name = "lblITBIS";
            lblITBIS.Size = new Size(51, 25);
            lblITBIS.TabIndex = 3;
            lblITBIS.Text = "ITBIS";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Location = new Point(24, 132);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(49, 25);
            lbltotal.TabIndex = 4;
            lbltotal.Text = "Total";
            // 
            // lblTotal0
            // 
            lblTotal0.AutoSize = true;
            lblTotal0.Location = new Point(126, 132);
            lblTotal0.Name = "lblTotal0";
            lblTotal0.Size = new Size(22, 25);
            lblTotal0.TabIndex = 9;
            lblTotal0.Text = "0";
            lblTotal0.Click += label1_Click;
            // 
            // lblITBIS0
            // 
            lblITBIS0.AutoSize = true;
            lblITBIS0.Location = new Point(124, 86);
            lblITBIS0.Name = "lblITBIS0";
            lblITBIS0.Size = new Size(22, 25);
            lblITBIS0.TabIndex = 8;
            lblITBIS0.Text = "0";
            // 
            // lblSERVICIOS0
            // 
            lblSERVICIOS0.AutoSize = true;
            lblSERVICIOS0.Location = new Point(124, 107);
            lblSERVICIOS0.Name = "lblSERVICIOS0";
            lblSERVICIOS0.Size = new Size(22, 25);
            lblSERVICIOS0.TabIndex = 7;
            lblSERVICIOS0.Text = "0";
            lblSERVICIOS0.Click += label3_Click;
            // 
            // lblDescuento0
            // 
            lblDescuento0.AutoSize = true;
            lblDescuento0.Location = new Point(124, 61);
            lblDescuento0.Name = "lblDescuento0";
            lblDescuento0.Size = new Size(22, 25);
            lblDescuento0.TabIndex = 6;
            lblDescuento0.Text = "0";
            // 
            // lblsudtotal0
            // 
            lblsudtotal0.AutoSize = true;
            lblsudtotal0.Location = new Point(124, 36);
            lblsudtotal0.Name = "lblsudtotal0";
            lblsudtotal0.Size = new Size(22, 25);
            lblsudtotal0.TabIndex = 5;
            lblsudtotal0.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 544);
            Controls.Add(gbTotales);
            Controls.Add(gbCotizador);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cotizador Villa coral - Enmanuel Chalas 2024-2062";
            Load += Form1_Load;
            gbCotizador.ResumeLayout(false);
            gbCotizador.PerformLayout();
            gbTotales.ResumeLayout(false);
            gbTotales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblHuesped;
        private TextBox txthuesped;
        private Label lblNoches;
        private TextBox textBox1;
        private Label lbltarifa;
        private TextBox txt;
        private CheckBox chebox;
        private Button btnCalcular;
        private Button btnLimpiar;
        private GroupBox gbCotizador;
        private GroupBox gbTotales;
        private Label lblsudtotal;
        private Label lblTotal0;
        private Label lblITBIS0;
        private Label lblSERVICIOS0;
        private Label lblDescuento0;
        private Label lblsudtotal0;
        private Label lbltotal;
        private Label lblITBIS;
        private Label lblServicios;
        private Label lblDescuento;
    }
}
