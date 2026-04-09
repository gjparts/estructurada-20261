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
            combo1 = new ComboBox();
            etiqueta2 = new Label();
            etiqueta3 = new Label();
            boton2 = new Button();
            boton3 = new Button();
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
            // combo1
            // 
            combo1.DropDownStyle = ComboBoxStyle.DropDownList;
            combo1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combo1.FormattingEnabled = true;
            combo1.Items.AddRange(new object[] { "Honduras", "El Salvador", "Guatemala", "Nicaragua", "Costa Rica", "Panama" });
            combo1.Location = new Point(12, 141);
            combo1.Name = "combo1";
            combo1.Size = new Size(359, 48);
            combo1.TabIndex = 3;
            combo1.SelectedIndexChanged += combo1_SelectedIndexChanged;
            // 
            // etiqueta2
            // 
            etiqueta2.AutoSize = true;
            etiqueta2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiqueta2.Location = new Point(12, 203);
            etiqueta2.Name = "etiqueta2";
            etiqueta2.Size = new Size(94, 40);
            etiqueta2.TabIndex = 4;
            etiqueta2.Text = "label1";
            // 
            // etiqueta3
            // 
            etiqueta3.AutoSize = true;
            etiqueta3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            etiqueta3.Location = new Point(12, 243);
            etiqueta3.Name = "etiqueta3";
            etiqueta3.Size = new Size(94, 40);
            etiqueta3.TabIndex = 5;
            etiqueta3.Text = "label1";
            // 
            // boton2
            // 
            boton2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton2.Location = new Point(416, 141);
            boton2.Name = "boton2";
            boton2.Size = new Size(353, 48);
            boton2.TabIndex = 6;
            boton2.Text = "Seleccionar Sandia";
            boton2.UseVisualStyleBackColor = true;
            boton2.Click += boton2_Click;
            // 
            // boton3
            // 
            boton3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton3.Location = new Point(416, 195);
            boton3.Name = "boton3";
            boton3.Size = new Size(353, 48);
            boton3.TabIndex = 7;
            boton3.Text = "Seleccionar item 4";
            boton3.UseVisualStyleBackColor = true;
            boton3.Click += boton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 405);
            Controls.Add(boton3);
            Controls.Add(boton2);
            Controls.Add(etiqueta3);
            Controls.Add(etiqueta2);
            Controls.Add(combo1);
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
        private ComboBox combo1;
        private Label etiqueta2;
        private Label etiqueta3;
        private Button boton2;
        private Button boton3;
    }
}
