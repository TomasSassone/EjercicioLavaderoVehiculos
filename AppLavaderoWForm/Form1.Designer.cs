namespace AppLavaderoWForm
{
    partial class FrmLavadero
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
            btnIngresar = new Button();
            label1 = new Label();
            BtnVerIngresados = new Button();
            lstVisor = new ListBox();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(106, 429);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(195, 43);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar nuevo vehículo";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(190, 23);
            label1.Name = "label1";
            label1.Size = new Size(308, 54);
            label1.TabIndex = 1;
            label1.Text = "Lavadero Asone";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnVerIngresados
            // 
            BtnVerIngresados.Location = new Point(378, 429);
            BtnVerIngresados.Name = "BtnVerIngresados";
            BtnVerIngresados.Size = new Size(195, 43);
            BtnVerIngresados.TabIndex = 2;
            BtnVerIngresados.Text = "Ver vehículos ingresados";
            BtnVerIngresados.UseVisualStyleBackColor = true;
            BtnVerIngresados.Click += BtnVerIngresados_Click;
            // 
            // lstVisor
            // 
            lstVisor.FormattingEnabled = true;
            lstVisor.ItemHeight = 15;
            lstVisor.Location = new Point(32, 98);
            lstVisor.Name = "lstVisor";
            lstVisor.Size = new Size(614, 304);
            lstVisor.TabIndex = 3;
            // 
            // FrmLavadero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 508);
            Controls.Add(lstVisor);
            Controls.Add(BtnVerIngresados);
            Controls.Add(label1);
            Controls.Add(btnIngresar);
            Name = "FrmLavadero";
            Text = "Lavadero asone";
            Load += FrmLavadero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar;
        private Label label1;
        private Button BtnVerIngresados;
        private ListBox lstVisor;
    }
}