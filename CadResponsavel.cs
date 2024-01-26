
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
    public partial class CadResponsavel : Form
    {
        private static List<Responsavel> lista = new List<Responsavel>();

        private static Responsavel? responsavelBusca = null;
        public CadResponsavel()
        {
            InitializeComponent();
            if (lista.Count == 0)
            {
                lista = Serializa.loadResponsavel();
                if (lista == null)
                {
                    lista = new List<Responsavel>();
                }
                dataRelatorio(lista);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (txNome.Text.Trim() == "")
            {
                MessageBox.Show("Nome do responsável é obrigatório!");
                txNome.Focus();
                return;
            }
            if (txTipo.Text.Trim() == "")
            {
                MessageBox.Show("Tipo do responsável é obrigatório!");
                txTipo.Focus();
                return;
            }

            if (responsavelBusca != null)
            {
                responsavelBusca.Nome = txNome.Text;
                responsavelBusca.Tipo = txTipo.Text.ToCharArray()[0];
                responsavelBusca.Telefone = txTelefone.Text;
                Serializa.saveResponsavel(lista);
                dataRelatorio(lista);
                btLimpar_Click(sender, e);
                return;
            }

            if (txEmail.Text.Trim() == String.Empty)
            {
                MessageBox.Show("E-mail do responsável é obrigatório!");
                txEmail.Focus();
                return;
            }

            Responsavel r = new Responsavel(txNome.Text,
                                            txTipo.Text.ToCharArray()[0],
                                            txEmail.Text,
                                            txTelefone.Text);
            lista.Add(r);

            Serializa.saveResponsavel(lista);
            dataRelatorio(lista);

            btLimpar_Click(sender, e);
        }

        private void dataRelatorio(List<Responsavel> lista)
        {
            tbRelatorio.Columns.Clear();
            tbRelatorio.ColumnCount = 4;

            tbRelatorio.Columns[0].HeaderText = "Nome";
            tbRelatorio.Columns[0].Width = 200;
            tbRelatorio.Columns[1].HeaderText = "Tipo";
            tbRelatorio.Columns[1].Width = 50;
            tbRelatorio.Columns[2].HeaderText = "E-mail";
            tbRelatorio.Columns[2].Width = 200;
            tbRelatorio.Columns[3].HeaderText = "Telefone";
            tbRelatorio.Columns[3].Width = 1000;

            if (lista.Count == 0) return;

            tbRelatorio.RowCount = lista.Count;
            lista.Sort();

            int i = 0;
            foreach (Responsavel l in lista)
            {
                tbRelatorio.Rows[i].Cells[0].Value = l.Nome;
                tbRelatorio.Rows[i].Cells[1].Value = l.Tipo;
                tbRelatorio.Rows[i].Cells[2].Value = l.E_Mail;
                tbRelatorio.Rows[i].Cells[3].Value = l.Telefone;
                i++;
            }
        }

        private void CadResponsavel_Load(object sender, EventArgs e)
        {
            if (lista.Count == 0)
            {
                lista = Serializa.loadResponsavel();
                if (lista == null)
                {
                    lista = new List<Responsavel>();
                }
            }
        }

        private void tbRelatorio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (txBuscar.Text.Trim() == "")
            {
                MessageBox.Show("Digite o email para busca");
                txBuscar.Focus();
                return;
            }

            Responsavel r = new Responsavel("", ' ', txBuscar.Text, "");

            int indice = lista.BinarySearch(r);

            if (indice == -1)
            {
                MessageBox.Show("Email não encontrado!");
                return;
            }

            responsavelBusca = lista[indice];

            txNome.Text = responsavelBusca.Nome;
            txEmail.Text = responsavelBusca.E_Mail;
            txTelefone.Text = responsavelBusca.Telefone;
            txTipo.Text = responsavelBusca.Tipo.ToString();

            btExcluir.Enabled = true;

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            txBuscar.Text =
                txEmail.Text =
                txNome.Text =
                txTelefone.Text =
                txTipo.Text = String.Empty;
            responsavelBusca = null;
            btExcluir.Enabled = false;
        }


        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (responsavelBusca == null)
            {
                MessageBox.Show("Erro inesperado, nome nao encontrado");
                return;
            }
            lista.Remove(responsavelBusca);

            Serializa.saveResponsavel(lista);
            dataRelatorio(lista);
            btLimpar_Click(btLimpar, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadResponsavel cadResponsavelForm = new CadResponsavel();
            cadResponsavelForm.Show();
        }


    }
}
