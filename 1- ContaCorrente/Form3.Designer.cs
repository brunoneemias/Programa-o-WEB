
namespace Exemplo_OO
{
    partial class frmCP
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
            this.txtPercentualRendimento = new System.Windows.Forms.TextBox();
            this.lblPercentualRendimento = new System.Windows.Forms.Label();
            this.btnRendimento = new System.Windows.Forms.Button();
            this.btnAdicionarConta = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.btnSaque = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPercentualRendimento
            // 
            this.txtPercentualRendimento.Location = new System.Drawing.Point(135, 295);
            this.txtPercentualRendimento.Name = "txtPercentualRendimento";
            this.txtPercentualRendimento.Size = new System.Drawing.Size(281, 26);
            this.txtPercentualRendimento.TabIndex = 42;
            // 
            // lblPercentualRendimento
            // 
            this.lblPercentualRendimento.AutoSize = true;
            this.lblPercentualRendimento.Location = new System.Drawing.Point(21, 298);
            this.lblPercentualRendimento.Name = "lblPercentualRendimento";
            this.lblPercentualRendimento.Size = new System.Drawing.Size(118, 20);
            this.lblPercentualRendimento.TabIndex = 41;
            this.lblPercentualRendimento.Text = "% Rendimento:";
            // 
            // btnRendimento
            // 
            this.btnRendimento.Location = new System.Drawing.Point(174, 342);
            this.btnRendimento.Name = "btnRendimento";
            this.btnRendimento.Size = new System.Drawing.Size(129, 42);
            this.btnRendimento.TabIndex = 40;
            this.btnRendimento.Text = "Rendimento";
            this.btnRendimento.UseVisualStyleBackColor = true;
            this.btnRendimento.Click += new System.EventHandler(this.btnRendimento_Click);
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.Location = new System.Drawing.Point(174, 99);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(140, 41);
            this.btnAdicionarConta.TabIndex = 39;
            this.btnAdicionarConta.Text = "Adicionar Conta";
            this.btnAdicionarConta.UseVisualStyleBackColor = true;
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(170, 404);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(54, 20);
            this.lblSaldo.TabIndex = 38;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(135, 179);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(281, 26);
            this.txtValor.TabIndex = 37;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(89, 182);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(50, 20);
            this.lblValor.TabIndex = 36;
            this.lblValor.Text = "Valor:";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(297, 223);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(88, 42);
            this.btnDeposito.TabIndex = 35;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(174, 223);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(88, 42);
            this.btnSaque.TabIndex = 34;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(135, 56);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(415, 26);
            this.txtNomeCliente.TabIndex = 33;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(413, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(137, 26);
            this.txtNumero.TabIndex = 32;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(135, 12);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(127, 26);
            this.txtAgencia.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nome do Cliente:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(278, 15);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(138, 20);
            this.lblNumero.TabIndex = 29;
            this.lblNumero.Text = "Número da Conta:";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(64, 15);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(75, 20);
            this.lblAgencia.TabIndex = 28;
            this.lblAgencia.Text = "Agência: ";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(512, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 32);
            this.btnSair.TabIndex = 43;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 455);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtPercentualRendimento);
            this.Controls.Add(this.lblPercentualRendimento);
            this.Controls.Add(this.btnRendimento);
            this.Controls.Add(this.btnAdicionarConta);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtAgencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblAgencia);
            this.Name = "frmCP";
            this.Text = "Conta Poupança";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPercentualRendimento;
        private System.Windows.Forms.Label lblPercentualRendimento;
        private System.Windows.Forms.Button btnRendimento;
        private System.Windows.Forms.Button btnAdicionarConta;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Button btnSair;
    }
}