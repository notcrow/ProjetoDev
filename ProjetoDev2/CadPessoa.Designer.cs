using System;

namespace ProjetoDev2
{
    partial class CadPessoa
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
            this.BtSalvar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.btFechar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(99, 122);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(120, 34);
            this.BtSalvar.TabIndex = 0;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // txbNome
            // 
            this.txbNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txbNome.Location = new System.Drawing.Point(56, 45);
            this.txbNome.MaxLength = 50;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(434, 20);
            this.txbNome.TabIndex = 1;
            this.txbNome.WordWrap = false;
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(48, 87);
            this.txbCPF.MaxLength = 14;
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(198, 20);
            this.txbCPF.TabIndex = 2;
            this.txbCPF.WordWrap = false;
            this.txbCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressTeclaCPF);
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(284, 87);
            this.txbRG.MaxLength = 11;
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(202, 20);
            this.txbRG.TabIndex = 3;
            this.txbRG.WordWrap = false;
            this.txbRG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressTeclaRG);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 48);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 90);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 5;
            this.lblCPF.Text = "CPF:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(252, 90);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 6;
            this.lblRG.Text = "RG:";
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(271, 122);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(120, 34);
            this.btFechar.TabIndex = 8;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "COD:";
            // 
            // txbID
            // 
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(56, 17);
            this.txbID.MaxLength = 14;
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(75, 20);
            this.txbID.TabIndex = 9;
            this.txbID.WordWrap = false;
            // 
            // CadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 174);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.BtSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadPessoa";
            this.Text = "Cadastro de Pessoas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbCPF;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
    }
}

