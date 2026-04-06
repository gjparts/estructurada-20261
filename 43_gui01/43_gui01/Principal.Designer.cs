namespace _43_gui01
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            label1 = new Label();
            button1 = new Button();
            caja1 = new TextBox();
            textBox2 = new TextBox();
            botonPrueba = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(222, 50);
            label1.TabIndex = 0;
            label1.Text = "Soy un label";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(12, 87);
            button1.Name = "button1";
            button1.Size = new Size(235, 107);
            button1.TabIndex = 1;
            button1.Text = "Click Aqui";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // caja1
            // 
            caja1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            caja1.Location = new Point(12, 213);
            caja1.Name = "caja1";
            caja1.PlaceholderText = "Escriba aqui";
            caja1.Size = new Size(440, 43);
            caja1.TabIndex = 2;
            caja1.Text = "soy una caja de texto";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(12, 262);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(433, 267);
            textBox2.TabIndex = 3;
            // 
            // botonPrueba
            // 
            botonPrueba.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botonPrueba.Location = new Point(472, 206);
            botonPrueba.Name = "botonPrueba";
            botonPrueba.Size = new Size(197, 50);
            botonPrueba.TabIndex = 4;
            botonPrueba.Text = "Ver Mensaje";
            botonPrueba.UseVisualStyleBackColor = true;
            botonPrueba.Click += botonPrueba_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(176, 224, 247);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(900, 541);
            Controls.Add(botonPrueba);
            Controls.Add(textBox2);
            Controls.Add(caja1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(200, 500);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "20012002049 - Gerardo Portillo";
            FormClosed += Principal_FormClosed;
            Load += Principal_Load;
            Shown += Principal_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox caja1;
        private TextBox textBox2;
        private Button botonPrueba;
    }
}
