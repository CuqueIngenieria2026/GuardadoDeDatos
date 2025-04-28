namespace GuardadoDeDatos
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
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 29);
            label1.Name = "label1";
            label1.Size = new Size(221, 37);
            label1.TabIndex = 0;
            label1.Text = "Ventana de inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(81, 202);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(205, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(237, 299);
            button1.Name = "button1";
            button1.Size = new Size(101, 39);
            button1.TabIndex = 3;
            button1.Text = "Comprobar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 347);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Créditos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 153);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 5;
            label3.Tag = "Nombre:";
            label3.Text = "Nombre:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 372);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 7;
            label4.Text = "Contraseña: Cuque";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(565, 410);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
    }
}
