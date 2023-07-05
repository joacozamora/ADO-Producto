namespace WinformProducto1
{
    partial class FormProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_cargar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txb_Precio = new System.Windows.Forms.TextBox();
            this.txb_Genero = new System.Windows.Forms.TextBox();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_Genero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_descuento = new System.Windows.Forms.TextBox();
            this.txb_cambionomb = new System.Windows.Forms.TextBox();
            this.lbl_NombreFinal = new System.Windows.Forms.Label();
            this.lbl_PrecioFinal = new System.Windows.Forms.Label();
            this.btn_aplicar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero";
            // 
            // btn_cargar
            // 
            this.btn_cargar.Location = new System.Drawing.Point(300, 87);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(75, 23);
            this.btn_cargar.TabIndex = 3;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.UseVisualStyleBackColor = true;
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(45, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 381);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txb_Precio);
            this.tabPage1.Controls.Add(this.txb_Genero);
            this.tabPage1.Controls.Add(this.txb_Nombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_cargar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(633, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carga de Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txb_Precio
            // 
            this.txb_Precio.Location = new System.Drawing.Point(130, 87);
            this.txb_Precio.Name = "txb_Precio";
            this.txb_Precio.Size = new System.Drawing.Size(100, 20);
            this.txb_Precio.TabIndex = 6;
            // 
            // txb_Genero
            // 
            this.txb_Genero.Location = new System.Drawing.Point(130, 142);
            this.txb_Genero.Name = "txb_Genero";
            this.txb_Genero.Size = new System.Drawing.Size(100, 20);
            this.txb_Genero.TabIndex = 5;
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(130, 33);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txb_Nombre.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_aplicar);
            this.tabPage2.Controls.Add(this.lbl_Genero);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txb_descuento);
            this.tabPage2.Controls.Add(this.txb_cambionomb);
            this.tabPage2.Controls.Add(this.lbl_NombreFinal);
            this.tabPage2.Controls.Add(this.lbl_PrecioFinal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimiento de Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Genero
            // 
            this.lbl_Genero.AutoSize = true;
            this.lbl_Genero.Location = new System.Drawing.Point(58, 87);
            this.lbl_Genero.Name = "lbl_Genero";
            this.lbl_Genero.Size = new System.Drawing.Size(35, 13);
            this.lbl_Genero.TabIndex = 6;
            this.lbl_Genero.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descuento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cambiar Nombre";
            // 
            // txb_descuento
            // 
            this.txb_descuento.Location = new System.Drawing.Point(173, 165);
            this.txb_descuento.Name = "txb_descuento";
            this.txb_descuento.Size = new System.Drawing.Size(100, 20);
            this.txb_descuento.TabIndex = 3;
            // 
            // txb_cambionomb
            // 
            this.txb_cambionomb.Location = new System.Drawing.Point(173, 118);
            this.txb_cambionomb.Name = "txb_cambionomb";
            this.txb_cambionomb.Size = new System.Drawing.Size(100, 20);
            this.txb_cambionomb.TabIndex = 2;
            // 
            // lbl_NombreFinal
            // 
            this.lbl_NombreFinal.AutoSize = true;
            this.lbl_NombreFinal.Location = new System.Drawing.Point(58, 23);
            this.lbl_NombreFinal.Name = "lbl_NombreFinal";
            this.lbl_NombreFinal.Size = new System.Drawing.Size(35, 13);
            this.lbl_NombreFinal.TabIndex = 1;
            this.lbl_NombreFinal.Text = "label4";
            // 
            // lbl_PrecioFinal
            // 
            this.lbl_PrecioFinal.AutoSize = true;
            this.lbl_PrecioFinal.Location = new System.Drawing.Point(58, 55);
            this.lbl_PrecioFinal.Name = "lbl_PrecioFinal";
            this.lbl_PrecioFinal.Size = new System.Drawing.Size(35, 13);
            this.lbl_PrecioFinal.TabIndex = 0;
            this.lbl_PrecioFinal.Text = "label4";
            // 
            // btn_aplicar
            // 
            this.btn_aplicar.Location = new System.Drawing.Point(324, 143);
            this.btn_aplicar.Name = "btn_aplicar";
            this.btn_aplicar.Size = new System.Drawing.Size(75, 23);
            this.btn_aplicar.TabIndex = 7;
            this.btn_aplicar.Text = "button1";
            this.btn_aplicar.UseVisualStyleBackColor = true;
            this.btn_aplicar.Click += new System.EventHandler(this.btn_aplicar_Click);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_cargar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txb_Precio;
        private System.Windows.Forms.TextBox txb_Genero;
        private System.Windows.Forms.TextBox txb_Nombre;
        private System.Windows.Forms.Label lbl_PrecioFinal;
        private System.Windows.Forms.Label lbl_NombreFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_descuento;
        private System.Windows.Forms.TextBox txb_cambionomb;
        private System.Windows.Forms.Label lbl_Genero;
        private System.Windows.Forms.Button btn_aplicar;
    }
}