namespace backleft_music_UI
{
    partial class libForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.song_viewDataGridView1 = new System.Windows.Forms.DataGridView();
            this.song_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new backleft_music_UI.mydbDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.song_viewDataGridView = new System.Windows.Forms.DataGridView();
            this.songinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.playlist_songBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playlist_songTableAdapter = new backleft_music_UI.mydbDataSetTableAdapters.playlist_songTableAdapter();
            this.tableAdapterManager = new backleft_music_UI.mydbDataSetTableAdapters.TableAdapterManager();
            this.songinfoTableAdapter = new backleft_music_UI.mydbDataSetTableAdapters.songinfoTableAdapter();
            this.userplaylistTableAdapter = new backleft_music_UI.mydbDataSetTableAdapters.userplaylistTableAdapter();
            this.userpurchasesTableAdapter = new backleft_music_UI.mydbDataSetTableAdapters.userpurchasesTableAdapter();
            this.userplaylistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userpurchasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.song_viewTableAdapter = new backleft_music_UI.mydbDataSetTableAdapters.song_viewTableAdapter();
            this.mydbDataSet1 = new backleft_music_UI.mydbDataSet1();
            this.userpurchase_viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userpurchase_viewTableAdapter = new backleft_music_UI.mydbDataSet1TableAdapters.userpurchase_viewTableAdapter();
            this.tableAdapterManager1 = new backleft_music_UI.mydbDataSet1TableAdapters.TableAdapterManager();
            this.song_viewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.song_viewTableAdapter1 = new backleft_music_UI.mydbDataSet1TableAdapters.song_viewTableAdapter();
            this.songIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumTrackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playcountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bPMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.purchaseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songAlbumNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.song_viewDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.song_viewDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.songinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlist_songBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userplaylistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpurchasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpurchase_viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_viewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(12, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(882, 374);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.song_viewDataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(874, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Store";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // song_viewDataGridView1
            // 
            this.song_viewDataGridView1.AutoGenerateColumns = false;
            this.song_viewDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.song_viewDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.songIDDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1,
            this.genreDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.albumTrackDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.playcountDataGridViewTextBoxColumn1,
            this.bPMDataGridViewTextBoxColumn,
            this.Buy});
            this.song_viewDataGridView1.DataSource = this.song_viewBindingSource1;
            this.song_viewDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.song_viewDataGridView1.Name = "song_viewDataGridView1";
            this.song_viewDataGridView1.Size = new System.Drawing.Size(874, 348);
            this.song_viewDataGridView1.TabIndex = 0;
            this.song_viewDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.song_viewDataGridView1_CellContentClick);
            // 
            // song_viewBindingSource
            // 
            this.song_viewBindingSource.DataMember = "song_view";
            this.song_viewBindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.song_viewDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(874, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Music";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // song_viewDataGridView
            // 
            this.song_viewDataGridView.AutoGenerateColumns = false;
            this.song_viewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.song_viewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchaseIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.artistNameDataGridViewTextBoxColumn,
            this.songAlbumNameDataGridViewTextBoxColumn,
            this.playCountDataGridViewTextBoxColumn});
            this.song_viewDataGridView.DataSource = this.userpurchase_viewBindingSource;
            this.song_viewDataGridView.Location = new System.Drawing.Point(0, 0);
            this.song_viewDataGridView.Name = "song_viewDataGridView";
            this.song_viewDataGridView.Size = new System.Drawing.Size(874, 348);
            this.song_viewDataGridView.TabIndex = 0;
            // 
            // songinfoBindingSource
            // 
            this.songinfoBindingSource.DataMember = "songinfo";
            this.songinfoBindingSource.DataSource = this.mydbDataSet;
            // 
            // storeButton
            // 
            this.storeButton.Location = new System.Drawing.Point(458, 10);
            this.storeButton.Name = "storeButton";
            this.storeButton.Size = new System.Drawing.Size(75, 23);
            this.storeButton.TabIndex = 1;
            this.storeButton.Text = "Search";
            this.storeButton.UseVisualStyleBackColor = true;
            this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 418);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(386, 419);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 421);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(643, 419);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(724, 419);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 11);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(8, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(112, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Backleft Music";
            // 
            // playlist_songBindingSource
            // 
            this.playlist_songBindingSource.DataMember = "playlist_song";
            this.playlist_songBindingSource.DataSource = this.mydbDataSet;
            // 
            // playlist_songTableAdapter
            // 
            this.playlist_songTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.playlist_songTableAdapter = this.playlist_songTableAdapter;
            this.tableAdapterManager.songalbumTableAdapter = null;
            this.tableAdapterManager.songartistTableAdapter = null;
            this.tableAdapterManager.songinfoTableAdapter = this.songinfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = backleft_music_UI.mydbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.useraddressTableAdapter = null;
            this.tableAdapterManager.usercreditcardinfoTableAdapter = null;
            this.tableAdapterManager.userinfoTableAdapter = null;
            this.tableAdapterManager.userplaylistTableAdapter = this.userplaylistTableAdapter;
            this.tableAdapterManager.userpurchasesTableAdapter = this.userpurchasesTableAdapter;
            // 
            // songinfoTableAdapter
            // 
            this.songinfoTableAdapter.ClearBeforeFill = true;
            // 
            // userplaylistTableAdapter
            // 
            this.userplaylistTableAdapter.ClearBeforeFill = true;
            // 
            // userpurchasesTableAdapter
            // 
            this.userpurchasesTableAdapter.ClearBeforeFill = true;
            // 
            // userplaylistBindingSource
            // 
            this.userplaylistBindingSource.DataMember = "userplaylist";
            this.userplaylistBindingSource.DataSource = this.mydbDataSet;
            // 
            // userpurchasesBindingSource
            // 
            this.userpurchasesBindingSource.DataMember = "userpurchases";
            this.userpurchasesBindingSource.DataSource = this.mydbDataSet;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(819, 10);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(639, 11);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(174, 20);
            this.loginTextBox.TabIndex = 10;
            this.loginTextBox.Text = "email";
            // 
            // song_viewTableAdapter
            // 
            this.song_viewTableAdapter.ClearBeforeFill = true;
            // 
            // mydbDataSet1
            // 
            this.mydbDataSet1.DataSetName = "mydbDataSet1";
            this.mydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userpurchase_viewBindingSource
            // 
            this.userpurchase_viewBindingSource.DataMember = "userpurchase_view";
            this.userpurchase_viewBindingSource.DataSource = this.mydbDataSet1;
            // 
            // userpurchase_viewTableAdapter
            // 
            this.userpurchase_viewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.playlist_songTableAdapter = null;
            this.tableAdapterManager1.songalbumTableAdapter = null;
            this.tableAdapterManager1.songartistTableAdapter = null;
            this.tableAdapterManager1.songinfoTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = backleft_music_UI.mydbDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.useraddressTableAdapter = null;
            this.tableAdapterManager1.usercreditcardinfoTableAdapter = null;
            this.tableAdapterManager1.userinfoTableAdapter = null;
            this.tableAdapterManager1.userplaylistTableAdapter = null;
            this.tableAdapterManager1.userpurchasesInfoTableAdapter = null;
            this.tableAdapterManager1.userpurchasesTableAdapter = null;
            // 
            // song_viewBindingSource1
            // 
            this.song_viewBindingSource1.DataMember = "song_view";
            this.song_viewBindingSource1.DataSource = this.mydbDataSet1;
            // 
            // song_viewTableAdapter1
            // 
            this.song_viewTableAdapter1.ClearBeforeFill = true;
            // 
            // songIDDataGridViewTextBoxColumn
            // 
            this.songIDDataGridViewTextBoxColumn.DataPropertyName = "Song ID";
            this.songIDDataGridViewTextBoxColumn.HeaderText = "Song ID";
            this.songIDDataGridViewTextBoxColumn.Name = "songIDDataGridViewTextBoxColumn";
            this.songIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // artistDataGridViewTextBoxColumn
            // 
            this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
            this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
            this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // albumTrackDataGridViewTextBoxColumn
            // 
            this.albumTrackDataGridViewTextBoxColumn.DataPropertyName = "Album Track";
            this.albumTrackDataGridViewTextBoxColumn.HeaderText = "Album Track";
            this.albumTrackDataGridViewTextBoxColumn.Name = "albumTrackDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // playcountDataGridViewTextBoxColumn1
            // 
            this.playcountDataGridViewTextBoxColumn1.DataPropertyName = "Playcount";
            this.playcountDataGridViewTextBoxColumn1.HeaderText = "Playcount";
            this.playcountDataGridViewTextBoxColumn1.Name = "playcountDataGridViewTextBoxColumn1";
            // 
            // bPMDataGridViewTextBoxColumn
            // 
            this.bPMDataGridViewTextBoxColumn.DataPropertyName = "BPM";
            this.bPMDataGridViewTextBoxColumn.HeaderText = "BPM";
            this.bPMDataGridViewTextBoxColumn.Name = "bPMDataGridViewTextBoxColumn";
            // 
            // Buy
            // 
            this.Buy.HeaderText = "Purchase";
            this.Buy.Name = "Buy";
            // 
            // purchaseIDDataGridViewTextBoxColumn
            // 
            this.purchaseIDDataGridViewTextBoxColumn.DataPropertyName = "Purchase ID";
            this.purchaseIDDataGridViewTextBoxColumn.HeaderText = "Purchase ID";
            this.purchaseIDDataGridViewTextBoxColumn.Name = "purchaseIDDataGridViewTextBoxColumn";
            this.purchaseIDDataGridViewTextBoxColumn.Visible = false;
            this.purchaseIDDataGridViewTextBoxColumn.Width = 5;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // artistNameDataGridViewTextBoxColumn
            // 
            this.artistNameDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.HeaderText = "ArtistName";
            this.artistNameDataGridViewTextBoxColumn.Name = "artistNameDataGridViewTextBoxColumn";
            // 
            // songAlbumNameDataGridViewTextBoxColumn
            // 
            this.songAlbumNameDataGridViewTextBoxColumn.DataPropertyName = "songAlbumName";
            this.songAlbumNameDataGridViewTextBoxColumn.HeaderText = "songAlbumName";
            this.songAlbumNameDataGridViewTextBoxColumn.Name = "songAlbumNameDataGridViewTextBoxColumn";
            // 
            // playCountDataGridViewTextBoxColumn
            // 
            this.playCountDataGridViewTextBoxColumn.DataPropertyName = "PlayCount";
            this.playCountDataGridViewTextBoxColumn.HeaderText = "PlayCount";
            this.playCountDataGridViewTextBoxColumn.Name = "playCountDataGridViewTextBoxColumn";
            // 
            // libForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 454);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.storeButton);
            this.Controls.Add(this.tabControl);
            this.Name = "libForm";
            this.Text = "Libaray";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.song_viewDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.song_viewDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.songinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playlist_songBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userplaylistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpurchasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpurchase_viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.song_viewBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button storeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label nameLabel;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource playlist_songBindingSource;
        private mydbDataSetTableAdapters.playlist_songTableAdapter playlist_songTableAdapter;
        private mydbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private mydbDataSetTableAdapters.songinfoTableAdapter songinfoTableAdapter;
        private System.Windows.Forms.BindingSource songinfoBindingSource;
        private mydbDataSetTableAdapters.userplaylistTableAdapter userplaylistTableAdapter;
        private System.Windows.Forms.BindingSource userplaylistBindingSource;
        private mydbDataSetTableAdapters.userpurchasesTableAdapter userpurchasesTableAdapter;
        private System.Windows.Forms.BindingSource userpurchasesBindingSource;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.BindingSource song_viewBindingSource;
        private mydbDataSetTableAdapters.song_viewTableAdapter song_viewTableAdapter;
        private System.Windows.Forms.DataGridView song_viewDataGridView1;
        private System.Windows.Forms.DataGridView song_viewDataGridView;
        private mydbDataSet1 mydbDataSet1;
        private System.Windows.Forms.BindingSource userpurchase_viewBindingSource;
        private mydbDataSet1TableAdapters.userpurchase_viewTableAdapter userpurchase_viewTableAdapter;
        private mydbDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource song_viewBindingSource1;
        private mydbDataSet1TableAdapters.song_viewTableAdapter song_viewTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn songIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumTrackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playcountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bPMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn songAlbumNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playCountDataGridViewTextBoxColumn;
    }
}

