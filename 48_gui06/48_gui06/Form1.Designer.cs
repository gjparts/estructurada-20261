namespace _48_gui06
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
            lista1 = new ListBox();
            caja1 = new TextBox();
            boton1 = new Button();
            boton2 = new Button();
            boton3 = new Button();
            boton4 = new Button();
            boton5 = new Button();
            label1 = new Label();
            caja2 = new TextBox();
            caja3 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lista1
            // 
            lista1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lista1.FormattingEnabled = true;
            lista1.Items.AddRange(new object[] { "Rojo", "Amarillo", "Azul" });
            lista1.Location = new Point(12, 72);
            lista1.Name = "lista1";
            lista1.Size = new Size(717, 452);
            lista1.TabIndex = 0;
            // 
            // caja1
            // 
            caja1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja1.Location = new Point(12, 12);
            caja1.Name = "caja1";
            caja1.Size = new Size(358, 46);
            caja1.TabIndex = 1;
            // 
            // boton1
            // 
            boton1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton1.Location = new Point(376, 12);
            boton1.Name = "boton1";
            boton1.Size = new Size(353, 46);
            boton1.TabIndex = 2;
            boton1.Text = "Agregar usando TextBox";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // boton2
            // 
            boton2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton2.Location = new Point(735, 72);
            boton2.Name = "boton2";
            boton2.Size = new Size(353, 46);
            boton2.TabIndex = 3;
            boton2.Text = "Agregar usando InputBox";
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += boton2_Click;
            // 
            // boton3
            // 
            boton3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton3.Location = new Point(735, 124);
            boton3.Name = "boton3";
            boton3.Size = new Size(353, 46);
            boton3.TabIndex = 4;
            boton3.Text = "Editar";
            boton3.UseVisualStyleBackColor = true;
            boton3.Click += boton3_Click;
            // 
            // boton4
            // 
            boton4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton4.Location = new Point(735, 244);
            boton4.Name = "boton4";
            boton4.Size = new Size(353, 46);
            boton4.TabIndex = 5;
            boton4.Text = "Eliminar";
            boton4.UseVisualStyleBackColor = true;
            boton4.Click += boton4_Click;
            // 
            // boton5
            // 
            boton5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton5.Location = new Point(733, 357);
            boton5.Name = "boton5";
            boton5.Size = new Size(353, 46);
            boton5.TabIndex = 6;
            boton5.Text = "Limpiar";
            boton5.UseVisualStyleBackColor = true;
            boton5.Click += boton5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(735, 455);
            label1.Name = "label1";
            label1.Size = new Size(171, 25);
            label1.TabIndex = 7;
            label1.Text = "Cantidad de Gatos:";
            // 
            // caja2
            // 
            caja2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja2.Location = new Point(922, 452);
            caja2.Name = "caja2";
            caja2.ReadOnly = true;
            caja2.Size = new Size(164, 33);
            caja2.TabIndex = 8;
            // 
            // caja3
            // 
            caja3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja3.Location = new Point(922, 491);
            caja3.Name = "caja3";
            caja3.ReadOnly = true;
            caja3.Size = new Size(164, 33);
            caja3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(737, 494);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 9;
            label2.Text = "Cantidad de Perros:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 543);
            Controls.Add(caja3);
            Controls.Add(label2);
            Controls.Add(caja2);
            Controls.Add(label1);
            Controls.Add(boton5);
            Controls.Add(boton4);
            Controls.Add(boton3);
            Controls.Add(boton2);
            Controls.Add(boton1);
            Controls.Add(caja1);
            Controls.Add(lista1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lista1;
        private TextBox caja1;
        private Button boton1;
        private Button boton2;
        private Button boton3;
        private Button boton4;
        private Button boton5;
        private Label label1;
        private TextBox caja2;
        private TextBox caja3;
        private Label label2;
    }
}
