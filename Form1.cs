using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Net;
using System.Net.Http;



namespace hakaton
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e) //log in
        {

            string log = textBox1.Text;
            string pas = textBox2.Text;

            SQLiteConnection con = new SQLiteConnection("Data Source = data.db");
            con.Open();

            using (SQLiteCommand cmd = new SQLiteCommand(con))
            {
                cmd.CommandText = "select rowid from Users where login = '" + log + "'";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    //label1.Text = "Совпадений не найдено!!! Введите другие данные."; //TODO
                    textBox1.Text = "";
                    textBox2.Text = "";
                    //cmd.CommandText = "insert into passwords(type, name, password) values ('" + type + "', '" + name + "', '" + pas + "')";
                }
                else
                {

                    cmd.CommandText = "select password from Users where login = '" + log + "'";
                    string p = cmd.ExecuteScalar().ToString();
                    if (p == pas) tabControl1.SelectTab(tabPage5);
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
            }
            con.Close();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string basename = "data.db";
            if (!File.Exists(basename))
            {
                SQLiteConnection.CreateFile(basename);
                SQLiteConnection con = new SQLiteConnection("Data Source = data.db");
                con.Open();

                using (SQLiteCommand command = new SQLiteCommand(con))
                {
                    command.CommandText = @"CREATE TABLE [Users] (

                    [login] char(100) NOT NULL,
                    [password] char(100) NOT NULL

                    );";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string log = textBox1.Text;
            string pas = textBox2.Text;

            SQLiteConnection con = new SQLiteConnection("Data Source = data.db");
            con.Open();

            using (SQLiteCommand cmd = new SQLiteCommand(con))
            {
                cmd.CommandText = "select rowid from Users where login = '" + log + "'";
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    //label1.Text = "Совпадений не найдено!!! Введите другие данные."; //TODO
                    textBox1.Text = "";
                    textBox2.Text = "";
                    
                }
                else
                {

                    cmd.CommandText = "select password from Users where login = '" + log + "'";
                    string p = cmd.ExecuteScalar().ToString();
                    if (p == pas) tabControl1.SelectTab(tabPage5);
                    textBox1.Text = "";
                    textBox2.Text = "";

                }
            }
            con.Close();
        }
        public void inf(int id)
        {
            textBox3.Text = "";
            richTextBox1.Text = "";
            SQLiteConnection con = new SQLiteConnection("Data Source = info.db");
            con.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(con))
            {
                cmd.CommandText = "select Name from Theatres where Id = " + id;
                string name = Convert.ToString(cmd.ExecuteScalar());
                cmd.CommandText = "select Info from Theatres where Id = " + id ;
                string info = Convert.ToString(cmd.ExecuteScalar());
                textBox3.Text = name;
                richTextBox1.Text = info;
                
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            inf(1);
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            inf(34);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            inf(2);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            inf(3);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            inf(4);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            inf(5);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            inf(6);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            inf(7);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            inf(8);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            inf(9);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            inf(10);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            inf(11);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            inf(12);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            inf(13);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            inf(14);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            inf(15);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            inf(16);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            inf(17);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            inf(18);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            inf(19);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            inf(20);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            inf(21);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            inf(22);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            inf(23);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            inf(24);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            inf(25);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            inf(26);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            inf(27);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            inf(29);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            inf(30);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            inf(31);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            inf(32);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            inf(33);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage6);
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }
    }
}
