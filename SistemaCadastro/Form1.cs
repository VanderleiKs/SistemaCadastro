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

            comboEstadoCivil.Items.Add("Solteiro");
            comboEstadoCivil.Items.Add("Casado");
            comboEstadoCivil.Items.Add("Divorciado");
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
                MessageBox.Show("Digite Um Nome Válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }
            if (txtTelefone.Text == "(  )      -")
            {
               MessageBox.Show("Digite um número de telefone válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            MessageBox.Show("Item cadastrado com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLimpar_Click(btnLimpar, EventArgs.Empty);
            listar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                pessoas.RemoveAt(listView.SelectedItems[0].Index);
                MessageBox.Show("Item exluido com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Selecione um item para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            listar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            comboEstadoCivil.SelectedIndex = 0;
            checkCasa.Checked = false;
            checkVeiculo.Checked = false;
            radioM.Checked = false;
            radioF.Checked = false;
            radioO.Checked = false;
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


        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Pessoa pessoa = pessoas.ElementAt(listView.SelectedItems[0].Index);

            //txtNome.Text = pessoa.Nome;
        }
    }
}
