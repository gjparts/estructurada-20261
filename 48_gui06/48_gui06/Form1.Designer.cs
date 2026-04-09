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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 543);
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
    }
}
