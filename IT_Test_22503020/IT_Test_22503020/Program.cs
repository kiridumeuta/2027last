/*// See https://aka.ms/new-console-template for more information

using System;
using MySqlConnector;

namespace NumberSeisu
{
    class Program
    {
        string connStr = "server=172.16.2.26;user id=root;password=ae21215926;database=uta";

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!!!!");
            Console.WriteLine("整数を入力してください");

            var input = Console.ReadLine();
            var num = 0;
            if (int.TryParse(input, out num))
            {
                Console.WriteLine("入力した数は");
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("入力されたものは整数じゃありませんでした");
            }
        }

        private void SendInt()
        {
            int input1 = 0;
            int input2 = 0;
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string slq = "update pos set x=" + input1 + ",y=" + input2 + " where id =1";
                    MySqlCommand cmd = new MySqlCommand(slq, conn);
                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }
    }
}
*/

//using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mysql
{/*
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!!!!");

        }
    }*/


    class Program//public partial class Form1// : Form
    {
        static void Main(/*string[] args*/)
        {
            //form1_Load();
            Console.WriteLine("Hello, World!!!!");
        }

        /*public Form1()
        {
            //InitializeComponent();
            //Form1_Load(1);
            //button1_Click(1);
        }*/

        private void Form1_Load(object sender/*, EventArgs e*/)
        {
            ///string connStr = "server=172.16.2.26;user id=自分のid;password=自分のパスワード;database=自分のデータベース名";
            string connStr = "server=172.16.2.26;user id=root;password=ae21215926;database=uta";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                DataTable tbl = new DataTable();
                MySqlDataAdapter dataAdp = new MySqlDataAdapter("select * from ITTest", conn);
                dataAdp.Fill(tbl);
                ///dataGridView1.DataSource = tbl;
                conn.Close();
            }
            catch (MySqlException mse)
            {
                ///MessageBox.Show(mse.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Write(mse.ToString());
            }
        }

        private void button1_Click(object sender/*, EventArgs e*/)
        {
            ///string str0 = textBox1.Text;
            ///string str1 = textBox2.Text;
            ///int str2 = int.Parse(textBox3.Text);
            int str1 = 1;
            int str2 = 2;
            //int str3 = 3;


            string connStr = "server=172.16.2.26;user id=root;password=ae21215926;database=uta";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                DataTable tbl = new DataTable();
                DataTable tbl1 = new DataTable();
                ///MySqlDataAdapter dataAdp = new MySqlDataAdapter("update price set price=" + str2 + " where id = " + str0, conn);
                MySqlDataAdapter dataAdp = new MySqlDataAdapter("update price set price=" + str2 + " where id = " + str1, conn);
                dataAdp.Fill(tbl);
                MySqlDataAdapter dataAdp1 = new MySqlDataAdapter("select * from ITTest", conn);
                dataAdp1.Fill(tbl1);
                ///dataGridView1.DataSource = tbl1;
                conn.Close();
            }
            catch (MySqlException mse)
            {
                ///MessageBox.Show(mse.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.Write(mse.ToString());
            }
        }
    }
}