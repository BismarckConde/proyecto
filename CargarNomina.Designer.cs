namespace PracticaLogin
{
    partial class CargarNomina
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
            lvNomina = new ListView();
            txtDireccion = new TextBox();
            btnCargar = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // lvNomina
            // 
            lvNomina.GridLines = true;
            lvNomina.Location = new Point(12, 71);
            lvNomina.Name = "lvNomina";
            lvNomina.Size = new Size(1534, 334);
            lvNomina.TabIndex = 0;
            lvNomina.UseCompatibleStateImageBehavior = false;
            lvNomina.View = View.Details;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 442);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(341, 23);
            txtDireccion.TabIndex = 1;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(12, 471);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(101, 43);
            btnCargar.TabIndex = 2;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 424);
            label1.Name = "label1";
            label1.Size = new Size(275, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el Nombre del Archivo a Cargar la Nomina:";
            // 
            // button1
            // 
            button1.Location = new Point(1454, 535);
            button1.Name = "button1";
            button1.Size = new Size(104, 62);
            button1.TabIndex = 4;
            button1.Text = "Volver a Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei Light", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(76, 9);
            label2.Name = "label2";
            label2.Size = new Size(1408, 53);
            label2.TabIndex = 5;
            label2.Text = "Nomina Laboral";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CargarNomina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 609);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnCargar);
            Controls.Add(txtDireccion);
            Controls.Add(lvNomina);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CargarNomina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CargarNomina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvNomina;
        private TextBox txtDireccion;
        private Button btnCargar;
        private Label label1;
        private Button button1;
        private Label label2;
    }
}