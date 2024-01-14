namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupsListlabel = new System.Windows.Forms.Label();
            this.buttonFetchData = new System.Windows.Forms.Button();
            this.pictureBoxGroup = new System.Windows.Forms.PictureBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.pictureBoxAlbum = new System.Windows.Forms.PictureBox();
            this.pagesListlabel = new System.Windows.Forms.Label();
            this.albumsListlabel = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.listBoxPageLikes = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxGeographicProximity = new System.Windows.Forms.ListBox();
            this.buttonGeographicProximity = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(713, 48);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\". The grader will use it to test yo" +
    "ur app.\r\nType here your own AppID to test it:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupsListlabel);
            this.tabPage1.Controls.Add(this.buttonFetchData);
            this.tabPage1.Controls.Add(this.pictureBoxGroup);
            this.tabPage1.Controls.Add(this.pictureBoxPage);
            this.tabPage1.Controls.Add(this.pictureBoxAlbum);
            this.tabPage1.Controls.Add(this.pagesListlabel);
            this.tabPage1.Controls.Add(this.albumsListlabel);
            this.tabPage1.Controls.Add(this.listBoxGroups);
            this.tabPage1.Controls.Add(this.listBoxPageLikes);
            this.tabPage1.Controls.Add(this.listBoxAlbums);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupsListlabel
            // 
            this.groupsListlabel.AutoSize = true;
            this.groupsListlabel.Location = new System.Drawing.Point(795, 192);
            this.groupsListlabel.Name = "groupsListlabel";
            this.groupsListlabel.Size = new System.Drawing.Size(122, 24);
            this.groupsListlabel.TabIndex = 65;
            this.groupsListlabel.Text = "Your Groups:";
            // 
            // buttonFetchData
            // 
            this.buttonFetchData.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonFetchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchData.Location = new System.Drawing.Point(38, 582);
            this.buttonFetchData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFetchData.Name = "buttonFetchData";
            this.buttonFetchData.Size = new System.Drawing.Size(1046, 44);
            this.buttonFetchData.TabIndex = 64;
            this.buttonFetchData.Text = "Fetch Data";
            this.buttonFetchData.UseVisualStyleBackColor = false;
            this.buttonFetchData.Click += new System.EventHandler(this.buttonFetchData_Click);
            // 
            // pictureBoxGroup
            // 
            this.pictureBoxGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxGroup.Location = new System.Drawing.Point(984, 463);
            this.pictureBoxGroup.Name = "pictureBoxGroup";
            this.pictureBoxGroup.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxGroup.TabIndex = 63;
            this.pictureBoxGroup.TabStop = false;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPage.Location = new System.Drawing.Point(610, 463);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxPage.TabIndex = 62;
            this.pictureBoxPage.TabStop = false;
            // 
            // pictureBoxAlbum
            // 
            this.pictureBoxAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAlbum.Location = new System.Drawing.Point(222, 463);
            this.pictureBoxAlbum.Name = "pictureBoxAlbum";
            this.pictureBoxAlbum.Size = new System.Drawing.Size(100, 96);
            this.pictureBoxAlbum.TabIndex = 61;
            this.pictureBoxAlbum.TabStop = false;
            // 
            // pagesListlabel
            // 
            this.pagesListlabel.AutoSize = true;
            this.pagesListlabel.Location = new System.Drawing.Point(421, 192);
            this.pagesListlabel.Name = "pagesListlabel";
            this.pagesListlabel.Size = new System.Drawing.Size(163, 24);
            this.pagesListlabel.TabIndex = 60;
            this.pagesListlabel.Text = "Your Liked Pages:";
            // 
            // albumsListlabel
            // 
            this.albumsListlabel.AutoSize = true;
            this.albumsListlabel.Location = new System.Drawing.Point(34, 192);
            this.albumsListlabel.Name = "albumsListlabel";
            this.albumsListlabel.Size = new System.Drawing.Size(124, 24);
            this.albumsListlabel.TabIndex = 59;
            this.albumsListlabel.Text = "Your Albums:";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 22;
            this.listBoxGroups.Location = new System.Drawing.Point(799, 231);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(285, 334);
            this.listBoxGroups.TabIndex = 58;
            // 
            // listBoxPageLikes
            // 
            this.listBoxPageLikes.FormattingEnabled = true;
            this.listBoxPageLikes.ItemHeight = 22;
            this.listBoxPageLikes.Location = new System.Drawing.Point(425, 231);
            this.listBoxPageLikes.Name = "listBoxPageLikes";
            this.listBoxPageLikes.Size = new System.Drawing.Size(285, 334);
            this.listBoxPageLikes.TabIndex = 57;
            this.listBoxPageLikes.SelectedIndexChanged += new System.EventHandler(this.listBoxPageLikes_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 22;
            this.listBoxAlbums.Location = new System.Drawing.Point(38, 231);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(284, 334);
            this.listBoxAlbums.TabIndex = 56;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(895, 3);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 28);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1828145884290754";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxGeographicProximity);
            this.tabPage2.Controls.Add(this.buttonGeographicProximity);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxGeographicProximity
            // 
            this.listBoxGeographicProximity.FormattingEnabled = true;
            this.listBoxGeographicProximity.ItemHeight = 22;
            this.listBoxGeographicProximity.Location = new System.Drawing.Point(30, 109);
            this.listBoxGeographicProximity.Name = "listBoxGeographicProximity";
            this.listBoxGeographicProximity.Size = new System.Drawing.Size(274, 312);
            this.listBoxGeographicProximity.TabIndex = 2;
            // 
            // buttonGeographicProximity
            // 
            this.buttonGeographicProximity.Location = new System.Drawing.Point(28, 58);
            this.buttonGeographicProximity.Name = "buttonGeographicProximity";
            this.buttonGeographicProximity.Size = new System.Drawing.Size(276, 38);
            this.buttonGeographicProximity.TabIndex = 1;
            this.buttonGeographicProximity.Text = "Find My Friend In My City:";
            this.buttonGeographicProximity.UseVisualStyleBackColor = true;
            this.buttonGeographicProximity.Click += new System.EventHandler(this.buttonGeographicProximity_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.ListBox listBoxPageLikes;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label albumsListlabel;
        private System.Windows.Forms.Label pagesListlabel;
        private System.Windows.Forms.PictureBox pictureBoxGroup;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.PictureBox pictureBoxAlbum;
        private System.Windows.Forms.Button buttonFetchData;
        private System.Windows.Forms.Label groupsListlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGeographicProximity;
        private System.Windows.Forms.ListBox listBoxGeographicProximity;
    }
}

