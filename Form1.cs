using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible= false;
            listBox1.Visible=false;
            label4.Visible=false;
            button2.Visible=false;
            button1.Enabled=false;
            comboBox1.Text = "Bir işlem seçiniz.";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            string txt = textBox1.Text;
            switch (selected)
            {
                case 0:
                case 1:
                    button1.Enabled = true;
                    groupBox1.Visible = false;
                    break;
                case 2:
                    button1.Enabled = true;
                    groupBox1.Visible = true;
                    label5.Text = "aranacak kelime";
                    label6.Visible = false;
                    textBox3.Visible = false;
                    break;
                case 3:
                    button1.Enabled = true;
                    groupBox1.Visible = true;
                    label5.Text = "aranacak kelime";
                    label6.Visible = false;
                    textBox3.Visible = false;
                    break;
                case 4:
                    groupBox1.Visible = true;
                    label5.Text = "Eski deger";
                    label6.Text = "Yeni deger";
                    label6.Visible = true;
                    textBox2.Visible=true;
                    textBox3.Visible=true;
                    button1.Enabled = true;
                    break;
                case 5:
                    groupBox1.Visible = true;
                    label5.Text = "Baslangic";
                    label6.Visible = false;
                    textBox3.Visible = false;
                    textBox2.Visible = true;
                    button1.Enabled = true;
                    break;
                case 6:
                    groupBox1.Visible = true;
                    label5.Text = "Baslangic";
                    label6.Text = "Adet";
                    label6.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    button1.Enabled = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selected = comboBox1.SelectedIndex;
            string txt = textBox1.Text;
            if(comboBox1.Text != null && comboBox1.Text != "" && textBox1.Text != null && textBox1.Text != "")
            {
                switch (selected)
                {
                    case 0:
                        label4.Text = txt.ToUpper();
                        label4.Visible=true;
                        button2.Visible = true;
                        button2.Enabled=true;
                        break;
                    case 1:
                        label4.Text = txt.ToLower();
                        label4.Visible = true;
                        button2.Visible = true;
                        button2.Enabled = true;
                        break;
                    case 2:
                        if (textBox2.Text.Length != 0 && textBox2.Text != "" && textBox2.Text != null)
                        {
                            label4.Visible = true;
                            label4.Text = txt.IndexOf(textBox2.Text).ToString();
                            button2.Visible = true;
                            button2.Enabled = true;
                            textBox2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Lutfen parametereyi doldurmayi unutmayiniz ! :(");
                        }
                        break;
                    case 3:
                        if (textBox2.Text.Length != 0 && textBox2.Text != "" && textBox2.Text != null)
                        {
                            label4.Visible = true;
                            label4.Text = txt.LastIndexOf(textBox2.Text).ToString();
                            button2.Visible = true;
                            button2.Enabled = true;
                            textBox2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Lutfen parametereyi doldurmayi unutmayiniz ! :(");
                        }
                        break;
                    case 4:
                        if(textBox1.Text != null && textBox1.Text != "")
                        {
                            if (textBox2.Text != null && textBox2.Text != "" && textBox3.Text != null && textBox3.Text != "")
                            {
                                label4.Text = txt.Replace(textBox2.Text, textBox3.Text);
                                label4.Visible = true;
                                button2.Visible = true;
                                button2.Enabled = true;
                                button1.Enabled = false;
                                textBox2.Text = "";
                                textBox3.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Lutfen iki parametereyi doldurmayi unutmayiniz ! :(");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lutfen yazi bolumunude  doldurunuz ! :(");
                        }
                        break;
                    case 5:
                        
                        if (textBox2.Text != null && textBox2.Text != "")
                        {
                           label4.Visible = true;
                        label4.Text = txt.Remove(Convert.ToInt32(textBox2.Text));
                        button2.Visible = true;
                        button2.Enabled = true;
                        textBox2.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Lutfen parametereyi doldurmayi unutmayiniz ! :(");
                        }
                        break;
                    case 6:

                        if (textBox2.Text != null && textBox2.Text != "" && textBox3.Text != null && textBox3.Text != "")
                        {
                            label4.Visible = true;
                            label4.Text = txt.Substring(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                            button2.Visible = true;
                            button2.Enabled = true;
                            textBox2.Text = "";
                            textBox3.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Lutfen iki parametereyi doldurmayi unutmayiniz ! :(");
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Lutfen bir yazi girip ve islem seciniz!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label4.Text);
            textBox1.Text = "";
            label4.Text = "";
            comboBox1.Text = "Bir işlem seçiniz.";
            listBox1.Visible = true;
            button2.Enabled = false;
            button1.Enabled=false;
            groupBox1.Visible = false;
        }
    }
}
