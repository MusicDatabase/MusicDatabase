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
    public partial class libForm : Form
    {
        public libForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void songinfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Open form 2
            var form = new form2();
            string yo =  this.songinfoDataGridView[1, e.RowIndex].Value.ToString();
            Console.WriteLine(yo);
            form.Show();
        }
    }
}
