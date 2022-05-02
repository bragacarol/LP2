namespace Atividade_5
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
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtbxNomeFunc = new System.Windows.Forms.TextBox();
            this.mskbxSalario = new System.Windows.Forms.MaskedTextBox();
            this.cbxFilhos = new System.Windows.Forms.ComboBox();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.gbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasc = new System.Windows.Forms.RadioButton();
            this.rbtnFem = new System.Windows.Forms.RadioButton();
            this.pn1 = new System.Windows.Forms.Panel();
            this.chkbxCasado = new System.Windows.Forms.CheckBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.lblIRPF = new System.Windows.Forms.Label();
            this.lblSalFam = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.txtIRPF = new System.Windows.Forms.TextBox();
            this.txtSalFam = new System.Windows.Forms.TextBox();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.lblDescINSS = new System.Windows.Forms.Label();
            this.lblDescIRPF = new System.Windows.Forms.Label();
            this.txtDescINSS = new System.Windows.Forms.TextBox();
            this.txtDescIRPF = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.gbxSexo.SuspendLayout();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(99, 64);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(93, 13);
            this.lblFuncionario.TabIndex = 0;
            this.lblFuncionario.Text = "Nome Funcionário";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(99, 127);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 13);
            this.lblSalario.TabIndex = 1;
            this.lblSalario.Text = "Salário Bruto";
            // 
            // lblFilhos
            // 
            this.lblFilhos.AutoSize = true;
            this.lblFilhos.Location = new System.Drawing.Point(99, 181);
            this.lblFilhos.Name = "lblFilhos";
            this.lblFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblFilhos.TabIndex = 2;
            this.lblFilhos.Text = "Número de Filhos";
            // 
            // txtbxNomeFunc
            // 
            this.txtbxNomeFunc.Location = new System.Drawing.Point(230, 57);
            this.txtbxNomeFunc.Name = "txtbxNomeFunc";
            this.txtbxNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.txtbxNomeFunc.TabIndex = 3;
            this.txtbxNomeFunc.TextChanged += new System.EventHandler(this.txtbxNomeFunc_TextChanged);
            // 
            // mskbxSalario
            // 
            this.mskbxSalario.Location = new System.Drawing.Point(230, 120);
            this.mskbxSalario.Name = "mskbxSalario";
            this.mskbxSalario.Size = new System.Drawing.Size(100, 20);
            this.mskbxSalario.TabIndex = 4;
            this.mskbxSalario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskbxSalario_MaskInputRejected);
            // 
            // cbxFilhos
            // 
            this.cbxFilhos.FormattingEnabled = true;
            this.cbxFilhos.Location = new System.Drawing.Point(230, 173);
            this.cbxFilhos.Name = "cbxFilhos";
            this.cbxFilhos.Size = new System.Drawing.Size(121, 21);
            this.cbxFilhos.TabIndex = 20;
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(157, 242);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(126, 23);
            this.btnDesconto.TabIndex = 21;
            this.btnDesconto.Text = "Verificar Desconto";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // gbxSexo
            // 
            this.gbxSexo.Controls.Add(this.rbtnMasc);
            this.gbxSexo.Controls.Add(this.rbtnFem);
            this.gbxSexo.Location = new System.Drawing.Point(500, 57);
            this.gbxSexo.Name = "gbxSexo";
            this.gbxSexo.Size = new System.Drawing.Size(200, 100);
            this.gbxSexo.TabIndex = 22;
            this.gbxSexo.TabStop = false;
            this.gbxSexo.Text = "Sexo";
            // 
            // rbtnMasc
            // 
            this.rbtnMasc.AutoSize = true;
            this.rbtnMasc.Location = new System.Drawing.Point(73, 68);
            this.rbtnMasc.Name = "rbtnMasc";
            this.rbtnMasc.Size = new System.Drawing.Size(34, 17);
            this.rbtnMasc.TabIndex = 23;
            this.rbtnMasc.TabStop = true;
            this.rbtnMasc.Text = "M";
            this.rbtnMasc.UseVisualStyleBackColor = true;
            this.rbtnMasc.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnFem
            // 
            this.rbtnFem.AutoSize = true;
            this.rbtnFem.Location = new System.Drawing.Point(73, 33);
            this.rbtnFem.Name = "rbtnFem";
            this.rbtnFem.Size = new System.Drawing.Size(31, 17);
            this.rbtnFem.TabIndex = 23;
            this.rbtnFem.TabStop = true;
            this.rbtnFem.Text = "F";
            this.rbtnFem.UseVisualStyleBackColor = true;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.chkbxCasado);
            this.pn1.Location = new System.Drawing.Point(500, 211);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(200, 100);
            this.pn1.TabIndex = 23;
            // 
            // chkbxCasado
            // 
            this.chkbxCasado.AutoSize = true;
            this.chkbxCasado.Location = new System.Drawing.Point(62, 37);
            this.chkbxCasado.Name = "chkbxCasado";
            this.chkbxCasado.Size = new System.Drawing.Size(62, 17);
            this.chkbxCasado.TabIndex = 0;
            this.chkbxCasado.Text = "Casado";
            this.chkbxCasado.UseVisualStyleBackColor = true;
            // 
            // lblINSS
            // 
            this.lblINSS.AutoSize = true;
            this.lblINSS.Location = new System.Drawing.Point(59, 333);
            this.lblINSS.Name = "lblINSS";
            this.lblINSS.Size = new System.Drawing.Size(75, 13);
            this.lblINSS.TabIndex = 24;
            this.lblINSS.Text = "Alíquota INSS";
            // 
            // lblIRPF
            // 
            this.lblIRPF.AutoSize = true;
            this.lblIRPF.Location = new System.Drawing.Point(60, 377);
            this.lblIRPF.Name = "lblIRPF";
            this.lblIRPF.Size = new System.Drawing.Size(74, 13);
            this.lblIRPF.TabIndex = 25;
            this.lblIRPF.Text = "Alíquota IRPF";
            // 
            // lblSalFam
            // 
            this.lblSalFam.AutoSize = true;
            this.lblSalFam.Location = new System.Drawing.Point(58, 430);
            this.lblSalFam.Name = "lblSalFam";
            this.lblSalFam.Size = new System.Drawing.Size(76, 13);
            this.lblSalFam.TabIndex = 26;
            this.lblSalFam.Text = "Salário Família";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(56, 480);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(78, 13);
            this.lblSalLiq.TabIndex = 27;
            this.lblSalLiq.Text = "Salário Líquido";
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(157, 326);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(100, 20);
            this.txtINSS.TabIndex = 28;
            // 
            // txtIRPF
            // 
            this.txtIRPF.Location = new System.Drawing.Point(157, 370);
            this.txtIRPF.Name = "txtIRPF";
            this.txtIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtIRPF.TabIndex = 29;
            // 
            // txtSalFam
            // 
            this.txtSalFam.Location = new System.Drawing.Point(157, 423);
            this.txtSalFam.Name = "txtSalFam";
            this.txtSalFam.Size = new System.Drawing.Size(100, 20);
            this.txtSalFam.TabIndex = 30;
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Location = new System.Drawing.Point(157, 473);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.Size = new System.Drawing.Size(100, 20);
            this.txtSalLiq.TabIndex = 31;
            // 
            // lblDescINSS
            // 
            this.lblDescINSS.AutoSize = true;
            this.lblDescINSS.Location = new System.Drawing.Point(451, 370);
            this.lblDescINSS.Name = "lblDescINSS";
            this.lblDescINSS.Size = new System.Drawing.Size(81, 13);
            this.lblDescINSS.TabIndex = 32;
            this.lblDescINSS.Text = "Desconto INSS";
            // 
            // lblDescIRPF
            // 
            this.lblDescIRPF.AutoSize = true;
            this.lblDescIRPF.Location = new System.Drawing.Point(452, 430);
            this.lblDescIRPF.Name = "lblDescIRPF";
            this.lblDescIRPF.Size = new System.Drawing.Size(80, 13);
            this.lblDescIRPF.TabIndex = 33;
            this.lblDescIRPF.Text = "Desconto IRPF";
            // 
            // txtDescINSS
            // 
            this.txtDescINSS.Location = new System.Drawing.Point(551, 363);
            this.txtDescINSS.Name = "txtDescINSS";
            this.txtDescINSS.Size = new System.Drawing.Size(100, 20);
            this.txtDescINSS.TabIndex = 34;
            // 
            // txtDescIRPF
            // 
            this.txtDescIRPF.Location = new System.Drawing.Point(551, 423);
            this.txtDescIRPF.Name = "txtDescIRPF";
            this.txtDescIRPF.Size = new System.Drawing.Size(100, 20);
            this.txtDescIRPF.TabIndex = 35;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(438, 490);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(605, 490);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 37;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(60, 284);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(0, 13);
            this.lblMensagem.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtDescIRPF);
            this.Controls.Add(this.txtDescINSS);
            this.Controls.Add(this.lblDescIRPF);
            this.Controls.Add(this.lblDescINSS);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.txtSalFam);
            this.Controls.Add(this.txtIRPF);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFam);
            this.Controls.Add(this.lblIRPF);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.gbxSexo);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.cbxFilhos);
            this.Controls.Add(this.mskbxSalario);
            this.Controls.Add(this.txtbxNomeFunc);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblFuncionario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxSexo.ResumeLayout(false);
            this.gbxSexo.PerformLayout();
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtbxNomeFunc;
        private System.Windows.Forms.MaskedTextBox mskbxSalario;
        private System.Windows.Forms.ComboBox cbxFilhos;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.GroupBox gbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasc;
        private System.Windows.Forms.RadioButton rbtnFem;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.CheckBox chkbxCasado;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.Label lblIRPF;
        private System.Windows.Forms.Label lblSalFam;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.TextBox txtIRPF;
        private System.Windows.Forms.TextBox txtSalFam;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.Label lblDescINSS;
        private System.Windows.Forms.Label lblDescIRPF;
        private System.Windows.Forms.TextBox txtDescINSS;
        private System.Windows.Forms.TextBox txtDescIRPF;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMensagem;
    }
}

