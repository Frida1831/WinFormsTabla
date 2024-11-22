namespace WinFormsTabla
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
            panelprincipal = new Panel();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            textBoxnum = new TextBox();
            labelnumero = new Label();
            labeltitulo = new Label();
            label1 = new Label();
            panelprincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelprincipal
            // 
            panelprincipal.BackColor = Color.FromArgb(192, 255, 255);
            panelprincipal.Controls.Add(label1);
            panelprincipal.Controls.Add(richTextBox1);
            panelprincipal.Controls.Add(button1);
            panelprincipal.Controls.Add(textBoxnum);
            panelprincipal.Controls.Add(labelnumero);
            panelprincipal.Controls.Add(labeltitulo);
            panelprincipal.Location = new Point(-1, 0);
            panelprincipal.Name = "panelprincipal";
            panelprincipal.Size = new Size(581, 336);
            panelprincipal.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(260, 67);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(136, 203);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 255);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(99, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ver Tabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxnum
            // 
            textBoxnum.Location = new Point(97, 134);
            textBoxnum.Name = "textBoxnum";
            textBoxnum.Size = new Size(100, 23);
            textBoxnum.TabIndex = 2;
            // 
            // labelnumero
            // 
            labelnumero.AutoSize = true;
            labelnumero.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelnumero.Location = new Point(88, 82);
            labelnumero.Name = "labelnumero";
            labelnumero.Size = new Size(140, 16);
            labelnumero.TabIndex = 1;
            labelnumero.Text = "¿Cual tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labeltitulo.Location = new Point(81, 35);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(174, 21);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de Multiplicar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 296);
            label1.Name = "label1";
            label1.Size = new Size(194, 19);
            label1.TabIndex = 5;
            label1.Text = "Frida Sofia Martinez Gallegos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 333);
            Controls.Add(panelprincipal);
            Name = "Form1";
            Text = "Form1";
            panelprincipal.ResumeLayout(false);
            panelprincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelprincipal;
        private Label labeltitulo;
        private TextBox textBoxnum;
        private Label labelnumero;
        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}
