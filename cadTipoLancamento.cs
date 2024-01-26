using prjFluxoCaixa.Classes.ClassesDoLivroCaixa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFluxoCaixa
{
    public partial class cadTipoLancamento : Form
    {
        private TipoDeLancamento ?TipoBusca = null;

        private static List<TipoDeLancamento> listTipoLancamento = new List<TipoDeLancamento>();
        public cadTipoLancamento()
        {
            InitializeComponent();
            if (listTipoLancamento.Count == 0)
            {
                listTipoLancamento = Serializa.loadTipoLancamento();
                if (listTipoLancamento == null)
                {
                    listTipoLancamento = new List<TipoDeLancamento>();
                }
                dataRelatorio(listTipoLancamento);
            }
        }

        private void dataRelatorio(List<TipoDeLancamento> lista)
        {

            tbRelatorio.Columns.Clear();
            tbRelatorio.ColumnCount = 2;
            tbRelatorio.Columns[0].HeaderText = "Sigla";
            tbRelatorio.Columns[0].Width = 50;
            tbRelatorio.Columns[1].HeaderText = "Descrição";
            tbRelatorio.Columns[1].Width = 250;

            if (lista.Count == 0) return;

            tbRelatorio.RowCount = lista.Count;
            lista.Sort();

            int i = 0;
            foreach (TipoDeLancamento l in lista)
            {
                tbRelatorio.Rows[i].Cells[0].Value = l.sigla;
                tbRelatorio.Rows[i].Cells[1].Value = l.descricao;
                i++;
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txDescricao.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Descrição não pode estar vazia!");
                return;
            }

            if (TipoBusca != null)
            {
                TipoBusca.descricao = txDescricao.Text;
                Serializa.saveTipoLancamento(listTipoLancamento);
                dataRelatorio(listTipoLancamento);
                btLimpar_Click(btLimpar, e);
                return;

            }

            if (txSigla.Text.Trim().Length != 3)
            {
                MessageBox.Show("Sigla deve ter 3 dígitos!");
                return;
            }

            txSigla.Text = txSigla.Text.ToUpper();

            TipoDeLancamento t = new TipoDeLancamento(txDescricao.Text,txSigla.Text);

            int indice = listTipoLancamento.BinarySearch(t);

            if (indice >= 0)
            {
                MessageBox.Show("Já existe um Tipo com esta sigla já cadastrado!");
                return;
            }

            listTipoLancamento.Add(t);
            Serializa.saveTipoLancamento(listTipoLancamento);
            dataRelatorio(listTipoLancamento);
            btLimpar_Click(btLimpar, e);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (txBuscarSigla.Text.Trim().Length != 3)
            {
                MessageBox.Show("Sigla deve ter 3 dígitos!");
                return;
            }

            TipoDeLancamento t = new TipoDeLancamento("", txBuscarSigla.Text.ToUpper());

            int indice = listTipoLancamento.BinarySearch(t);

            if (indice < 0)
            {
                MessageBox.Show("Nenhum Tipo cadastrado com esta sigla! ");
                return;
            }

            TipoBusca = listTipoLancamento[indice];
            btExcluir.Enabled = true;

            txDescricao.Text = TipoBusca.descricao;
            txSigla.Text = TipoBusca.sigla;
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txSigla.Text =
            txBuscarSigla.Text =
            txDescricao.Text = String.Empty;
            btExcluir.Enabled = false;
            TipoBusca = null;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (TipoBusca == null)
            {                
                MessageBox.Show("Erro inesperado. Tipo não selecionado");
                return;                 
            }
            listTipoLancamento.Remove(TipoBusca);

            Serializa.saveTipoLancamento(listTipoLancamento);
            dataRelatorio(listTipoLancamento);
            btLimpar_Click(btLimpar, e);
        }

        private void cadTipoLancamento_Load(object sender, EventArgs e)
        {

        }
    }
}
