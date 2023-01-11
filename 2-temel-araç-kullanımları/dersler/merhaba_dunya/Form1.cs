using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sistemin bana tanimladigi cok kullanilan kutuphaneler

namespace merhaba_dunya //projemin ismi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            // butona tıklanınca ne olacagini belirleyen kisim buarsi
            MessageBox.Show("Merhaba Dunya.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "sude";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "Sudenur";
            label7.Text = "Senkal";
            label6.Text = "Bilgisayar Muhendisi";
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "bilgisayar muhendisligi";
            label15.Text = textBox1.Text;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label17.Text = textBox2.Text;
            label18.Text = textBox3.Text;
            label19.Text = textBox4.Text;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("antalya");
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox5.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox6.Text);
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox7.Text + ", " + textBox8.Text + ", " + textBox9.Text + ", " + textBox10.Text + ", " + textBox11.Text );
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(maskedTextBox1.Text + ", " + maskedTextBox2.Text + ", " + maskedTextBox3.Text + ", " + maskedTextBox4.Text );
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(dateTimePicker1.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox5.Items.Add(textBox13.Text+ ", "+ textBox12.Text+ ", "+maskedTextBox6.Text+ ", "+ maskedTextBox5.Text+ ", "+ comboBox3.Text+ ", "+dateTimePicker2.Text);
        }
    }
}
