using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace acessoDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox_nome.Enabled = false;
            textBox_telefone.Enabled = false;
            comboBox_idade.Enabled = false;
            textBox_nomeResposavel.Enabled = false;
            textBox_email.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

  

        private void Button_reg_Click(object sender, EventArgs e)
        {
            Button_reg.Enabled = false;
            textBox_nome.Enabled = true;
            textBox_telefone.Enabled = true;
            comboBox_idade.Enabled = true;
            textBox_nomeResposavel.Enabled = true;
            textBox_email.Enabled = true;
            Button_foto.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void Button_foto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
       
        }
    }
}



 //string connectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=base;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        


