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
    public partial class form2 : Form
    {
        mydbDataSet db;
        string songName;
        int songID;

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

            if (allFilled)
            {
                var user =
                    (from c in db.userinfo
                     where c.iduserInfo == 1 // TODO: fix this (userID)
                     select c).First();

                // TODO: add song to user's prurchases table.

                //ALMOST THERE?//db.userpurchases.AdduserpurchasesRow(
                this.Close();
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
