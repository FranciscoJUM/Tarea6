
namespace CalendarioDePrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DateFecha = new System.Windows.Forms.DateTimePicker();
            this.DateFechadepago = new System.Windows.Forms.DateTimePicker();
            this.NumMonto = new System.Windows.Forms.NumericUpDown();
            this.NumTasa = new System.Windows.Forms.NumericUpDown();
            this.NumTerminos = new System.Windows.Forms.NumericUpDown();
            this.CheckPrincipal = new System.Windows.Forms.CheckBox();
            this.CheckCuota = new System.Windows.Forms.CheckBox();
            this.CheckInteres = new System.Windows.Forms.CheckBox();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Crear = new System.Windows.Forms.Button();
            this.RichMuestra = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTerminos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monto del prestamo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Principal pagado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terminos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de pago ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tasa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Interes pagado";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 401);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cuota pagada";
            // 
            // DateFecha
            // 
            this.DateFecha.Location = new System.Drawing.Point(159, 35);
            this.DateFecha.Name = "DateFecha";
            this.DateFecha.Size = new System.Drawing.Size(248, 22);
            this.DateFecha.TabIndex = 10;
            // 
            // DateFechadepago
            // 
            this.DateFechadepago.Location = new System.Drawing.Point(159, 223);
            this.DateFechadepago.Name = "DateFechadepago";
            this.DateFechadepago.Size = new System.Drawing.Size(248, 22);
            this.DateFechadepago.TabIndex = 11;
            // 
            // NumMonto
            // 
            this.NumMonto.DecimalPlaces = 2;
            this.NumMonto.Location = new System.Drawing.Point(159, 86);
            this.NumMonto.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumMonto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMonto.Name = "NumMonto";
            this.NumMonto.Size = new System.Drawing.Size(248, 22);
            this.NumMonto.TabIndex = 12;
            this.NumMonto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumTasa
            // 
            this.NumTasa.DecimalPlaces = 2;
            this.NumTasa.Location = new System.Drawing.Point(159, 138);
            this.NumTasa.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumTasa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTasa.Name = "NumTasa";
            this.NumTasa.Size = new System.Drawing.Size(248, 22);
            this.NumTasa.TabIndex = 13;
            this.NumTasa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumTerminos
            // 
            this.NumTerminos.DecimalPlaces = 2;
            this.NumTerminos.Location = new System.Drawing.Point(159, 269);
            this.NumTerminos.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumTerminos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTerminos.Name = "NumTerminos";
            this.NumTerminos.Size = new System.Drawing.Size(248, 22);
            this.NumTerminos.TabIndex = 14;
            this.NumTerminos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CheckPrincipal
            // 
            this.CheckPrincipal.AutoSize = true;
            this.CheckPrincipal.Location = new System.Drawing.Point(159, 318);
            this.CheckPrincipal.Name = "CheckPrincipal";
            this.CheckPrincipal.Size = new System.Drawing.Size(79, 21);
            this.CheckPrincipal.TabIndex = 15;
            this.CheckPrincipal.Text = "Pagado";
            this.CheckPrincipal.UseVisualStyleBackColor = true;
            // 
            // CheckCuota
            // 
            this.CheckCuota.AutoSize = true;
            this.CheckCuota.Location = new System.Drawing.Point(159, 400);
            this.CheckCuota.Name = "CheckCuota";
            this.CheckCuota.Size = new System.Drawing.Size(79, 21);
            this.CheckCuota.TabIndex = 16;
            this.CheckCuota.Text = "Pagado";
            this.CheckCuota.UseVisualStyleBackColor = true;
            // 
            // CheckInteres
            // 
            this.CheckInteres.AutoSize = true;
            this.CheckInteres.Location = new System.Drawing.Point(159, 358);
            this.CheckInteres.Name = "CheckInteres";
            this.CheckInteres.Size = new System.Drawing.Size(79, 21);
            this.CheckInteres.TabIndex = 17;
            this.CheckInteres.Text = "Pagado";
            this.CheckInteres.UseVisualStyleBackColor = true;
            // 
            // CmbEstado
            // 
            this.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Location = new System.Drawing.Point(159, 179);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(248, 24);
            this.CmbEstado.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.Mostrar);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Crear);
            this.groupBox1.Controls.Add(this.CmbEstado);
            this.groupBox1.Controls.Add(this.CheckInteres);
            this.groupBox1.Controls.Add(this.CheckCuota);
            this.groupBox1.Controls.Add(this.CheckPrincipal);
            this.groupBox1.Controls.Add(this.NumTerminos);
            this.groupBox1.Controls.Add(this.NumTasa);
            this.groupBox1.Controls.Add(this.NumMonto);
            this.groupBox1.Controls.Add(this.DateFechadepago);
            this.groupBox1.Controls.Add(this.DateFecha);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 505);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atributos";
            // 
            // Crear
            // 
            this.Crear.Location = new System.Drawing.Point(9, 439);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(134, 45);
            this.Crear.TabIndex = 19;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.Crear_Click);
            // 
            // RichMuestra
            // 
            this.RichMuestra.BackColor = System.Drawing.SystemColors.ControlDark;
            this.RichMuestra.Location = new System.Drawing.Point(448, 8);
            this.RichMuestra.Name = "RichMuestra";
            this.RichMuestra.Size = new System.Drawing.Size(420, 505);
            this.RichMuestra.TabIndex = 20;
            this.RichMuestra.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.Location = new System.Drawing.Point(273, 373);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(134, 45);
            this.Mostrar.TabIndex = 21;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            this.Mostrar.Click += new System.EventHandler(this.Mostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(876, 526);
            this.Controls.Add(this.RichMuestra);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Administrador de prestamos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTerminos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DateFecha;
        private System.Windows.Forms.DateTimePicker DateFechadepago;
        private System.Windows.Forms.NumericUpDown NumMonto;
        private System.Windows.Forms.NumericUpDown NumTasa;
        private System.Windows.Forms.NumericUpDown NumTerminos;
        private System.Windows.Forms.CheckBox CheckPrincipal;
        private System.Windows.Forms.CheckBox CheckCuota;
        private System.Windows.Forms.CheckBox CheckInteres;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.RichTextBox RichMuestra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Mostrar;
    }
}

