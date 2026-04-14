namespace _19_EntityFramework
{
    partial class Detalle
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
            label1 = new Label();
            Codigo = new TextBox();
            Nombre = new TextBox();
            label2 = new Label();
            Costo = new TextBox();
            label3 = new Label();
            PrecioVenta = new TextBox();
            label4 = new Label();
            Existencias = new TextBox();
            label5 = new Label();
            Comentarios = new TextBox();
            label6 = new Label();
            botonAceptar = new Button();
            botonCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(116, 40);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // Codigo
            // 
            Codigo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Codigo.Location = new Point(239, 6);
            Codigo.Name = "Codigo";
            Codigo.Size = new Size(191, 46);
            Codigo.TabIndex = 1;
            // 
            // Nombre
            // 
            Nombre.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Nombre.Location = new Point(239, 58);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(586, 46);
            Nombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(129, 40);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // Costo
            // 
            Costo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Costo.Location = new Point(239, 110);
            Costo.Name = "Costo";
            Costo.Size = new Size(200, 46);
            Costo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(97, 40);
            label3.TabIndex = 4;
            label3.Text = "Costo:";
            // 
            // PrecioVenta
            // 
            PrecioVenta.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrecioVenta.Location = new Point(239, 162);
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.Size = new Size(200, 46);
            PrecioVenta.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 165);
            label4.Name = "label4";
            label4.Size = new Size(221, 40);
            label4.TabIndex = 6;
            label4.Text = "Precio de Venta:";
            // 
            // Existencias
            // 
            Existencias.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Existencias.Location = new Point(239, 214);
            Existencias.Name = "Existencias";
            Existencias.Size = new Size(154, 46);
            Existencias.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 217);
            label5.Name = "label5";
            label5.Size = new Size(158, 40);
            label5.TabIndex = 8;
            label5.Text = "Existencias:";
            // 
            // Comentarios
            // 
            Comentarios.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Comentarios.Location = new Point(239, 266);
            Comentarios.Multiline = true;
            Comentarios.Name = "Comentarios";
            Comentarios.Size = new Size(586, 172);
            Comentarios.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 269);
            label6.Name = "label6";
            label6.Size = new Size(185, 40);
            label6.TabIndex = 10;
            label6.Text = "Comentarios:";
            // 
            // botonAceptar
            // 
            botonAceptar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonAceptar.Location = new Point(511, 449);
            botonAceptar.Name = "botonAceptar";
            botonAceptar.Size = new Size(150, 54);
            botonAceptar.TabIndex = 12;
            botonAceptar.Text = "Aceptar";
            botonAceptar.UseVisualStyleBackColor = true;
            botonAceptar.Click += botonAceptar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonCancelar.Location = new Point(667, 449);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(150, 54);
            botonCancelar.TabIndex = 13;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            botonCancelar.Click += botonCancelar_Click;
            // 
            // Detalle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 515);
            Controls.Add(botonCancelar);
            Controls.Add(botonAceptar);
            Controls.Add(Comentarios);
            Controls.Add(label6);
            Controls.Add(Existencias);
            Controls.Add(label5);
            Controls.Add(PrecioVenta);
            Controls.Add(label4);
            Controls.Add(Costo);
            Controls.Add(label3);
            Controls.Add(Nombre);
            Controls.Add(label2);
            Controls.Add(Codigo);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Detalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Codigo;
        private TextBox Nombre;
        private Label label2;
        private TextBox Costo;
        private Label label3;
        private TextBox PrecioVenta;
        private Label label4;
        private TextBox Existencias;
        private Label label5;
        private TextBox Comentarios;
        private Label label6;
        private Button botonAceptar;
        private Button botonCancelar;
    }
}