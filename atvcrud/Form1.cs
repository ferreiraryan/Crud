using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvcrud
{
    public partial class cadastroAluno : Form
    {
        public cadastroAluno()
        {
            InitializeComponent();

        }
        ConexaoAluno bd = new ConexaoAluno();
        string tabela = "alunos";

        private void cadastroAluno_Load(object sender, EventArgs e)
        {

            bd.ConectarBD();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string inserir;
            string unidade = rdbBarroca.Checked ? "B" : "F";
            int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
            string turma = cbxTurma.Text;
            int idade;
            if(txtnome.Text != "" && int.TryParse(txtidade.Text, out idade))
            {
                inserir = string.Format($"INSERT INTO {tabela} VALUES(NULL, '{txtnome.Text}', '{idade}', '{unidade}', '{serie}', '{turma}')");
                bd.ExecutarComandos(inserir);
                ExibirDados();
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Informação invalida", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ExibirDados()
        {
            string dados = $"SELECT * FROM {tabela}";
            DataTable dt = bd.ExecutarConsulta(dados);
            DtgAlunos.DataSource = dt.AsDataView();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExibirDados();
            LimpaCampos();
        }

        private void DtgAlunos_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Clique em uma célula para preencher os campos do formulário";
        }

        private void DtgAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblid.Text = DtgAlunos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = DtgAlunos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtidade.Text = DtgAlunos.Rows[e.RowIndex].Cells[2].Value.ToString();
            string unidade = DtgAlunos.Rows[e.RowIndex].Cells[3].Value.ToString();
            string serie = DtgAlunos.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbxTurma.Text = DtgAlunos.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (unidade == "B")
            {
                rdbBarroca.Checked = true;
            }
            else
            {
                rdbFloresta.Checked = true;
            }
            bool s= serie == "1" ? rdbSerie1.Checked = true : serie == "2" ? rdbSerie2.Checked = true : rdbSerie3.Checked = true;


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string excluir;
            if(txtnome.Text != "" && txtidade.Text != "")
            {
                excluir = string.Format($"DELETE FROM {tabela} WHERE id = '{lblid.Text}'");
                int resultado = bd.ExecutarComandos(excluir);
                if(resultado == 1)
                {
                    MessageBox.Show("Dado deletado com sucesso!");
                    ExibirDados();
                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("Erro ao deletar os dados!");
                }
            }
            else
            {
                MessageBox.Show("Informação invalida", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string alterar;
            string unidade = rdbBarroca.Checked ? "B" : "F";
            int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
            string turma = cbxTurma.Text;
            int idade;
            if (txtnome.Text != "" && int.TryParse(txtidade.Text, out idade))
            {
                alterar = string.Format($"UPDATE {tabela} SET nome = '{txtnome.Text}', idade = '{idade}', unidade = '{unidade}', serie = '{serie}', turma = '{turma}' WHERE id = '{lblid.Text}'");
                int resultado = bd.ExecutarComandos(alterar);
                if(resultado == 1)
                {
                    MessageBox.Show("Dado alterado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao alterar os dados");
                }
            }
            else
            {
                MessageBox.Show("Informação invalida", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LimpaCampos()
        {
            lblid.Text = "";
            txtnome.Clear();
            txtidade.Clear();
            rdbBarroca.Checked = false;
            rdbFloresta.Checked = false;
            rdbSerie1.Checked = false;
            rdbSerie2.Checked = false;
            rdbSerie3.Checked = false;
            cbxTurma.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
