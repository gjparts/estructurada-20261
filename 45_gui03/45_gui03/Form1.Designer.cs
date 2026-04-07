namespace _45_gui03
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
            label1 = new Label();
            caja1 = new TextBox();
            caja2 = new TextBox();
            label2 = new Label();
            total = new TextBox();
            label3 = new Label();
            boton1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 0;
            label1.Text = "Cifra 1:";
            // 
            // caja1
            // 
            caja1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja1.Location = new Point(124, 6);
            caja1.Name = "caja1";
            caja1.Size = new Size(380, 46);
            caja1.TabIndex = 1;
            caja1.Text = "0.00";
            caja1.TextAlign = HorizontalAlignment.Right;
            // 
            // caja2
            // 
            caja2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja2.Location = new Point(124, 58);
            caja2.Name = "caja2";
            caja2.Size = new Size(380, 46);
            caja2.TabIndex = 3;
            caja2.Text = "0.00";
            caja2.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(106, 40);
            label2.TabIndex = 2;
            label2.Text = "Cifra 2:";
            // 
            // total
            // 
            total.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total.Location = new Point(124, 110);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(380, 46);
            total.TabIndex = 5;
            total.Text = "0.00";
            total.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(94, 40);
            label3.TabIndex = 4;
            label3.Text = "Suma:";
            // 
            // boton1
            // 
            boton1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton1.Location = new Point(124, 178);
            boton1.Name = "boton1";
            boton1.Size = new Size(263, 53);
            boton1.TabIndex = 6;
            boton1.Text = "Sumar";
            boton1.UseVisualStyleBackColor = true;
            boton1.Click += boton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 243);
            Controls.Add(boton1);
            Controls.Add(total);
            Controls.Add(label3);
            Controls.Add(caja2);
            Controls.Add(label2);
            Controls.Add(caja1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sumadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox caja1;
        private TextBox caja2;
        private Label label2;
        private TextBox total;
        private Label label3;
        private Button boton1;
    }
}
