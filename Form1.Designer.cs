namespace prjFluxoCaixa
{
    partial class frmLivroCaixa
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
            lbTitulo = new Label();
            lbData = new Label();
            txData = new TextBox();
            lbDescricao = new Label();
            txDescricao = new TextBox();
            rbCredito = new RadioButton();
            rbDebito = new RadioButton();
            cbResponsavel = new ComboBox();
            lbResponsavel = new Label();
            txValor = new TextBox();
            lbValor = new Label();
            btOK = new Button();
            cbTipoLancamento = new ComboBox();
            lbTipolancamento = new Label();
            tbRelatorio = new DataGridView();
            btCadResponsavel = new Button();
            btCadTipoLancamento = new Button();
            ((System.ComponentModel.ISupportInitialize)tbRelatorio).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitulo.ForeColor = Color.Brown;
            lbTitulo.Location = new Point(303, 40);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(234, 42);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Livro Caixa";
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(12, 93);
            lbData.Name = "lbData";
            lbData.Size = new Size(31, 15);
            lbData.TabIndex = 1;
            lbData.Text = "Data";
            // 
            // txData
            // 
            txData.Location = new Point(12, 111);
            txData.Name = "txData";
            txData.Size = new Size(86, 23);
            txData.TabIndex = 2;
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Location = new Point(104, 93);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(58, 15);
            lbDescricao.TabIndex = 3;
            lbDescricao.Text = "Descrição";
            // 
            // txDescricao
            // 
            txDescricao.Location = new Point(104, 111);
            txDescricao.Name = "txDescricao";
            txDescricao.Size = new Size(288, 23);
            txDescricao.TabIndex = 4;
            // 
            // rbCredito
            // 
            rbCredito.AutoSize = true;
            rbCredito.Location = new Point(699, 94);
            rbCredito.Name = "rbCredito";
            rbCredito.Size = new Size(64, 19);
            rbCredito.TabIndex = 5;
            rbCredito.TabStop = true;
            rbCredito.Text = "Crédito";
            rbCredito.UseVisualStyleBackColor = true;
            // 
            // rbDebito
            // 
            rbDebito.AutoSize = true;
            rbDebito.Location = new Point(699, 117);
            rbDebito.Name = "rbDebito";
            rbDebito.Size = new Size(60, 19);
            rbDebito.TabIndex = 6;
            rbDebito.TabStop = true;
            rbDebito.Text = "Débito";
            rbDebito.UseVisualStyleBackColor = true;
            // 
            // cbResponsavel
            // 
            cbResponsavel.FormattingEnabled = true;
            cbResponsavel.Location = new Point(397, 111);
            cbResponsavel.Name = "cbResponsavel";
            cbResponsavel.Size = new Size(121, 23);
            cbResponsavel.TabIndex = 7;
            cbResponsavel.SelectedIndexChanged += cbResponsavel_SelectedIndexChanged;
            // 
            // lbResponsavel
            // 
            lbResponsavel.AutoSize = true;
            lbResponsavel.Location = new Point(397, 93);
            lbResponsavel.Name = "lbResponsavel";
            lbResponsavel.Size = new Size(72, 15);
            lbResponsavel.TabIndex = 8;
            lbResponsavel.Text = "Responsável";
            // 
            // txValor
            // 
            txValor.Location = new Point(778, 112);
            txValor.Name = "txValor";
            txValor.Size = new Size(86, 23);
            txValor.TabIndex = 10;
            txValor.TextAlign = HorizontalAlignment.Right;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(778, 94);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 9;
            lbValor.Text = "Valor";
            // 
            // btOK
            // 
            btOK.Location = new Point(882, 111);
            btOK.Name = "btOK";
            btOK.Size = new Size(60, 23);
            btOK.TabIndex = 11;
            btOK.Text = "OK";
            btOK.UseVisualStyleBackColor = true;
            btOK.Click += btOK_Click;
            // 
            // cbTipoLancamento
            // 
            cbTipoLancamento.FormattingEnabled = true;
            cbTipoLancamento.Location = new Point(524, 111);
            cbTipoLancamento.Name = "cbTipoLancamento";
            cbTipoLancamento.Size = new Size(156, 23);
            cbTipoLancamento.TabIndex = 13;
            // 
            // lbTipolancamento
            // 
            lbTipolancamento.AutoSize = true;
            lbTipolancamento.Location = new Point(524, 93);
            lbTipolancamento.Name = "lbTipolancamento";
            lbTipolancamento.Size = new Size(99, 15);
            lbTipolancamento.TabIndex = 14;
            lbTipolancamento.Text = "Tipo Lancamento";
            // 
            // tbRelatorio
            // 
            tbRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbRelatorio.Location = new Point(12, 156);
            tbRelatorio.Name = "tbRelatorio";
            tbRelatorio.ReadOnly = true;
            tbRelatorio.RowTemplate.Height = 25;
            tbRelatorio.Size = new Size(930, 282);
            tbRelatorio.TabIndex = 15;
            // 
            // btCadResponsavel
            // 
            btCadResponsavel.Location = new Point(0, 3);
            btCadResponsavel.Name = "btCadResponsavel";
            btCadResponsavel.Size = new Size(150, 23);
            btCadResponsavel.TabIndex = 16;
            btCadResponsavel.Text = "Cadastro de Responsavel";
            btCadResponsavel.UseVisualStyleBackColor = true;
            btCadResponsavel.Click += button1_Click;
            // 
            // btCadTipoLancamento
            // 
            btCadTipoLancamento.Location = new Point(156, 3);
            btCadTipoLancamento.Name = "btCadTipoLancamento";
            btCadTipoLancamento.Size = new Size(150, 23);
            btCadTipoLancamento.TabIndex = 17;
            btCadTipoLancamento.Text = "Cadastro de Tipo";
            btCadTipoLancamento.UseVisualStyleBackColor = true;
            btCadTipoLancamento.Click += btCadTipoLancamento_Click;
            // 
            // frmLivroCaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(956, 450);
            Controls.Add(btCadTipoLancamento);
            Controls.Add(btCadResponsavel);
            Controls.Add(tbRelatorio);
            Controls.Add(lbTipolancamento);
            Controls.Add(cbTipoLancamento);
            Controls.Add(btOK);
            Controls.Add(txValor);
            Controls.Add(lbValor);
            Controls.Add(lbResponsavel);
            Controls.Add(cbResponsavel);
            Controls.Add(rbDebito);
            Controls.Add(rbCredito);
            Controls.Add(txDescricao);
            Controls.Add(lbDescricao);
            Controls.Add(txData);
            Controls.Add(lbData);
            Controls.Add(lbTitulo);
            Name = "frmLivroCaixa";
            Text = "Livro Caixa Santa Cecilia";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tbRelatorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbData;
        private TextBox txData;
        private Label lbDescricao;
        private TextBox txDescricao;
        private RadioButton rbCredito;
        private RadioButton rbDebito;
        private ComboBox cbResponsavel;
        private Label lbResponsavel;
        private TextBox txValor;
        private Label lbValor;
        private Button btOK;
        private ComboBox cbTipoLancamento;
        private Label lbTipolancamento;
        private DataGridView tbRelatorio;
        private Button btCadResponsavel;
        private Button btCadTipoLancamento;
    }
}