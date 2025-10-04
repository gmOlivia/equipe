using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.objeto;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            // validação simples antes de enviar ao banco
            if (string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Informe o produto.");
                txtItem.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Informe o nome.");
                txtnome.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbstatus.Text))
            {
                MessageBox.Show("Selecione o status.");
                cmbstatus.DroppedDown = true;
                return;
            }

            conexao con = new conexao();

            var fin = new financeiro
            {
                produto = txtItem.Text.Trim(),
                data = dateTimePicker1.Value.Date,
                status = cmbstatus.Text,
                nome = txtnome.Text.Trim()
            };

            if (fin.cadastrar(con))
            {
                MessageBox.Show("Cadastrado com sucesso!");
                // opcional: recarregar grid
                // dataGridView1.DataSource = con.obterdados("SELECT * FROM financeiro");
            }
        }

        

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
