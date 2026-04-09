namespace _47_gui05
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
            casilla1 = new CheckBox();
            etiqueta1 = new Label();
            boton1 = new Button();
            SuspendLayout();
            // 
            // casilla1
            // 
            casilla1.AutoSize = true;
            casilla1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            casilla1.Location = new Point(12, 12);
            casilla1.Name = "casilla1";
            casilla1.Size = new Size(347, 49);
            casilla1.TabIndex = 0;
            casilla1.Text = "Solo soy un checkbox";
            casilla1.UseVisualStyleBackColor = true;
            casilla1.CheckedChanged += casilla1_CheckedChanged;
            // 
            // etiqueta1
            // 
            etiqueta1.AutoSize = true;
            etiqueta1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiqueta1.Location = new Point(12, 64);
            etiqueta1.Name = "etiqueta1";
            etiqueta1.Size = new Size(94, 40);
            etiqueta1.TabIndex = 1;
            etiqueta1.Text = "label1";
            // 
            // boton1
            // 
            boton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton1.Location = new Point(416, 12);
            boton1.Name = "boton1";
            boton1.Size = new Size(353, 71);
            boton1.TabIndex = 2;
            boton1.Text = "Que valor tiene casilla1?";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 405);
            Controls.Add(boton1);
            Controls.Add(etiqueta1);
            Controls.Add(casilla1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox casilla1;
        private Label etiqueta1;
        private Button boton1;
    }
}
