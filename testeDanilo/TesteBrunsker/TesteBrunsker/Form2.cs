using System;
using System.Windows.Forms;
using Correios;
using MySql.Data.MySqlClient;

namespace TesteBrunsker
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //adicionar itens na seleção de tipos de imóveis
            comboTipo.Items.Add("Casa");
            comboTipo.Items.Add("Apartameto");
            comboTipo.Items.Add("Barracão");
            comboTipo.Items.Add("Lote");

            // adicionar itens na selação de situação
            comboSituacao.Items.Add("Liberado");
            comboSituacao.Items.Add("Oculpado");
            comboSituacao.Items.Add("Inregular");
            comboSituacao.Items.Add("Outros");

        }     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                // conexão com o banco abrir
                MySqlConnection banco = new MySqlConnection("server=localhost;port=3306;User Id=root;database=imoveis;password=vida2807 ");
                banco.Open();

                // comando de inserir os dados no banco
                MySqlCommand cmd = new MySqlCommand("insert into cadastro_imoveis (id, tipo, cep, endereco, cidade, uf, liberado) values(null, ?, ?, ?, ?, ?, ?)", banco);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@tipo", MySqlDbType.VarChar, 10).Value = comboTipo.SelectedItem.ToString();
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = textCEP.Text;
                cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = textEndereco.Text;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 30).Value = textCidade.Text;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 30).Value = textUF.Text;
                cmd.Parameters.Add("@liberado", MySqlDbType.VarChar, 10).Value = comboSituacao.SelectedItem.ToString();

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro efetuado com sucesso!");
                limpar_dodos();
                //fechar conexão com o banco
                banco.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Problema" + erro);
            }
            
            
        }

        private void buttonCEP_Click(object sender, EventArgs e)
        {
            // verificar se o cep está vazio
            if (string.IsNullOrEmpty(textCEP.Text))
            {
                MessageBox.Show("O campo CEP esta vazio, digite um valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //se o cep digitado errado vai retornar o erro
                try
                {
                    //pesquisar o cep via api do Correios
                    CorreiosApi correiosApi = new CorreiosApi();
                    var retornoApi = correiosApi.consultaCEP(textCEP.Text);

                    //se a pesquisa não retornar resultado
                    if (retornoApi is null)
                    {
                        MessageBox.Show("CEP não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    //preencher os dados com o retorno da api
                    textEndereco.Text = retornoApi.end;
                    textCidade.Text = retornoApi.cidade;
                    textUF.Text = retornoApi.uf;
                }
                catch
                {
                    MessageBox.Show("CEP errado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void buttonRetorno_Click(object sender, EventArgs e)
        {
            //acultar o form2 e exibir o form1
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public void limpar_dodos()
        {
            textCEP.Clear();
            textEndereco.Clear();
            textCidade.Clear();
            textUF.Clear();
            comboSituacao.SelectedIndex = -1;
            comboTipo.SelectedIndex = -1;
        }
    }
}
