namespace CalcularIMC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxbNum1 = new System.Windows.Forms.TextBox();
            this.txbNum2 = new System.Windows.Forms.TextBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblPeso = new System.Windows.Forms.Label();
            this.LblAltura = new System.Windows.Forms.Label();
            this.LblImc = new System.Windows.Forms.Label();
            this.LblResultado = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(119, 220);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(165, 63);
            this.BtnCalcular.TabIndex = 0;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxbNum1
            // 
            this.TxbNum1.Location = new System.Drawing.Point(119, 121);
            this.TxbNum1.Name = "TxbNum1";
            this.TxbNum1.Size = new System.Drawing.Size(165, 20);
            this.TxbNum1.TabIndex = 1;
            this.TxbNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbNum2
            // 
            this.txbNum2.Location = new System.Drawing.Point(119, 176);
            this.txbNum2.Name = "txbNum2";
            this.txbNum2.Size = new System.Drawing.Size(165, 20);
            this.txbNum2.TabIndex = 2;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(85, 54);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(228, 31);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Calcule seu IMC";
            // 
            // LblPeso
            // 
            this.LblPeso.AutoSize = true;
            this.LblPeso.Location = new System.Drawing.Point(78, 124);
            this.LblPeso.Name = "LblPeso";
            this.LblPeso.Size = new System.Drawing.Size(31, 13);
            this.LblPeso.TabIndex = 4;
            this.LblPeso.Text = "Peso";
            this.LblPeso.Click += new System.EventHandler(this.LblPeso_Click);
            // 
            // LblAltura
            // 
            this.LblAltura.AutoSize = true;
            this.LblAltura.Location = new System.Drawing.Point(79, 179);
            this.LblAltura.Name = "LblAltura";
            this.LblAltura.Size = new System.Drawing.Size(34, 13);
            this.LblAltura.TabIndex = 5;
            this.LblAltura.Text = "Altura";
            // 
            // LblImc
            // 
            this.LblImc.AutoSize = true;
            this.LblImc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImc.Location = new System.Drawing.Point(78, 316);
            this.LblImc.Name = "LblImc";
            this.LblImc.Size = new System.Drawing.Size(38, 18);
            this.LblImc.TabIndex = 6;
            this.LblImc.Text = "IMC";
            // 
            // LblResultado
            // 
            this.LblResultado.AutoSize = true;
            this.LblResultado.Location = new System.Drawing.Point(151, 320);
            this.LblResultado.Name = "LblResultado";
            this.LblResultado.Size = new System.Drawing.Size(0, 13);
            this.LblResultado.TabIndex = 8;
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(88, 357);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(0, 13);
            this.LblEstado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 404);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblResultado);
            this.Controls.Add(this.LblImc);
            this.Controls.Add(this.LblAltura);
            this.Controls.Add(this.LblPeso);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.txbNum2);
            this.Controls.Add(this.TxbNum1);
            this.Controls.Add(this.BtnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxbNum1;
        private System.Windows.Forms.TextBox txbNum2;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblPeso;
        private System.Windows.Forms.Label LblAltura;
        private System.Windows.Forms.Label LblImc;
        private System.Windows.Forms.Label LblResultado;
        private System.Windows.Forms.Label LblEstado;
    }
}

