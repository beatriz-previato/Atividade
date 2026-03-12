namespace Q3_PassagemPorDistancia
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
            bntCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            txtDistancia = new TextBox();
            txtResultado = new TextBox();
            SuspendLayout();
            // 
            // bntCalcular
            // 
            bntCalcular.Location = new Point(127, 125);
            bntCalcular.Name = "bntCalcular";
            bntCalcular.Size = new Size(75, 23);
            bntCalcular.TabIndex = 0;
            bntCalcular.Text = "Calcular ";
            bntCalcular.UseVisualStyleBackColor = true;
            bntCalcular.Click += bntCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 1;
            label1.Text = "Distância percorrida (km)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 37);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor da passagem";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(25, 74);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 23);
            txtDistancia.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(203, 74);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(342, 180);
            Controls.Add(txtResultado);
            Controls.Add(txtDistancia);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntCalcular);
            Name = "Form1";
            Text = "Preço da passagem por distância";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntCalcular;
        private Label label1;
        private Label label2;
        private TextBox txtDistancia;
        private TextBox txtResultado;
    }
}
