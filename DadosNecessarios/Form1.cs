using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DadosNecessarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numeroCadastro;
            string nomeUsuario;
            DateTime dataNascimento;
            string cidade;
            bool generoF;
            bool generoM;
            bool generoNB;

            //validação de campos obrigatorios
            if (string.IsNullOrWhiteSpace(txtNumeroCadastrado.Text))
            {
                MessageBox.Show("Por favor, preencha o número da cadastro.");
                return; //Interrompe a execução do código caso o campo esteja vazio
            }
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, preencha o nome completo.");
                return; //Interrompe a execução do código caso o campo esteja vazio
            }
            if (comboBoxCidade.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione a cidade.");
                return;
            }              

            if (!rbFeminino.Checked && !rbMasculino.Checked && !rbNaoBinario.Checked)           
            {
                MessageBox.Show("Por favor, selecione o gênero.");
                return;
            }
            
             // Agora, caso todos os campos estejam preenchidos, a validação prossegue 

            numeroCadastro = Convert.ToInt32(txtNumeroCadastrado.Text);
            nomeUsuario = txtNome.Text;
            dataNascimento = data.Value;
            cidade = comboBoxCidade.Text;
            generoF = rbFeminino.Checked;
            generoM = rbMasculino.Checked;
            generoNB = rbNaoBinario.Checked;

            // Formatar data para exibir apenas a data (sem a hora)
            string dataFormatada = dataNascimento.ToString("dd/mm/yyyy");

            //Determinar o gênero selecionado
            string generoSelecionado = "Não informado"; // Caso nenhum gênero seja selecionado

            if (generoF)
                generoSelecionado = "feminino";
            else if (generoM)
                generoSelecionado = "Masculino";
            else
                generoSelecionado = "Não binário";

                //Exibir as informações em MessageBox 

            MessageBox.Show("Número cadastrado:" + numeroCadastro);
            MessageBox.Show("Nome: " + nomeUsuario);
            MessageBox.Show("Data de Nascimento:" +  dataFormatada);
            MessageBox.Show("Cidade:" + cidade);
            MessageBox.Show("Gênero:" + generoSelecionado);
        }

        private void txtNumeroCadastrado_Leave(object sender, EventArgs e)
        {
            txtNumeroCadastrado.Clear();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.Clear();
        }
    }
}
  