namespace prjFluxoCaixa
{
    partial class CadResponsavel
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
            lbTitulo = new Label();
            lbNome = new Label();
            txNome = new TextBox();
            txTipo = new TextBox();
            lbTipo = new Label();
            txEmail = new TextBox();
            lbEmail = new Label();
            txTelefone = new TextBox();
            lbTelefone = new Label();
            txBuscar = new TextBox();
            lbBuscar = new Label();
            btBuscar = new Button();
            btLimpar = new Button();
            btExcluir = new Button();
            btSalvar = new Button();
            tbRelatorio = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbRelatorio).BeginInit();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitulo.ForeColor = Color.Brown;
            lbTitulo.Location = new Point(170, 9);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(349, 37);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "Cadastro de Responsáveis";
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(12, 57);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(40, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome";
            // 
            // txNome
            // 
            txNome.Location = new Point(12, 75);
            txNome.Name = "txNome";
            txNome.Size = new Size(263, 23);
            txNome.TabIndex = 2;
            // 
            // txTipo
            // 
            txTipo.Location = new Point(12, 124);
            txTipo.Name = "txTipo";
            txTipo.Size = new Size(263, 23);
            txTipo.TabIndex = 4;
            // 
            // lbTipo
            // 
            lbTipo.AutoSize = true;
            lbTipo.Location = new Point(12, 106);
            lbTipo.Name = "lbTipo";
            lbTipo.Size = new Size(30, 15);
            lbTipo.TabIndex = 3;
            lbTipo.Text = "Tipo";
            // 
            // txEmail
            // 
            txEmail.Location = new Point(12, 179);
            txEmail.Name = "txEmail";
            txEmail.Size = new Size(263, 23);
            txEmail.TabIndex = 6;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(12, 161);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(41, 15);
            lbEmail.TabIndex = 5;
            lbEmail.Text = "E-mail";
            // 
            // txTelefone
            // 
            txTelefone.Location = new Point(12, 228);
            txTelefone.Name = "txTelefone";
            txTelefone.Size = new Size(263, 23);
            txTelefone.TabIndex = 8;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.Location = new Point(12, 210);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(51, 15);
            lbTelefone.TabIndex = 7;
            lbTelefone.Text = "Telefone";
            // 
            // txBuscar
            // 
            txBuscar.Location = new Point(349, 98);
            txBuscar.Name = "txBuscar";
            txBuscar.Size = new Size(263, 23);
            txBuscar.TabIndex = 10;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Location = new Point(349, 66);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(87, 15);
            lbBuscar.TabIndex = 9;
            lbBuscar.Text = "Buscar (E-mail)";
            // 
            // btBuscar
            // 
            btBuscar.Location = new Point(588, 178);
            btBuscar.Name = "btBuscar";
            btBuscar.Size = new Size(75, 23);
            btBuscar.TabIndex = 11;
            btBuscar.Text = "Buscar";
            btBuscar.UseVisualStyleBackColor = true;
            btBuscar.Click += btBuscar_Click;
            // 
            // btLimpar
            // 
            btLimpar.Location = new Point(502, 179);
            btLimpar.Name = "btLimpar";
            btLimpar.Size = new Size(75, 23);
            btLimpar.TabIndex = 12;
            btLimpar.Text = "Limpar";
            btLimpar.UseVisualStyleBackColor = true;
            btLimpar.Click += btLimpar_Click;
            // 
            // btExcluir
            // 
            btExcluir.Enabled = false;
            btExcluir.Location = new Point(412, 178);
            btExcluir.Name = "btExcluir";
            btExcluir.Size = new Size(75, 23);
            btExcluir.TabIndex = 13;
            btExcluir.Text = "Excluir";
            btExcluir.UseVisualStyleBackColor = true;
            btExcluir.Click += btExcluir_Click;
            // 
            // btSalvar
            // 
            btSalvar.Location = new Point(331, 178);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(75, 23);
            btSalvar.TabIndex = 14;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = true;
            btSalvar.Click += btSalvar_Click;
            // 
            // tbRelatorio
            // 
            tbRelatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbRelatorio.Location = new Point(12, 271);
            tbRelatorio.Name = "tbRelatorio";
            tbRelatorio.RowTemplate.Height = 25;
            tbRelatorio.Size = new Size(614, 193);
            tbRelatorio.TabIndex = 15;
            tbRelatorio.CellContentClick += tbRelatorio_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 161);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 5;
            label1.Text = "E-mail";
            // 
            // CadResponsavel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(675, 476);
            Controls.Add(tbRelatorio);
            Controls.Add(btSalvar);
            Controls.Add(btExcluir);
            Controls.Add(btLimpar);
            Controls.Add(btBuscar);
            Controls.Add(txBuscar);
            Controls.Add(lbBuscar);
            Controls.Add(txTelefone);
            Controls.Add(lbTelefone);
            Controls.Add(label1);
            Controls.Add(txEmail);
            Controls.Add(lbEmail);
            Controls.Add(txTipo);
            Controls.Add(lbTipo);
            Controls.Add(txNome);
            Controls.Add(lbNome);
            Controls.Add(lbTitulo);
            Name = "CadResponsavel";
            Text = "CadResponsavel";
            Load += CadResponsavel_Load;
            ((System.ComponentModel.ISupportInitialize)tbRelatorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbNome;
        private TextBox txNome;
        private TextBox txTipo;
        private Label lbTipo;
        private TextBox txEmail;
        private Label lbEmail;
        private TextBox txTelefone;
        private Label lbTelefone;
        private TextBox txBuscar;
        private Label lbBuscar;
        private Button btBuscar;
        private Button btLimpar;
        private Button btExcluir;
        private Button btSalvar;
        private DataGridView tbRelatorio;
        private Label label1;
    }
}