namespace ProjetoDev2
{
    partial class Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            this.lblP_ID = new System.Windows.Forms.Label();
            this.lblP_CPF = new System.Windows.Forms.Label();
            this.lblP_Nome = new System.Windows.Forms.Label();
            this.lblP_RG = new System.Windows.Forms.Label();
            this.txbP_IDCliente = new System.Windows.Forms.TextBox();
            this.txbP_CPF = new System.Windows.Forms.TextBox();
            this.txbP_RG = new System.Windows.Forms.TextBox();
            this.txbP_Razao = new System.Windows.Forms.TextBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btInserir = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btExluir = new System.Windows.Forms.Button();
            this.gridPesqPessoas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblP_ID
            // 
            resources.ApplyResources(this.lblP_ID, "lblP_ID");
            this.lblP_ID.Name = "lblP_ID";
            // 
            // lblP_CPF
            // 
            resources.ApplyResources(this.lblP_CPF, "lblP_CPF");
            this.lblP_CPF.Name = "lblP_CPF";
            // 
            // lblP_Nome
            // 
            resources.ApplyResources(this.lblP_Nome, "lblP_Nome");
            this.lblP_Nome.Name = "lblP_Nome";
            // 
            // lblP_RG
            // 
            resources.ApplyResources(this.lblP_RG, "lblP_RG");
            this.lblP_RG.Name = "lblP_RG";
            // 
            // txbP_IDCliente
            // 
            this.txbP_IDCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txbP_IDCliente, "txbP_IDCliente");
            this.txbP_IDCliente.Name = "txbP_IDCliente";
            this.txbP_IDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressTeclaCod);
            // 
            // txbP_CPF
            // 
            this.txbP_CPF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txbP_CPF, "txbP_CPF");
            this.txbP_CPF.Name = "txbP_CPF";
            this.txbP_CPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressTeclaCPF);
            // 
            // txbP_RG
            // 
            this.txbP_RG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txbP_RG, "txbP_RG");
            this.txbP_RG.Name = "txbP_RG";
            this.txbP_RG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressTeclaRG);
            // 
            // txbP_Razao
            // 
            this.txbP_Razao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.txbP_Razao, "txbP_Razao");
            this.txbP_Razao.Name = "txbP_Razao";
            // 
            // btPesquisar
            // 
            resources.ApplyResources(this.btPesquisar, "btPesquisar");
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Controls.Add(this.txbP_Razao);
            this.panel1.Controls.Add(this.txbP_RG);
            this.panel1.Controls.Add(this.txbP_CPF);
            this.panel1.Controls.Add(this.txbP_IDCliente);
            this.panel1.Controls.Add(this.lblP_RG);
            this.panel1.Controls.Add(this.lblP_Nome);
            this.panel1.Controls.Add(this.lblP_CPF);
            this.panel1.Controls.Add(this.lblP_ID);
            this.panel1.Name = "panel1";
            // 
            // btInserir
            // 
            resources.ApplyResources(this.btInserir, "btInserir");
            this.btInserir.Name = "btInserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btEditar
            // 
            resources.ApplyResources(this.btEditar, "btEditar");
            this.btEditar.Name = "btEditar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExluir
            // 
            resources.ApplyResources(this.btExluir, "btExluir");
            this.btExluir.Name = "btExluir";
            this.btExluir.UseVisualStyleBackColor = true;
            this.btExluir.Click += new System.EventHandler(this.btExluir_Click);
            // 
            // gridPesqPessoas
            // 
            this.gridPesqPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridPesqPessoas.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridPesqPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.gridPesqPessoas, "gridPesqPessoas");
            this.gridPesqPessoas.MultiSelect = false;
            this.gridPesqPessoas.Name = "gridPesqPessoas";
            this.gridPesqPessoas.ReadOnly = true;
            // 
            // Pesquisar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridPesqPessoas);
            this.Controls.Add(this.btExluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pesquisar";
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesqPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblP_ID;
        private System.Windows.Forms.Label lblP_CPF;
        private System.Windows.Forms.Label lblP_Nome;
        private System.Windows.Forms.Label lblP_RG;
        private System.Windows.Forms.TextBox txbP_IDCliente;
        private System.Windows.Forms.TextBox txbP_CPF;
        private System.Windows.Forms.TextBox txbP_RG;
        private System.Windows.Forms.TextBox txbP_Razao;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btExluir;
        private System.Windows.Forms.DataGridView gridPesqPessoas;
    }
}