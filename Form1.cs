/*
 * TP de 20/10/2023
 * 
 * Colocar o programa para funcionar;
 * Em um documento word, copiar e colar o fonte do Form1.cs e 
 * capturar a tela com pelo menos 5 lançamentos e colar no documento também;
 * 
 * Enviar para halrangel@yahoo.com.br
 * Assunto: Fluxo-Caixa Nome RA
 * 
 */

using prjFluxoCaixa.Classes.ClassesDoLivroCaixa;
using System.Collections;
using System.Collections.Generic;

namespace prjFluxoCaixa
{
    public partial class frmLivroCaixa : Form
    {
        static private Caixa? caixa;

        static private Responsavel[] res = {
                                            new Responsavel("Hélio Rangel", 'A'),
                                            new Responsavel("Maria Aparecida", 'A'),
                                            new Responsavel("Carlos",'U'),
                                            new Responsavel("José Américo",'U')
        };

        static private
            List<TipoDeLancamento>? listaTipos = new List<TipoDeLancamento>();

        static private List<Responsavel>? listaRes = new List<Responsavel>();



        public frmLivroCaixa()
        {
            InitializeComponent();


        }



        private void Form1_Load(object sender, EventArgs e)
        {

            if (caixa == null)
            {
                caixa = Serializa.loadCaixa();
                if (caixa == null)
                {
                    caixa = new Caixa("Set/2023");
                    Serializa.saveCaixa(caixa);
                }
            }

            listaTipos = Serializa.loadTipoLancamento();
            listaRes = Serializa.loadResponsavel();



            cbTipoLancamento.Items.Clear();
            foreach (TipoDeLancamento t in listaTipos)
            {
                cbTipoLancamento.Items.Add(t.descricao + " (" + t.sigla + ")");
            }



            cbResponsavel.Items.Clear(); // Limpando o combo

            foreach (Responsavel r in listaRes)
            {
                cbResponsavel.Items.Add(r.Nome);
            }

            montaTbRelatorio();
        }


        //"Data: ", Data.ToString("dd/MM/yy"), 
        //", Descrição: ", Descricao, 
        //", C/D: ", Tipo, // Crédito ou Débito
        //", Responsável: ", responsavel.Nome, 
        //", Valor: ", Valor ,
        //", Tipo: ", TipoLancamento.descricao);
        private void montaTbRelatorio()
        {
            tbRelatorio.Rows.Clear();
            tbRelatorio.ColumnCount = 7;

            tbRelatorio.Columns[0].HeaderText = "Data";
            tbRelatorio.Columns[0].Width = 100;

            tbRelatorio.Columns[1].HeaderText = "Descrição";
            tbRelatorio.Columns[1].Width = 200;

            tbRelatorio.Columns[2].HeaderText = "C/D";
            tbRelatorio.Columns[2].Width = 40;


            tbRelatorio.Columns[3].HeaderText = "Responsável";
            tbRelatorio.Columns[3].Width = 150;
            tbRelatorio.Columns[4].HeaderText = "Valor";
            tbRelatorio.Columns[5].HeaderText = "Tipo";
            tbRelatorio.Columns[5].Width = 150;

            tbRelatorio.Columns[6].HeaderText = "Saldo";

            if (caixa != null)
            {
                tbRelatorio.RowCount = caixa.lancamentos.Count;

                float saldo = 0;

                for (int i = 0; i < caixa.lancamentos.Count; i++)
                {
                    saldo += caixa.lancamentos[i].Tipo == 'C' ? caixa.lancamentos[i].Valor : -caixa.lancamentos[i].Valor;
                    tbRelatorio.Rows[i].Cells[0].Value = caixa.lancamentos[i].Data.ToString("dd/MM/yy");
                    tbRelatorio.Rows[i].Cells[1].Value = caixa.lancamentos[i].Descricao;
                    tbRelatorio.Rows[i].Cells[2].Value = caixa.lancamentos[i].Tipo;
                    tbRelatorio.Rows[i].Cells[3].Value = caixa.lancamentos[i].responsavel.Nome;
                    tbRelatorio.Rows[i].Cells[4].Value = caixa.lancamentos[i].Valor.ToString();
                    tbRelatorio.Rows[i].Cells[5].Value = caixa.lancamentos[i].TipoLancamento.descricao;
                    tbRelatorio.Rows[i].Cells[6].Value = saldo.ToString();
                }
            }

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            DateTime data;

            if (caixa == null) return;

            if (!DateTime.TryParse(txData.Text, out data))
            {
                MessageBox.Show("Data digitada deve ser uma data válida!");
                txData.Focus();
                return;
            }

            if (data.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("Data futura é inválida!");
                txData.Focus();
                return;
            }

            if (txDescricao.Text.Trim().Length == 0)
            {
                MessageBox.Show("Descrição do lançamento é obrigatória!");
                txDescricao.Focus();
                return;
            }

            if (cbResponsavel.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o responsável");
                cbResponsavel.Focus();
                return;
            }
            if (cbTipoLancamento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo de lançamento");
                cbTipoLancamento.Focus();
                return;
            }


            if (!rbCredito.Checked && !rbDebito.Checked)
            {
                MessageBox.Show("Selecione se crédito ou débito!");
                return;
            }

            float valor;

            if (!float.TryParse(txValor.Text, out valor) || valor <= 0)
            {
                MessageBox.Show("Valor digitado não é um valor válido!");
                return;
            }


            if (rbDebito.Checked && caixa.saldo() < valor)
            {
                MessageBox.Show("Valor digitado maior que o saldo; Saldo: " + caixa.saldo());
                return;
            }
            String? tipoL = cbTipoLancamento.SelectedItem.ToString();
            TipoDeLancamento? tipoLa = null;
            foreach (TipoDeLancamento tipo in listaTipos)
            {
                if (tipo.descricao + " (" + tipo.sigla + ")" == tipoL)
                {
                    tipoLa = tipo;
                    break;
                }
            }
            if (tipoLa == null)
            {
                MessageBox.Show("Erro inesperado. Tipo não cadastrado");
                return;
            }

            String? sel = cbResponsavel.SelectedItem.ToString();
            Responsavel? selec = null;
            foreach (Responsavel r in listaRes)
            {
                if (sel == r.Nome)
                {
                    selec = r;
                    break;
                }
            }
            if (selec == null)
            {
                MessageBox.Show("Erro inesperado. Responsável não cadastrado!");
                return;
            }
            Lancamento l = new Lancamento(
                data,
                txDescricao.Text,
                rbCredito.Checked ? 'C' : 'D',
                selec,
                valor,
                tipoLa);

            caixa.Add(l);

            montaTbRelatorio();

            Serializa.saveCaixa(caixa);

            limpa();

        }

        private void limpa()
        {
            txData.Text =
            txDescricao.Text =
            txValor.Text = String.Empty;

            rbCredito.Checked =
            rbDebito.Checked = false;

            cbResponsavel.SelectedIndex = -1;
            cbTipoLancamento.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new CadResponsavel();
            f.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CadResponsavel();
            f.Show();
        }

        private void btCadTipoLancamento_Click(object sender, EventArgs e)
        {
            Form f = new cadTipoLancamento();
            f.Show();
        }

        private void cbResponsavel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}