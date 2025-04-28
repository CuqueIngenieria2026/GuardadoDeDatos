namespace GuardadoDeDatos
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            label1.Location = new Point(204, 43);
            label1.Name = "label1";
            label1.Size = new Size(518, 32);
            label1.TabIndex = 0;
            label1.Text = "Pre-Laboratorio Ejercicio de Guardado de Datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            label2.Location = new Point(317, 99);
            label2.Name = "label2";
            label2.Size = new Size(301, 32);
            label2.TabIndex = 1;
            label2.Text = "Por José Andrés Cuque Ruíz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            label3.Location = new Point(337, 158);
            label3.Name = "label3";
            label3.Size = new Size(253, 32);
            label3.TabIndex = 2;
            label3.Text = "Grado: 5to.Bachillerato";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            label4.Location = new Point(412, 212);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 3;
            label4.Text = "Sección: D";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Italic);
            label5.Location = new Point(412, 266);
            label5.Name = "label5";
            label5.Size = new Size(89, 32);
            label5.TabIndex = 4;
            label5.Text = "Clave:9";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(283, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(622, 382);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 6;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Button button1;
    }
}