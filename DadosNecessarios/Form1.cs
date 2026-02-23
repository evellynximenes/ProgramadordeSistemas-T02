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
        }
    }
}
  