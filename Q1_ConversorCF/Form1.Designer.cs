namespace Q1_ConversorCF
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
            txtCelsius = new TextBox();
            bntConverter = new Button();
            txtFah = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 32);
            label1.Name = "label1";
            label1.Size = new Size(135, 30);
            label1.TabIndex = 0;
            label1.Text = "       Coloque aqui a \r\ntemperatura em Celsius:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 47);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 1;
            label2.Text = "Temperatura em Fahrennheit";
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(54, 77);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(100, 23);
            txtCelsius.TabIndex = 2;
            // 
            // bntConverter
            // 
            bntConverter.Location = new Point(168, 119);
            bntConverter.Name = "bntConverter";
            bntConverter.Size = new Size(75, 23);
            bntConverter.TabIndex = 3;
            bntConverter.Text = "Converter";
            bntConverter.UseVisualStyleBackColor = true;
            bntConverter.Click += bntConverter_Click;
            // 
            // txtFah
            // 
            txtFah.Location = new Point(259, 77);
            txtFah.Name = "txtFah";
            txtFah.Size = new Size(100, 23);
            txtFah.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(428, 165);
            Controls.Add(txtFah);
            Controls.Add(bntConverter);
            Controls.Add(txtCelsius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor CF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCelsius;
        private Button bntConverter;
        private TextBox txtFah;
    }
}
