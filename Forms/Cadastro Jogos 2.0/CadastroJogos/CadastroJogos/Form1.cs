using CadjogosWF.Models;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroJogos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ValidaJogo(JogosViewModel a)
        {
            if (a.Id < 0)
                throw new Exception("Id não pode ser negativo!");
            if (string.IsNullOrEmpty(a.Nome))
                throw new Exception("Informe o nome!");
            if (a.Valor_Locacao < 0)
                throw new Exception("ValorLocacao não pode ser negativa!");
            if (a.CPU_ID <= 0)
                throw new Exception("Código da cidade não ser negativo!");
            if (a.Data_Aquisicao > DateTime.Now)
                throw new Exception("Data de nascimento inválida!");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                JogosViewModel a = new JogosViewModel();
                a.Id = Convert.ToInt32(txtCodigo.Text);
                a.Nome = txtNome.Text;
                a.CPU_ID = Convert.ToInt32(txtCPUID.Text);
                a.Data_Aquisicao = Convert.ToDateTime(txtDataAquisicao.Text);
                a.Valor_Locacao = Convert.ToDouble(txtValorLocacao.Text);

                ValidaJogo(a);

                JogosDAO dao = new JogosDAO();
                dao.InserirJogos(a);
            }
            catch (Exception erro)
            {
                if (erro is FormatException)
                    MessageBox.Show("Error, apenas números");
                else MessageBox.Show(erro.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                JogosViewModel a = new JogosViewModel();
                a.Id = Convert.ToInt32(txtCodigo.Text);
                a.Nome = txtNome.Text;
                a.CPU_ID = Convert.ToInt32(txtCPUID.Text);
                a.Data_Aquisicao = Convert.ToDateTime(txtDataAquisicao.Text);
                a.Valor_Locacao = Convert.ToDouble(txtValorLocacao.Text);
                ValidaJogo(a);
                JogosDAO dao = new JogosDAO();
                dao.AlterarJogos(a);
            }
            catch (Exception erro)
            {
                if (erro is FormatException)
                    MessageBox.Show("Error, apenas números");
                else MessageBox.Show(erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                JogosViewModel a = new JogosViewModel();
                a.Id = Convert.ToInt32(txtCodigo.Text);
                a.Nome = txtNome.Text;
                a.CPU_ID = Convert.ToInt32(txtCPUID.Text);
                a.Data_Aquisicao = Convert.ToDateTime(txtDataAquisicao.Text);
                a.Valor_Locacao = Convert.ToDouble(txtValorLocacao.Text);
                JogosDAO dao = new JogosDAO();
                dao.ExcluirJogos(a.Id);
            }
            catch (Exception erro)
            {
                if (erro is FormatException)
                    MessageBox.Show("Error, apenas números");
                else MessageBox.Show(erro.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                JogosDAO dao = new JogosDAO();
                var lista = dao.ConsultarTodosJogos();
                txtResumo.Clear();
                foreach (var jogos in lista)
                {
                    txtResumo.Text += Environment.NewLine +
                        $"Nome: {jogos.Nome} " +
                        $"Reserva: {jogos.Id} " +
                        $"CPU: {jogos.CPU_ID} " +
                        $"Data de Aquisição: {jogos.Data_Aquisicao.ToShortDateString()} " +
                        $"Valor da Locacao: {jogos.Valor_Locacao.ToString("c")} ";
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
