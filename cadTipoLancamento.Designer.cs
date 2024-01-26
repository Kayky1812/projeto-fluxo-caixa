namespace prjFluxoCaixa
{
    partial class cadTipoLancamento
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
            this.lbCadastroTipoLancamento = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.txDescricao = new System.Windows.Forms.TextBox();
            this.lbSigla = new System.Windows.Forms.Label();
            this.txSigla = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txBuscarSigla = new System.Windows.Forms.TextBox();
            this.lbBuscar = new System.Windows.Forms.Label();
            this.tbRelatorio = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCadastroTipoLancamento
            // 
            this.lbCadastroTipoLancamento.AutoSize = true;
            this.lbCadastroTipoLancamento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCadastroTipoLancamento.ForeColor = System.Drawing.Color.Brown;
            this.lbCadastroTipoLancamento.Location = new System.Drawing.Point(102, 25);
            this.lbCadastroTipoLancamento.Name = "lbCadastroTipoLancamento";
            this.lbCadastroTipoLancamento.Size = new System.Drawing.Size(346, 24);
            this.lbCadastroTipoLancamento.TabIndex = 0;
            this.lbCadastroTipoLancamento.Text = "Cadastro de Tipo de Lançamento";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(12, 71);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(58, 15);
            this.lbDescricao.TabIndex = 1;
            this.lbDescricao.Text = "Descrição";
            // 
            // txDescricao
            // 
            this.txDescricao.Location = new System.Drawing.Point(12, 89);
            this.txDescricao.Name = "txDescricao";
            this.txDescricao.Size = new System.Drawing.Size(313, 23);
            this.txDescricao.TabIndex = 2;
            // 
            // lbSigla
            // 
            this.lbSigla.AutoSize = true;
            this.lbSigla.Location = new System.Drawing.Point(10, 120);
            this.lbSigla.Name = "lbSigla";
            this.lbSigla.Size = new System.Drawing.Size(32, 15);
            this.lbSigla.TabIndex = 3;
            this.lbSigla.Text = "Sigla";
            // 
            // txSigla
            // 
            this.txSigla.Location = new System.Drawing.Point(12, 140);
            this.txSigla.Name = "txSigla";
            this.txSigla.Size = new System.Drawing.Size(66, 23);
            this.txSigla.TabIndex = 4;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(442, 179);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(62, 23);
            this.btSalvar.TabIndex = 20;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(442, 150);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(62, 23);
            this.btExcluir.TabIndex = 19;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(442, 121);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(62, 23);
            this.btLimpar.TabIndex = 18;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(442, 89);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(62, 23);
            this.btBuscar.TabIndex = 17;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txBuscarSigla
            // 
            this.txBuscarSigla.Location = new System.Drawing.Point(358, 89);
            this.txBuscarSigla.Name = "txBuscarSigla";
            this.txBuscarSigla.Size = new System.Drawing.Size(66, 23);
            this.txBuscarSigla.TabIndex = 16;
            // 
            // lbBuscar
            // 
            this.lbBuscar.AutoSize = true;
            this.lbBuscar.Location = new System.Drawing.Point(358, 71);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(78, 15);
            this.lbBuscar.TabIndex = 15;
            this.lbBuscar.Text = "Buscar (Sigla)";
            // 
            // tbRelatorio
            // 
            this.tbRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbRelatorio.Location = new System.Drawing.Point(12, 208);
            this.tbRelatorio.Name = "tbRelatorio";
            this.tbRelatorio.RowTemplate.Height = 25;
            this.tbRelatorio.Size = new System.Drawing.Size(492, 144);
            this.tbRelatorio.TabIndex = 21;
            // 
            // cadTipoLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 364);
            this.Controls.Add(this.tbRelatorio);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txBuscarSigla);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.txSigla);
            this.Controls.Add(this.lbSigla);
            this.Controls.Add(this.txDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbCadastroTipoLancamento);
            this.Name = "cadTipoLancamento";
            this.Text = "cadTipoLancamento";
            this.Load += new System.EventHandler(this.cadTipoLancamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbCadastroTipoLancamento;
        private Label lbDescricao;
        private TextBox txDescricao;
        private Label lbSigla;
        private TextBox txSigla;
        private Button btSalvar;
        private Button btExcluir;
        private Button btLimpar;
        private Button btBuscar;
        private TextBox txBuscarSigla;
        private Label lbBuscar;
        private DataGridView tbRelatorio;
    }
}