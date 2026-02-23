using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriandoCalculadora
{
    public partial class Form1 : Form
    {
        public decimal Resultado { get; set; }
        public decimal valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApagarTudo_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text = "";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
           
            valor = Convert.ToDecimal(txtInserirNumero.Text);
            OperacaoSelecionada = Operacao.Divisao;
            txtInserirNumero.Text = "";
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
          
            valor = Convert.ToDecimal(txtInserirNumero.Text);
            OperacaoSelecionada = Operacao.Multiplicacao;
            txtInserirNumero.Text = "";
            
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
           
            valor = Convert.ToDecimal(txtInserirNumero.Text);
            OperacaoSelecionada = Operacao.Subtracao;
            txtInserirNumero.Text = "";
            
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
           
            valor = Convert.ToDecimal(txtInserirNumero.Text);
            OperacaoSelecionada = Operacao.Adicao;
            txtInserirNumero.Text = "";
           
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            Decimal valor2 =
           Convert.ToDecimal(txtInserirNumero.Text);
            decimal resultadoPorcentagem = (valor * valor2) / 100;
            txtInserirNumero.Text = Convert.ToString(resultadoPorcentagem);

        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "1";
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "6";
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "7";
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "8";
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "9";
        }

        private void s_Click(object sender, EventArgs e)
        {
            txtInserirNumero.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
                {
                case Operacao.Adicao:
                    Resultado = valor + Convert.ToDecimal(txtInserirNumero.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = valor - Convert.ToDecimal(txtInserirNumero.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = valor / Convert.ToDecimal(txtInserirNumero.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = valor * Convert.ToDecimal(txtInserirNumero.Text);
                    break;
            }
            txtInserirNumero.Text = Convert.ToString(Resultado);
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtInserirNumero.Text.Contains(","))
                txtInserirNumero.Text = ",";
        }
    }
}
