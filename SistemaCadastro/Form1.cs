using SistemaCadastro.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();

            comboEstadoCivil.Items.Add("Selecione...");
            comboEstadoCivil.Items.Add("Casado");
            comboEstadoCivil.Items.Add("Divorciado");
            comboEstadoCivil.Items.Add("Solteiro");
            comboEstadoCivil.Items.Add("Viúvo");
            comboEstadoCivil.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            char sexo;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Digite Um Nome Válido!");
                txtNome.Focus();
                return;
            }
            if (txtTelefone.Text == "(  )      -")
            {
                MessageBox.Show("Digite um número de telefone válido!");
                txtTelefone.Focus();
                return;
            }

            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }
            
                pessoas.Add(new Pessoa(
                    txtNome.Text.ToString(),
                    dateNascimento.Value.ToString("d"),
                    comboEstadoCivil.SelectedItem.ToString(),
                    txtTelefone.Text.ToString(),
                    checkCasa.Checked,
                    checkVeiculo.Checked,
                    sexo
                ));
            
            listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                pessoas.RemoveAt(listView.SelectedItems[0].Index);
            }
            catch
            {
                MessageBox.Show("Selecione um item para excluir!");
            }

            
            listar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void listar()
        {

            listView.Items.Clear();
            
            foreach (Pessoa p in pessoas)
            {
                var casa = p.CasaPropia ? "Sim" : "Não";
                var veiculo = p.Veiculo ? "Sim" : "Não";
                ListViewItem item = new ListViewItem{
                    Text = p.Nome,
                    SubItems =
                    {
                        p.DataNascimento,
                        p.EstadoCivil,
                        p.Telefone,
                        casa,
                        veiculo,
                        p.Sexo.ToString()
                    }
                };
                listView.Items.Add(item);
                   
                
            }
        }

        private void table_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
