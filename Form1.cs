using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPedro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Operacoes
        {
            Soma,
            Subtrai,
            Divide,
            Multiplica,
            Nenhuma
        }

        static Operacoes ultimaOperacao = Operacoes.Nenhuma;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonlimpar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonapagar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void buttoncopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }
        private void buttonsoma_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void FazerCalculo(Operacoes ultimaOperacao)
        {

            List<double> ListaDeNumeros = new List<double>();
            switch (ultimaOperacao)
            {
                case Operacoes.Soma:
                    ListaDeNumeros = textBox1.Text.Split('+').Select(double.Parse).ToList();
                    textBox1.Text = (ListaDeNumeros[0] + ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Subtrai:
                    ListaDeNumeros = textBox1.Text.Split('-').Select(double.Parse).ToList();
                    textBox1.Text = (ListaDeNumeros[0] - ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Divide:
                    ListaDeNumeros = textBox1.Text.Split('÷').Select(double.Parse).ToList();
                    textBox1.Text = (ListaDeNumeros[0] / ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Multiplica:
                    ListaDeNumeros = textBox1.Text.Split('×').Select(double.Parse).ToList();
                    textBox1.Text = (ListaDeNumeros[0] * ListaDeNumeros[1]).ToString();
                    break;
                case Operacoes.Nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void buttonponto_Click(object sender, EventArgs e)
        {

        }

        private void buttondivisao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void buttonmultiplicacao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void buttonsubtracao_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacoes.Nenhuma)
            {
                ultimaOperacao = Operacoes.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBox1.Text += (sender as Button).Text;
        }

        private void buttonigual_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacoes.Nenhuma)
            {
                FazerCalculo(ultimaOperacao);
            }
        }

        private void buttonNum_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }
    }
}
