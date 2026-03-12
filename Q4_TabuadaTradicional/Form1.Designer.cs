namespace Q4_TabuadaTradicional
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
            txtNumero = new TextBox();
            bntGerar = new Button();
            lstTabuada = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 35);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Coloque um Numero:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(75, 64);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(79, 23);
            txtNumero.TabIndex = 1;
            // 
            // bntGerar
            // 
            bntGerar.Location = new Point(75, 109);
            bntGerar.Name = "bntGerar";
            bntGerar.Size = new Size(79, 23);
            bntGerar.TabIndex = 2;
            bntGerar.Text = "Gerar ";
            bntGerar.UseVisualStyleBackColor = true;
            bntGerar.Click += button1_Click;
            // 
            // lstTabuada
            // 
            lstTabuada.FormattingEnabled = true;
            lstTabuada.ItemHeight = 15;
            lstTabuada.Location = new Point(50, 159);
            lstTabuada.Name = "lstTabuada";
            lstTabuada.Size = new Size(132, 244);
            lstTabuada.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(241, 450);
            Controls.Add(lstTabuada);
            Controls.Add(bntGerar);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tabuada Tradicional";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button bntGerar;
        private ListBox lstTabuada;
    }
}
