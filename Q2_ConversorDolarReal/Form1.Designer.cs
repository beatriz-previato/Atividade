namespace Q2_ConversorDolarReal
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
            txtCotacao = new TextBox();
            label2 = new Label();
            txtDolares = new TextBox();
            bntConverter = new Button();
            txtResultado = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 33);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 0;
            label1.Text = "Cotação do Dolar:";
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(36, 66);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(100, 23);
            txtCotacao.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(187, 33);
            label2.Name = "label2";
            label2.Size = new Size(159, 15);
            label2.TabIndex = 2;
            label2.Text = "Quantidade em Dólares(US$)";
            // 
            // txtDolares
            // 
            txtDolares.Location = new Point(213, 66);
            txtDolares.Name = "txtDolares";
            txtDolares.Size = new Size(100, 23);
            txtDolares.TabIndex = 3;
            // 
            // bntConverter
            // 
            bntConverter.Location = new Point(61, 124);
            bntConverter.Name = "bntConverter";
            bntConverter.Size = new Size(75, 23);
            bntConverter.TabIndex = 4;
            bntConverter.Text = "Converter";
            bntConverter.UseVisualStyleBackColor = true;
            bntConverter.Click += bntConverter_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(213, 124);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(217, 199);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(380, 195);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(bntConverter);
            Controls.Add(txtDolares);
            Controls.Add(label2);
            Controls.Add(txtCotacao);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor DR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCotacao;
        private Label label2;
        private TextBox txtDolares;
        private Button bntConverter;
        private TextBox txtResultado;
        private Label label3;
    }
}
