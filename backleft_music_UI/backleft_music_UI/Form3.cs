using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace backleft_music_UI
{
    public partial class Form3 : Form
    {
        mydbDataSet db;
        string email;

        public Form3()
        {
            InitializeComponent();
            db = new mydbDataSet();
        }

        public Form3(string email)
        {
            InitializeComponent();
            db = new mydbDataSet();
            this.email = email;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            emailTextBox.Text = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: SQL INSERT new user.
            string sql2 = "INSERT INTO userinfo (userFirstName, userLastName, userEmail, userPhoneNumber) VALUES('" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "', '" + emailTextBox.Text + "', '" + phoneTextBox.Text + "')";

            var connectionString = "Server = champlainmysql.cabect4hsdzs.us-east-1.rds.amazonaws.com; Database = mydb; Uid = BackLeft; Pwd = Champlain123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            MySqlCommand cmd = new MySqlCommand(sql2, connection);
            
            connection.Open();
            cmd.ExecuteNonQuery();

            this.Close();
        }
    }
}
