using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteBrunsker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // fiz a busca somente pelo cód do imóvel
            try
            {
                // conexão com o banco abrir
                MySqlConnection banco = new MySqlConnection("server=localhost;port=3306;User Id=root;database=imoveis;password=vida2807 ");
                banco.Open();

                // comando de select dados no banco
                MySqlCommand cmd = new MySqlCommand("select * from cadastro_imoveis where id = ?", banco); 
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = textCod.Text;

                //executar o comando
                cmd.CommandType = CommandType.Text;

                //pegar os dados que retornou do select
                MySqlDataReader dados;
                dados = cmd.ExecuteReader();
                dados.Read();

                //preencher os campos com os dados
                comboTipo.Text = dados.GetString(1);
                textCEP.Text = dados.GetString(2);
                textEndereco.Text = dados.GetString(3);
                textCidade.Text = dados.GetString(4);
                textUF.Text = dados.GetString(5);
                comboSituacao.Text = dados.GetString(6);
                              
                banco.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Problema" + erro);
            }
        }

        private void buttonRetorno_Click(object sender, EventArgs e)
        {
            //abrir o form1 e ocultar o form3
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            try
            {
                // conexão com o banco abrir
                MySqlConnection banco = new MySqlConnection("server=localhost;port=3306;User Id=root;database=imoveis;password=vida2807 ");
                banco.Open();

                // comando de select dados no banco
                MySqlCommand cmd = new MySqlCommand("update cadastro_imoveis set tipo = ?, cep = ?, endereco = ?, cidade = ?, uf = ?, liberado = ? where id = ?", banco);
                cmd.Parameters.Clear();

                
                cmd.Parameters.Add("@tipo", MySqlDbType.VarChar, 10).Value = comboTipo.SelectedItem.ToString();
                cmd.Parameters.Add("@cep", MySqlDbType.VarChar, 10).Value = textCEP.Text;
                cmd.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = textEndereco.Text;
                cmd.Parameters.Add("@cidade", MySqlDbType.VarChar, 30).Value = textCidade.Text;
                cmd.Parameters.Add("@uf", MySqlDbType.VarChar, 30).Value = textUF.Text;
                cmd.Parameters.Add("@liberado", MySqlDbType.VarChar).Value = comboSituacao.SelectedItem.ToString();         
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = textCod.Text;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro Editado com sucesso!");
                
                LimparDados();

                banco.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("problema" + erro);
            }
            
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //adicionar itens na seleção de tipo de imóvel
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

        public void LimparDados()
        {
            textCod.Clear();
            textCEP.Clear();
            textEndereco.Clear();
            textCidade.Clear();
            textUF.Clear();
            comboSituacao.SelectedIndex = -1;
            comboTipo.SelectedIndex = -1;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                // conexão com o banco abrir
                MySqlConnection banco = new MySqlConnection("server=localhost;port=3306;User Id=root;database=imoveis;password=vida2807 ");
                banco.Open();

                // comando de select dados no banco
                MySqlCommand cmd = new MySqlCommand("delete from cadastro_imoveis where id = ?", banco);
                cmd.Parameters.Clear();
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = textCod.Text;

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro deletado com sucesso!");

                LimparDados();

                banco.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("problema" + erro);
            }
        }
    }
}
