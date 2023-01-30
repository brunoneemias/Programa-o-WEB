
namespace Exemplo_OO
{
    partial class FrmConta
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
            this.btnContaCorrente = new System.Windows.Forms.Button();
            this.btnContaPoupanca = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnContaCorrente
            // 
            this.btnContaCorrente.Location = new System.Drawing.Point(102, 27);
            this.btnContaCorrente.Name = "btnContaCorrente";
            this.btnContaCorrente.Size = new System.Drawing.Size(298, 75);
            this.btnContaCorrente.TabIndex = 0;
            this.btnContaCorrente.Text = "Conta Corrente";
            this.btnContaCorrente.UseVisualStyleBackColor = true;
            this.btnContaCorrente.Click += new System.EventHandler(this.btnContaCorrente_Click);
            // 
            // btnContaPoupanca
            // 
            this.btnContaPoupanca.Location = new System.Drawing.Point(102, 124);
            this.btnContaPoupanca.Name = "btnContaPoupanca";
            this.btnContaPoupanca.Size = new System.Drawing.Size(298, 75);
            this.btnContaPoupanca.TabIndex = 1;
            this.btnContaPoupanca.Text = "ContaPoupanca";
            this.btnContaPoupanca.UseVisualStyleBackColor = true;
            this.btnContaPoupanca.Click += new System.EventHandler(this.btnContaPoupanca_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(102, 217);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(298, 75);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 332);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnContaPoupanca);
            this.Controls.Add(this.btnContaCorrente);
            this.Name = "FrmConta";
            this.Text = "Contas - Banco XYZ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContaCorrente;
        private System.Windows.Forms.Button btnContaPoupanca;
        private System.Windows.Forms.Button btnSair;
    }
}

