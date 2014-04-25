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
            bool allFilled = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        allFilled = false;
                    }
                }
            }
            allFilled = true;
            if (allFilled)
            {
                string sql2 = "INSERT INTO userinfo (userFirstName, userLastName, userEmail, userPhoneNumber) VALUES('" + firstNameTextBox.Text + "', '" + lastNameTextBox.Text + "', '" + emailTextBox.Text + "', '" + phoneTextBox.Text + "')";
                string command = "SELECT * FROM userinfo WHERE userEmail = '" + emailTextBox.Text + "'";
           
                var connectionString = "Server = champlainmysql.cabect4hsdzs.us-east-1.rds.amazonaws.com; Database = mydb; Uid = BackLeft; Pwd = Champlain123;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                MySqlCommand cmd = new MySqlCommand(sql2, connection);
                

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                connection.Open();

                MySqlCommand sql = new MySqlCommand(command, connection);
                using (MySqlDataReader reader3 = sql.ExecuteReader())
                {
                    reader3.Read();
                    
                    User.Instance.firstName = reader3["userFirstName"].ToString();
                    User.Instance.lastName = reader3["userLastName"].ToString();
                    User.Instance.email = reader3["userEmail"].ToString();
                    User.Instance.phoneNumber = reader3["userPhoneNumber"].ToString();
                    //User.Instance.addressID = (int)reader["userAddID"];
                    //User.Instance.purchasesID = (int)reader["userPurchasesID"];
                    //User.Instance.creditCardID = (int)reader["userCreditCardID"];
                    User.Instance.userID = (int)reader3["iduserInfo"];
                    
                }
                connection.Close();
            }
            
            this.Close();
        }
    }
}
