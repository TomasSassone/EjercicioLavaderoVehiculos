namespace AppLavaderoWForm
{
    partial class FrmIngreso
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
            lblVehiculo = new Label();
            lblMarca = new Label();
            lblPatente = new Label();
            txtTara = new TextBox();
            lblTara = new Label();
            txtCilindrada = new TextBox();
            lblCilindrada = new Label();
            txtAsientos = new TextBox();
            lblCantAsientos = new Label();
            cmbVehiculo = new ComboBox();
            btnIngresarVehiculo = new Button();
            txtCantRuedas = new TextBox();
            txtRuedas = new Label();
            cmbMarcas = new ComboBox();
            txtPatente = new TextBox();
            SuspendLayout();
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(80, 53);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(52, 15);
            lblVehiculo.TabIndex = 0;
            lblVehiculo.Text = "Vehículo";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(80, 127);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 2;
            lblMarca.Text = "Marca";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(80, 212);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 4;
            lblPatente.Text = "Patente";
            // 
            // txtTara
            // 
            txtTara.Enabled = false;
            txtTara.Location = new Point(342, 299);
            txtTara.Name = "txtTara";
            txtTara.Size = new Size(130, 23);
            txtTara.TabIndex = 11;
            // 
            // lblTara
            // 
            lblTara.AutoSize = true;
            lblTara.Location = new Point(342, 272);
            lblTara.Name = "lblTara";
            lblTara.Size = new Size(28, 15);
            lblTara.TabIndex = 10;
            lblTara.Text = "Tara";
            // 
            // txtCilindrada
            // 
            txtCilindrada.Enabled = false;
            txtCilindrada.Location = new Point(342, 214);
            txtCilindrada.Name = "txtCilindrada";
            txtCilindrada.Size = new Size(130, 23);
            txtCilindrada.TabIndex = 9;
            // 
            // lblCilindrada
            // 
            lblCilindrada.AutoSize = true;
            lblCilindrada.Location = new Point(342, 187);
            lblCilindrada.Name = "lblCilindrada";
            lblCilindrada.Size = new Size(84, 15);
            lblCilindrada.TabIndex = 8;
            lblCilindrada.Text = "Cilindrada (cc)";
            // 
            // txtAsientos
            // 
            txtAsientos.Enabled = false;
            txtAsientos.Location = new Point(342, 115);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(130, 23);
            txtAsientos.TabIndex = 7;
            // 
            // lblCantAsientos
            // 
            lblCantAsientos.AutoSize = true;
            lblCantAsientos.Location = new Point(342, 88);
            lblCantAsientos.Name = "lblCantAsientos";
            lblCantAsientos.Size = new Size(117, 15);
            lblCantAsientos.TabIndex = 6;
            lblCantAsientos.Text = "Cantidad de asientos";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Items.AddRange(new object[] { "Auto", "Camion", "Moto" });
            cmbVehiculo.Location = new Point(80, 80);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(160, 23);
            cmbVehiculo.TabIndex = 12;
            cmbVehiculo.Text = "Seleccione un vehículo...";
            cmbVehiculo.SelectedIndexChanged += cmbVehiculo_SelectedIndexChanged;
            // 
            // btnIngresarVehiculo
            // 
            btnIngresarVehiculo.Location = new Point(174, 367);
            btnIngresarVehiculo.Name = "btnIngresarVehiculo";
            btnIngresarVehiculo.Size = new Size(196, 38);
            btnIngresarVehiculo.TabIndex = 13;
            btnIngresarVehiculo.Text = "Ingresar";
            btnIngresarVehiculo.UseVisualStyleBackColor = true;
            btnIngresarVehiculo.Click += btnIngresarVehiculo_Click;
            // 
            // txtCantRuedas
            // 
            txtCantRuedas.Location = new Point(80, 313);
            txtCantRuedas.Name = "txtCantRuedas";
            txtCantRuedas.Size = new Size(160, 23);
            txtCantRuedas.TabIndex = 15;
            // 
            // txtRuedas
            // 
            txtRuedas.AutoSize = true;
            txtRuedas.Location = new Point(80, 286);
            txtRuedas.Name = "txtRuedas";
            txtRuedas.Size = new Size(109, 15);
            txtRuedas.TabIndex = 14;
            txtRuedas.Text = "Cantidad de ruedas";
            // 
            // cmbMarcas
            // 
            cmbMarcas.FormattingEnabled = true;
            cmbMarcas.Items.AddRange(new object[] { "Honda", "Ford", "Zanella", "Scania", "Iveco", "Fiat" });
            cmbMarcas.Location = new Point(80, 158);
            cmbMarcas.Name = "cmbMarcas";
            cmbMarcas.Size = new Size(160, 23);
            cmbMarcas.TabIndex = 16;
            cmbMarcas.Text = "Seleccione una marca...";
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(80, 239);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(160, 23);
            txtPatente.TabIndex = 5;
            // 
            // FrmIngreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 450);
            Controls.Add(cmbMarcas);
            Controls.Add(txtCantRuedas);
            Controls.Add(txtRuedas);
            Controls.Add(btnIngresarVehiculo);
            Controls.Add(cmbVehiculo);
            Controls.Add(txtTara);
            Controls.Add(lblTara);
            Controls.Add(txtCilindrada);
            Controls.Add(lblCilindrada);
            Controls.Add(txtAsientos);
            Controls.Add(lblCantAsientos);
            Controls.Add(txtPatente);
            Controls.Add(lblPatente);
            Controls.Add(lblMarca);
            Controls.Add(lblVehiculo);
            Name = "FrmIngreso";
            Text = "Ingresar nuevo vehículo";
            Load += FrmIngreso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVehiculo;
        private Label lblMarca;
        private Label lblPatente;
        private TextBox txtTara;
        private Label lblTara;
        private TextBox txtCilindrada;
        private Label lblCilindrada;
        private TextBox txtAsientos;
        private Label lblCantAsientos;
        private ComboBox cmbVehiculo;
        private Button btnIngresarVehiculo;
        private TextBox txtCantRuedas;
        private Label txtRuedas;
        private ComboBox cmbMarcas;
        private TextBox txtPatente;
    }
}