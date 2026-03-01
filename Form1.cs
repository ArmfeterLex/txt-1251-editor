using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TXT_1251
{
    public partial class Form1 : Form
    {
        String Text2 = @"C:\Users\spo-user\Desktop\12\Text2.txt";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Multiline = true;
            textBox1.Clear();
            textBox1.Size = new Size(268, 112);
            button1.Text = "Открыть";
            button1.TabIndex = 0;
            button2.Text = "Сохранить";
            this.Text2 = "Здесь кодировка Windows 1251";
            Text2 = @"C:\Users\spo-user\Desktop\12\Text2.txt";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var Кодировка = System.Text.Encoding.GetEncoding(1251);
                var Читатель = new System.IO.StreamReader(Text2, Кодировка);
                textBox1.Text = Читатель.ReadToEnd();
                Читатель.Close();
                var МассивСтрок = System.IO.File.ReadAllLines(@"C:\Users\spo-user\Desktop\12\Text2.txt", Кодировка);
            }
            catch (System.IO.FileNotFoundException Ситуация) 
            {
                MessageBox.Show(Ситуация.Message + "\nНет такого файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button_2Click(object sender, EventArgs e)
        {
            try
            {
                var Кодировка = System.Text.Encoding.GetEncoding(1251);
                var Писатель = new System.IO.StreamWriter(Text2, false, Кодировка);
                Писатель.Write(textBox1.Text);
                Писатель.Close();
            }
            catch (Exception Ситуация)
            {
                MessageBox.Show(Ситуация.Message, "Ошикбка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    } }
