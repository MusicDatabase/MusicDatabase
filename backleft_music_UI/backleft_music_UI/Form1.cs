﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace backleft_music_UI
{
    public partial class libForm : Form
    {
        public bool loggedIn = false;

        public libForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mydbDataSet1.song_view' table. You can move, or remove it, as needed.
            this.song_viewTableAdapter1.Fill(this.mydbDataSet1.song_view);
            // TODO: This line of code loads data into the 'mydbDataSet1.userpurchase_view' table. You can move, or remove it, as needed.
            this.userpurchase_viewTableAdapter.Fill(this.mydbDataSet1.userpurchase_view);
            // TODO: This line of code loads data into the 'mydbDataSet.song_view' table. You can move, or remove it, as needed.
            this.song_viewTableAdapter.Fill(this.mydbDataSet.song_view);
            // TODO: This line of code loads data into the 'mydbDataSet.userpurchases' table. You can move, or remove it, as needed.
            this.userpurchasesTableAdapter.Fill(this.mydbDataSet.userpurchases);
            // TODO: This line of code loads data into the 'mydbDataSet.userplaylist' table. You can move, or remove it, as needed.
            this.userplaylistTableAdapter.Fill(this.mydbDataSet.userplaylist);
            // TODO: This line of code loads data into the 'mydbDataSet.songinfo' table. You can move, or remove it, as needed.
            this.songinfoTableAdapter.Fill(this.mydbDataSet.songinfo);
            // TODO: This line of code loads data into the 'mydbDataSet.playlist_song' table. You can move, or remove it, as needed.
            this.playlist_songTableAdapter.Fill(this.mydbDataSet.playlist_song);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void storeButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void playlist_songBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playlist_songBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mydbDataSet);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = loginTextBox.Text;
            string command = "SELECT * FROM userinfo WHERE userEmail = '" + email + "'";
           
            

            var connectionString = "Server = champlainmysql.cabect4hsdzs.us-east-1.rds.amazonaws.com; Database = mydb; Uid = BackLeft; Pwd = Champlain123;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            var sql2 = new MySqlCommand(command, connection);

            connection.Open();

            using (MySqlDataReader reader = sql2.ExecuteReader())
            {
                reader.Read();
                if (!reader.HasRows)
                {
                    var form = new Form3(email);
                    form.Show();
                }
                else
                {
                    User.Instance.firstName = reader["userFirstName"].ToString();
                    User.Instance.lastName = reader["userLastName"].ToString();
                    User.Instance.email = reader["userEmail"].ToString();
                    User.Instance.phoneNumber = reader["userPhoneNumber"].ToString();
                    //User.Instance.addressID = (int)reader["userAddID"];
                    //User.Instance.purchasesID = (int)reader["userPurchasesID"];
                    //User.Instance.creditCardID = (int)reader["userCreditCardID"];
                    User.Instance.userID = (int)reader["iduserInfo"];
                }
                populateMusic();
                loggedIn = true;
                connection.Close();
            }       
        }

        private void song_viewDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Open form 2

            if (e.RowIndex < 0 || e.ColumnIndex != song_viewDataGridView1.Columns["Buy"].Index) return;

            string songName = this.song_viewDataGridView1[0, e.RowIndex].Value.ToString();

            //int songID = (int)this.song_viewDataGridView1[12, e.RowIndex].Value;
            int songID = (int)this.song_viewDataGridView1[11, e.RowIndex].Value;
            if (loggedIn)
            {
                var form = new form2(songName, songID);
                Console.WriteLine(songName);
                form.Show();
            }
            else
            {
                MessageBox.Show("Please Log in!");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populateMusic()
        {
            string sql = "Select * from userpurchase_view Where iduserInfo = '" + User.Instance.userID + "'";
            var connectionString = "Server = champlainmysql.cabect4hsdzs.us-east-1.rds.amazonaws.com; Database = mydb; Uid = BackLeft; Pwd = Champlain123;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            var populate = new MySqlCommand(sql, connection);

            connection.Open();

            using (MySqlDataReader reader = populate.ExecuteReader())
            {
                dataGridView1.Rows.Clear();
                while(reader.Read())
                {
                    Console.WriteLine(reader["Title"].ToString());

                    this.dataGridView1.Rows.Add(reader["Title"].ToString(), reader["ArtistName"].ToString(), reader["AlbumName"].ToString(), reader["PlayCount"].ToString(), (int)reader["iduserInfo"]);
                    //string songstring = "SELECT * FROM userpurchases WHERE idSongInfo = '" + reader["idSongInfo"].ToString() + "'";
                    //connection.Close();
                    //  connection.Open();
                   
                }


            }
            connection.Close();
        }
    }
}
