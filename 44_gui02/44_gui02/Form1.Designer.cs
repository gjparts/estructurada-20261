namespace _44_gui02
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
            components = new System.ComponentModel.Container();
            etiqueta1 = new Label();
            boton1 = new Button();
            boton2 = new Button();
            etiqueta2 = new Label();
            temporizador1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // etiqueta1
            // 
            etiqueta1.BackColor = Color.FromArgb(0, 192, 0);
            etiqueta1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiqueta1.ForeColor = Color.White;
            etiqueta1.Location = new Point(12, 9);
            etiqueta1.Name = "etiqueta1";
            etiqueta1.Size = new Size(351, 130);
            etiqueta1.TabIndex = 0;
            etiqueta1.Text = "SISTEMAS 2025";
            etiqueta1.TextAlign = ContentAlignment.MiddleCenter;
            etiqueta1.Click += etiqueta1_Click;
            // 
            // boton1
            // 
            boton1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton1.Location = new Point(380, 9);
            boton1.Name = "boton1";
            boton1.Size = new Size(307, 60);
            boton1.TabIndex = 1;
            boton1.Text = "Click aqui";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // boton2
            // 
            boton2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton2.Location = new Point(380, 75);
            boton2.Name = "boton2";
            boton2.Size = new Size(307, 64);
            boton2.TabIndex = 2;
            boton2.Text = "Cambiar titulo de ventana";
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += boton2_Click;
            // 
            // etiqueta2
            // 
            etiqueta2.BackColor = Color.Black;
            etiqueta2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiqueta2.ForeColor = Color.Lime;
            etiqueta2.Location = new Point(12, 153);
            etiqueta2.Name = "etiqueta2";
            etiqueta2.Size = new Size(675, 46);
            etiqueta2.TabIndex = 3;
            etiqueta2.Text = "label1";
            // 
            // temporizador1
            // 
            temporizador1.Enabled = true;
            temporizador1.Interval = 500;
            temporizador1.Tick += temporizador1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(703, 217);
            Controls.Add(etiqueta2);
            Controls.Add(boton2);
            Controls.Add(boton1);
            Controls.Add(etiqueta1);
            Name = "Form1";
            Text = "20012002049 - Gerardo Portillo";
            ResumeLayout(false);
        }

        #endregion

        private Label etiqueta1;
        private Button boton1;
        private Button boton2;
        private Label etiqueta2;
        private System.Windows.Forms.Timer temporizador1;
    }
}
