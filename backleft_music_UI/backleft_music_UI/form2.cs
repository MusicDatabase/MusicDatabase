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
using MySql.Data.MySqlClient;

namespace backleft_music_UI
{
    public partial class form2 : Form
    {
        mydbDataSet db;
        string songName;
        int songID;
        MySqlConnection connection;

        public form2()
        {
            InitializeComponent();
            db = new mydbDataSet();
        }

        public form2(string songName, int songID)
        {
            InitializeComponent();
            db = new mydbDataSet();
            this.songName = songName;
            this.songID = songID;
            Console.WriteLine(songName);
        }

        private void form2_Load(object sender, EventArgs e)
        {
            label11.Text = songName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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
                User user;
                
               // var sql = string.Format("SELECT *");
                var connectionString = "Server = champlainmysql.cabect4hsdzs.us-east-1.rds.amazonaws.com; Database = mydb; Uid = BackLeft; Pwd = Champlain123;";
               connection = new MySqlConnection(connectionString);
                string cmd = "SELECT * FROM userinfo WHERE iduserInfo = " + User.Instance.userID;
               var sql = new MySqlCommand(cmd, connection);

               {
                   connection.Open();

                   using (MySqlDataReader reader = sql.ExecuteReader())
                   {
                       reader.Read();

                       //user = new User()
                       //{
                       //    firstName = reader["userFirstName"].ToString(),
                       //    lastName = reader["userLastName"].ToString(),
                       //    email = reader["userEmail"].ToString(),
                       //    phoneNumber = reader["userPhoneNumber"].ToString(),
                       //    addressID = (int)reader["userAddID"],
                       //    purchasesID = (int)reader["userPurchasesID"],
                       //    creditCardID = (int)reader["userCreditCardID"],
                       //    userID = (int)reader["iduserInfo"]
                       //};
                       //User.Instance.firstName = reader["userFirstName"].ToString();
                       //User.Instance.lastName = reader["userLastName"].ToString();
                       //User.Instance.email = reader["userEmail"].ToString();
                       //User.Instance.phoneNumber = reader["userPhoneNumber"].ToString();
                       //User.Instance.addressID = (int)reader["userAddID"];
                       //User.Instance.purchasesID = (int)reader["userPurchasesID"];
                       //User.Instance.creditCardID = (int)reader["userCreditCardID"];
                       //User.Instance.userID = (int)reader["iduserInfo"];
                     
                       //Console.WriteLine("Name: " +  User.Instance.firstName);
                   }
                   string sql2 = "INSERT INTO userpurchases (userPurchasesID, idSongInfo) VALUES('" + User.Instance.purchasesID + "', '" + songID + "')";
                   //open connection
                  // if (connection.Open() == true)
                  // {
                       //create command and assign the query and connection from the constructor
                       MySqlCommand cmd2 = new MySqlCommand(sql2, connection);

                       //Execute command
                       cmd2.ExecuteNonQuery();

                       
                       //close connection
                      // this.CloseConnection();
             //      }

               }
               //catch (MySqlException ex)
               //{
               //    //When handling errors, you can your application's response based 
               //    //on the error number.
               //    //The two most common error numbers when connecting are as follows:
               //    //0: Cannot connect to server.
               //    //1045: Invalid user name and/or password.
               //    switch (ex.Number)
               //    {
               //        case 0:
               //            MessageBox.Show("Cannot connect to server.  Contact administrator");
               //            break;

               //        case 1045:
               //            MessageBox.Show("Invalid username/password, please try again");
               //            break;
               //    }
               //}

               

               /* using (var connection = command.Connection)
                {
                    connection.Open();

                    using (var reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                    {
                        reader.Read();

                        user = new User()
                        {
                            firstName = reader["userFirstName"].ToString(),
                            lastName = reader["userLastName"].ToString(),
                            email = reader["userEmail"].ToString(),
                            phoneNumber = reader["userPhoneNumber"].ToString()
                        };

                    }

                    connection.Close();

                }
                user.purchasesID = 1;

                var sql2 = string.Format("INSERT INTO Message (userPurcasesID, idSongInfo) VALUES ('{0}', '{1}')", user.purchasesID, songID);

                var command2 = new System.Data.SqlClient.SqlCommand(sql2, new System.Data.SqlClient.SqlConnection(connectionString));

                using (var connection = command2.Connection)
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }*/

               //var user =
                    //(from c in db.userinfo
                     //where c.iduserInfo == 1 // TODO: fix this (userID)
                     //select c).First();

                // TODO: add song to user's prurchases table.

                //ALMOST THERE?//db.userpurchases.AdduserpurchasesRow(
               connection.Close();
                this.Close();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
