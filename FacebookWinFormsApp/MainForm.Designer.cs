namespace BasicFacebookFeatures
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStripLeft = new System.Windows.Forms.MenuStrip();
            this.albumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallPostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.friendsByMyLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelFaceBookItems = new System.Windows.Forms.Label();
            this.comboBoxFacebookItems = new System.Windows.Forms.ComboBox();
            this.chartLikesByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonDownloadAlbum = new System.Windows.Forms.Button();
            this.buttonPreviousPhoto = new System.Windows.Forms.Button();
            this.buttonNextPhoto = new System.Windows.Forms.Button();
            this.pictureBoxFacebookItem = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStripLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLikesByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.labelHeader);
            this.panelTop.Controls.Add(this.buttonLogout);
            this.panelTop.Controls.Add(this.buttonLogin);
            this.panelTop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1593, 166);
            this.panelTop.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(656, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(482, 51);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Welcome To FaceBook!";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(194, 80);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(153, 53);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.Location = new System.Drawing.Point(194, 20);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(153, 55);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.menuStripLeft);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 859);
            this.panel2.TabIndex = 1;
            // 
            // menuStripLeft
            // 
            this.menuStripLeft.AutoSize = false;
            this.menuStripLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStripLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripLeft.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripLeft.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStripLeft.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumsToolStripMenuItem,
            this.pagesToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.wallPostsToolStripMenuItem,
            this.friendsByMyLocationToolStripMenuItem});
            this.menuStripLeft.Location = new System.Drawing.Point(0, 0);
            this.menuStripLeft.Name = "menuStripLeft";
            this.menuStripLeft.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStripLeft.Size = new System.Drawing.Size(396, 857);
            this.menuStripLeft.TabIndex = 0;
            this.menuStripLeft.Text = "Coose an action";
            // 
            // albumsToolStripMenuItem
            // 
            this.albumsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
            this.albumsToolStripMenuItem.Size = new System.Drawing.Size(389, 54);
            this.albumsToolStripMenuItem.Text = "Albums";
            this.albumsToolStripMenuItem.Click += new System.EventHandler(this.albumsToolStripMenuItem_Click);
            // 
            // pagesToolStripMenuItem
            // 
            this.pagesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(389, 54);
            this.pagesToolStripMenuItem.Text = "Pages";
            this.pagesToolStripMenuItem.Click += new System.EventHandler(this.pagesToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(389, 54);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // wallPostsToolStripMenuItem
            // 
            this.wallPostsToolStripMenuItem.Name = "wallPostsToolStripMenuItem";
            this.wallPostsToolStripMenuItem.Size = new System.Drawing.Size(389, 54);
            this.wallPostsToolStripMenuItem.Text = "Wall Posts";
            this.wallPostsToolStripMenuItem.Click += new System.EventHandler(this.wallPostsToolStripMenuItem_Click);
            // 
            // friendsByMyLocationToolStripMenuItem
            // 
            this.friendsByMyLocationToolStripMenuItem.Name = "friendsByMyLocationToolStripMenuItem";
            this.friendsByMyLocationToolStripMenuItem.Size = new System.Drawing.Size(389, 54);
            this.friendsByMyLocationToolStripMenuItem.Text = "Frinds By My Location";
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Location = new System.Drawing.Point(639, 173);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(853, 195);
            this.richTextBoxStatus.TabIndex = 2;
            this.richTextBoxStatus.Text = "";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1358, 373);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(135, 44);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Post!";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(639, 373);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 44);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelFaceBookItems
            // 
            this.labelFaceBookItems.AutoSize = true;
            this.labelFaceBookItems.Location = new System.Drawing.Point(243, 520);
            this.labelFaceBookItems.Name = "labelFaceBookItems";
            this.labelFaceBookItems.Size = new System.Drawing.Size(0, 25);
            this.labelFaceBookItems.TabIndex = 7;
            // 
            // comboBoxFacebookItems
            // 
            this.comboBoxFacebookItems.FormattingEnabled = true;
            this.comboBoxFacebookItems.Location = new System.Drawing.Point(423, 526);
            this.comboBoxFacebookItems.Name = "comboBoxFacebookItems";
            this.comboBoxFacebookItems.Size = new System.Drawing.Size(316, 33);
            this.comboBoxFacebookItems.TabIndex = 8;
            this.comboBoxFacebookItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacebookItems_SelectedIndexChanged);
            // 
            // chartLikesByMonth
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLikesByMonth.ChartAreas.Add(chartArea1);
            this.chartLikesByMonth.Enabled = false;
            legend1.Name = "Legend1";
            this.chartLikesByMonth.Legends.Add(legend1);
            this.chartLikesByMonth.Location = new System.Drawing.Point(886, 520);
            this.chartLikesByMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartLikesByMonth.Name = "chartLikesByMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLikesByMonth.Series.Add(series1);
            this.chartLikesByMonth.Size = new System.Drawing.Size(627, 397);
            this.chartLikesByMonth.TabIndex = 9;
            this.chartLikesByMonth.Text = "chartLikesByMonth";
            // 
            // buttonDownloadAlbum
            // 
            this.buttonDownloadAlbum.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.download;
            this.buttonDownloadAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(745, 518);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(68, 47);
            this.buttonDownloadAlbum.TabIndex = 11;
            this.buttonDownloadAlbum.UseVisualStyleBackColor = true;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            // 
            // buttonPreviousPhoto
            // 
            this.buttonPreviousPhoto.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.left_arrow;
            this.buttonPreviousPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPreviousPhoto.Location = new System.Drawing.Point(423, 923);
            this.buttonPreviousPhoto.Name = "buttonPreviousPhoto";
            this.buttonPreviousPhoto.Size = new System.Drawing.Size(75, 34);
            this.buttonPreviousPhoto.TabIndex = 10;
            this.buttonPreviousPhoto.UseVisualStyleBackColor = true;
            // 
            // buttonNextPhoto
            // 
            this.buttonNextPhoto.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.right_arrow;
            this.buttonNextPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNextPhoto.Location = new System.Drawing.Point(738, 923);
            this.buttonNextPhoto.Name = "buttonNextPhoto";
            this.buttonNextPhoto.Size = new System.Drawing.Size(75, 34);
            this.buttonNextPhoto.TabIndex = 10;
            this.buttonNextPhoto.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFacebookItem
            // 
            this.pictureBoxFacebookItem.Location = new System.Drawing.Point(423, 581);
            this.pictureBoxFacebookItem.Name = "pictureBoxFacebookItem";
            this.pictureBoxFacebookItem.Size = new System.Drawing.Size(390, 336);
            this.pictureBoxFacebookItem.TabIndex = 6;
            this.pictureBoxFacebookItem.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(422, 173);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(195, 195);
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 1025);
            this.Controls.Add(this.buttonDownloadAlbum);
            this.Controls.Add(this.buttonPreviousPhoto);
            this.Controls.Add(this.buttonNextPhoto);
            this.Controls.Add(this.chartLikesByMonth);
            this.Controls.Add(this.comboBoxFacebookItems);
            this.Controls.Add(this.labelFaceBookItems);
            this.Controls.Add(this.pictureBoxFacebookItem);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.richTextBoxStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStripLeft.ResumeLayout(false);
            this.menuStripLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLikesByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.MenuStrip menuStripLeft;
        private System.Windows.Forms.ToolStripMenuItem albumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBoxStatus;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxFacebookItem;
        private System.Windows.Forms.Label labelFaceBookItems;
        private System.Windows.Forms.ToolStripMenuItem wallPostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem friendsByMyLocationToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxFacebookItems;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLikesByMonth;
        private System.Windows.Forms.Button buttonNextPhoto;
        private System.Windows.Forms.Button buttonPreviousPhoto;
        private System.Windows.Forms.Button buttonDownloadAlbum;
    }
}