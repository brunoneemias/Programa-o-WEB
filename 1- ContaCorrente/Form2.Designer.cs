
namespace Exemplo_OO
{
    partial class frmCC
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
            this.txtVlCobracaServico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCobrancaServicos = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdicionarConta
            // 
            this.btnAdicionarConta.Location = new System.Drawing.Point(187, 103);
            this.btnAdicionarConta.Name = "btnAdicionarConta";
            this.btnAdicionarConta.Size = new System.Drawing.Size(140, 41);
            this.btnAdicionarConta.TabIndex = 23;
            this.btnAdicionarConta.Text = "Adicionar Conta";
            this.btnAdicionarConta.UseVisualStyleBackColor = true;
            this.btnAdicionarConta.Click += new System.EventHandler(this.btnAdicionarConta_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(183, 408);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(54, 20);
            this.lblSaldo.TabIndex = 22;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(148, 183);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(281, 26);
            this.txtValor.TabIndex = 21;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(102, 186);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(50, 20);
            this.lblValor.TabIndex = 20;
            this.lblValor.Text = "Valor:";
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(310, 227);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(88, 42);
            this.btnDeposito.TabIndex = 19;
            this.btnDeposito.Text = "Deposito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(187, 227);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(88, 42);
            this.btnSaque.TabIndex = 18;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(148, 60);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(415, 26);
            this.txtNomeCliente.TabIndex = 17;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(426, 16);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(137, 26);
            this.txtNumero.TabIndex = 16;
            // 
            // txtAgencia
            // 
            this.txtAgencia.Location = new System.Drawing.Point(148, 16);
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(127, 26);
            this.txtAgencia.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nome do Cliente:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(291, 19);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(138, 20);
            this.lblNumero.TabIndex = 13;
            this.lblNumero.Text = "Número da Conta:";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(77, 19);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(75, 20);
            this.lblAgencia.TabIndex = 12;
            this.lblAgencia.Text = "Agência: ";
            // 
            // txtVlCobracaServico
            // 
            this.txtVlCobracaServico.Location = new System.Drawing.Point(148, 299);
            this.txtVlCobracaServico.Name = "txtVlCobracaServico";
            this.txtVlCobracaServico.Size = new System.Drawing.Size(281, 26);
            this.txtVlCobracaServico.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Valor:";
            // 
            // btnCobrancaServicos
            // 
            this.btnCobrancaServicos.Location = new System.Drawing.Point(187, 346);
            this.btnCobrancaServicos.Name = "btnCobrancaServicos";
            this.btnCobrancaServicos.Size = new System.Drawing.Size(157, 42);
            this.btnCobrancaServicos.TabIndex = 25;
            this.btnCobrancaServicos.Text = "Cobrança Serviços";
            this.btnCobrancaServicos.UseVisualStyleBackColor = true;
            this.btnCobrancaServicos.Click += new System.EventHandler(this.btnCobrancaServicos_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(515, 420);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(61, 31);
            this.btnSair.TabIndex = 28;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 463);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtVlCobracaServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCobrancaServicos);
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
            this.Name = "frmCC";
            this.Text = "Conta Corrente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtVlCobracaServico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCobrancaServicos;
        private System.Windows.Forms.Button btnSair;
    }
}