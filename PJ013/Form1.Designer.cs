namespace PJ013
{
    partial class frmTrianguloABC
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
            this.lblVA = new System.Windows.Forms.Label();
            this.lblVB = new System.Windows.Forms.Label();
            this.lblVC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtVa = new System.Windows.Forms.TextBox();
            this.txtVb = new System.Windows.Forms.TextBox();
            this.txtVc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVA
            // 
            this.lblVA.AutoSize = true;
            this.lblVA.Location = new System.Drawing.Point(499, 80);
            this.lblVA.Name = "lblVA";
            this.lblVA.Size = new System.Drawing.Size(56, 13);
            this.lblVA.TabIndex = 0;
            this.lblVA.Text = "Valor de A";
            // 
            // lblVB
            // 
            this.lblVB.AutoSize = true;
            this.lblVB.Location = new System.Drawing.Point(499, 122);
            this.lblVB.Name = "lblVB";
            this.lblVB.Size = new System.Drawing.Size(56, 13);
            this.lblVB.TabIndex = 1;
            this.lblVB.Text = "Valor de B";
            // 
            // lblVC
            // 
            this.lblVC.AutoSize = true;
            this.lblVC.Location = new System.Drawing.Point(499, 174);
            this.lblVC.Name = "lblVC";
            this.lblVC.Size = new System.Drawing.Size(56, 13);
            this.lblVC.TabIndex = 2;
            this.lblVC.Text = "Valor de C";
            this.lblVC.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado  = ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(626, 244);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(558, 208);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.Calcular);
            // 
            // txtVa
            // 
            this.txtVa.Location = new System.Drawing.Point(558, 79);
            this.txtVa.Name = "txtVa";
            this.txtVa.Size = new System.Drawing.Size(75, 20);
            this.txtVa.TabIndex = 6;
            // 
            // txtVb
            // 
            this.txtVb.Location = new System.Drawing.Point(558, 122);
            this.txtVb.Name = "txtVb";
            this.txtVb.Size = new System.Drawing.Size(75, 20);
            this.txtVb.TabIndex = 7;
            // 
            // txtVc
            // 
            this.txtVc.Location = new System.Drawing.Point(558, 171);
            this.txtVc.Name = "txtVc";
            this.txtVc.Size = new System.Drawing.Size(75, 20);
            this.txtVc.TabIndex = 8;
            // 
            // frmTrianguloABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVc);
            this.Controls.Add(this.txtVb);
            this.Controls.Add(this.txtVa);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblVC);
            this.Controls.Add(this.lblVB);
            this.Controls.Add(this.lblVA);
            this.Name = "frmTrianguloABC";
            this.Text = "TranguloABC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVA;
        private System.Windows.Forms.Label lblVB;
        private System.Windows.Forms.Label lblVC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtVa;
        private System.Windows.Forms.TextBox txtVb;
        private System.Windows.Forms.TextBox txtVc;
    }
}

