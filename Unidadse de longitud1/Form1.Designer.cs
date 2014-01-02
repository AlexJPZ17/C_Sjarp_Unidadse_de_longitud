namespace Unidadse_de_longitud
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListBox_Medidas = new System.Windows.Forms.ListBox();
            this.Button_Run = new System.Windows.Forms.Button();
            this.Button_Clean = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_Opciones = new System.Windows.Forms.ComboBox();
            this.TextBox_Valor = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBox_Medidas
            // 
            this.ListBox_Medidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Medidas.FormattingEnabled = true;
            this.ListBox_Medidas.ItemHeight = 18;
            this.ListBox_Medidas.Location = new System.Drawing.Point(6, 19);
            this.ListBox_Medidas.Name = "ListBox_Medidas";
            this.ListBox_Medidas.Size = new System.Drawing.Size(202, 202);
            this.ListBox_Medidas.TabIndex = 0;
            // 
            // Button_Run
            // 
            this.Button_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Run.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Run.Location = new System.Drawing.Point(18, 366);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 6;
            this.Button_Run.Text = "Run";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // Button_Clean
            // 
            this.Button_Clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Clean.ForeColor = System.Drawing.SystemColors.Control;
            this.Button_Clean.Location = new System.Drawing.Point(154, 366);
            this.Button_Clean.Name = "Button_Clean";
            this.Button_Clean.Size = new System.Drawing.Size(75, 23);
            this.Button_Clean.TabIndex = 8;
            this.Button_Clean.Text = "Clean";
            this.Button_Clean.UseVisualStyleBackColor = true;
            this.Button_Clean.Click += new System.EventHandler(this.Button_Clean_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.ForeColor = System.Drawing.SystemColors.Control;
            this.Label1.Location = new System.Drawing.Point(128, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 15);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Opciones";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.Control;
            this.Label2.Location = new System.Drawing.Point(27, 25);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(35, 15);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Valor";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ListBox_Medidas);
            this.GroupBox1.Location = new System.Drawing.Point(12, 98);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(217, 249);
            this.GroupBox1.TabIndex = 10;
            this.GroupBox1.TabStop = false;
            // 
            // ComboBox_Opciones
            // 
            this.ComboBox_Opciones.FormattingEnabled = true;
            this.ComboBox_Opciones.Items.AddRange(new object[] {
            "Milimetros",
            "Centimetros",
            "Pulgadas",
            "Pies",
            "Metros",
            "Yardas",
            "Kilometros",
            "Millas"});
            this.ComboBox_Opciones.Location = new System.Drawing.Point(108, 54);
            this.ComboBox_Opciones.Name = "ComboBox_Opciones";
            this.ComboBox_Opciones.Size = new System.Drawing.Size(121, 21);
            this.ComboBox_Opciones.TabIndex = 4;
            this.ComboBox_Opciones.Text = "Unidades a convertir";
            // 
            // TextBox_Valor
            // 
            this.TextBox_Valor.Location = new System.Drawing.Point(12, 54);
            this.TextBox_Valor.Name = "TextBox_Valor";
            this.TextBox_Valor.Size = new System.Drawing.Size(68, 20);
            this.TextBox_Valor.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(242, 411);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.Button_Clean);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ComboBox_Opciones);
            this.Controls.Add(this.TextBox_Valor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox ListBox_Medidas;
        internal System.Windows.Forms.Button Button_Run;
        internal System.Windows.Forms.Button Button_Clean;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox ComboBox_Opciones;
        internal System.Windows.Forms.TextBox TextBox_Valor;

    }
}

