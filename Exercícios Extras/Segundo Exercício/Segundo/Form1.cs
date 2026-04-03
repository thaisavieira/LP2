using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Florianopolis");
            listBox1.Items.Add("Fortaleza");
            listBox1.Items.Add("Rio de Janeiro");
            listBox1.Items.Add("São Paulo");
            listBox1.Items.Add("Pato Branco");

            listBox1.Sorted = true;
            listBox1.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "") // if (textBox1.Text==String.Empty)
            {
                MessageBox.Show("Nome Vazio");
            }
            else
            {
                MessageBox.Show("Nome: " +textBox1.Text);
            }
            if(checkBox1.Checked)
                MessageBox.Show("É estrangeiro");
            else
                MessageBox.Show("Não é estrangeiro");
            if (comboBox1.SelectedIndex == -1)
                MessageBox.Show("Não escolheu cidade de origem");
            else
                MessageBox.Show("Origem: " + comboBox1.SelectedItem);
            MessageBox.Show("Destino: " + listBox1.SelectedItem);
            if (radioButton1.Checked)
                MessageBox.Show("Inclui aluguel de carro");
            else
                MessageBox.Show("Não inclui aluguel de carro");
            string preferencias = "";
            
            for (int i = 0; i< checkedListBox1.CheckedItems.Count;i++)
            {
                preferencias = preferencias + "\n" +
                    checkedListBox1.CheckedItems[i];
            }

            MessageBox.Show(preferencias);

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
