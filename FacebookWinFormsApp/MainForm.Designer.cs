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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonHamburger = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.richTextBoxNewPost = new System.Windows.Forms.RichTextBox();
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
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.albumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wallPostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripLeft = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.albumsButton = new System.Windows.Forms.Button();
            this.pagesButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.postsButton = new System.Windows.Forms.Button();
            this.statisticsButton = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.mostLikedPictureLabel = new System.Windows.Forms.Label();
            this.comboBoxForAlbum = new System.Windows.Forms.ComboBox();
            this.mostLikedPic = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHamburger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLikesByMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.menuStripLeft.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mostLikedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.buttonHamburger);
            this.panelTop.Controls.Add(this.labelHeader);
            this.panelTop.Controls.Add(this.buttonLogin);
            this.panelTop.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1062, 54);
            this.panelTop.TabIndex = 0;
            // 
            // buttonHamburger
            // 
            this.buttonHamburger.Image = ((System.Drawing.Image)(resources.GetObject("buttonHamburger.Image")));
            this.buttonHamburger.Location = new System.Drawing.Point(22, 12);
            this.buttonHamburger.Name = "buttonHamburger";
            this.buttonHamburger.Size = new System.Drawing.Size(38, 31);
            this.buttonHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonHamburger.TabIndex = 3;
            this.buttonHamburger.TabStop = false;
            this.buttonHamburger.Click += new System.EventHandler(this.buttonHamburger_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(77, 12);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(251, 31);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Welcome To FaceBook !";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogin.Image")));
            this.buttonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogin.Location = new System.Drawing.Point(812, 8);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonLogin.Size = new System.Drawing.Size(226, 41);
            this.buttonLogin.TabIndex = 19;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // richTextBoxNewPost
            // 
            this.richTextBoxNewPost.Location = new System.Drawing.Point(426, 111);
            this.richTextBoxNewPost.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxNewPost.Name = "richTextBoxNewPost";
            this.richTextBoxNewPost.Size = new System.Drawing.Size(570, 126);
            this.richTextBoxNewPost.TabIndex = 2;
            this.richTextBoxNewPost.Text = "";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(905, 239);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(90, 28);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Post!";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(426, 239);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(90, 28);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelFaceBookItems
            // 
            this.labelFaceBookItems.AutoSize = true;
            this.labelFaceBookItems.Location = new System.Drawing.Point(162, 333);
            this.labelFaceBookItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFaceBookItems.Name = "labelFaceBookItems";
            this.labelFaceBookItems.Size = new System.Drawing.Size(0, 16);
            this.labelFaceBookItems.TabIndex = 7;
            // 
            // comboBoxFacebookItems
            // 
            this.comboBoxFacebookItems.FormattingEnabled = true;
            this.comboBoxFacebookItems.Location = new System.Drawing.Point(282, 337);
            this.comboBoxFacebookItems.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFacebookItems.Name = "comboBoxFacebookItems";
            this.comboBoxFacebookItems.Size = new System.Drawing.Size(212, 24);
            this.comboBoxFacebookItems.TabIndex = 8;
            this.comboBoxFacebookItems.Visible = false;
            this.comboBoxFacebookItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxFacebookItems_SelectedIndexChanged);
            // 
            // chartLikesByMonth
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLikesByMonth.ChartAreas.Add(chartArea1);
            this.chartLikesByMonth.Enabled = false;
            legend1.Name = "Legend1";
            this.chartLikesByMonth.Legends.Add(legend1);
            this.chartLikesByMonth.Location = new System.Drawing.Point(589, 333);
            this.chartLikesByMonth.Name = "chartLikesByMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLikesByMonth.Series.Add(series1);
            this.chartLikesByMonth.Size = new System.Drawing.Size(418, 254);
            this.chartLikesByMonth.TabIndex = 9;
            this.chartLikesByMonth.Text = "chartLikesByMonth";
            this.chartLikesByMonth.Visible = false;
            // 
            // buttonDownloadAlbum
            // 
            this.buttonDownloadAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadAlbum.AutoSize = true;
            this.buttonDownloadAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDownloadAlbum.BackgroundImage")));
            this.buttonDownloadAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(497, 332);
            this.buttonDownloadAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(45, 30);
            this.buttonDownloadAlbum.TabIndex = 11;
            this.buttonDownloadAlbum.UseVisualStyleBackColor = true;
            this.buttonDownloadAlbum.Visible = false;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            // 
            // buttonPreviousPhoto
            // 
            this.buttonPreviousPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPreviousPhoto.BackgroundImage")));
            this.buttonPreviousPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPreviousPhoto.Location = new System.Drawing.Point(282, 591);
            this.buttonPreviousPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPreviousPhoto.Name = "buttonPreviousPhoto";
            this.buttonPreviousPhoto.Size = new System.Drawing.Size(50, 22);
            this.buttonPreviousPhoto.TabIndex = 10;
            this.buttonPreviousPhoto.UseVisualStyleBackColor = true;
            this.buttonPreviousPhoto.Visible = false;
            this.buttonPreviousPhoto.Click += new System.EventHandler(this.buttonPreviousPhoto_Click);
            // 
            // buttonNextPhoto
            // 
            this.buttonNextPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNextPhoto.BackgroundImage")));
            this.buttonNextPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNextPhoto.Location = new System.Drawing.Point(492, 591);
            this.buttonNextPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNextPhoto.Name = "buttonNextPhoto";
            this.buttonNextPhoto.Size = new System.Drawing.Size(50, 22);
            this.buttonNextPhoto.TabIndex = 10;
            this.buttonNextPhoto.UseVisualStyleBackColor = true;
            this.buttonNextPhoto.Visible = false;
            this.buttonNextPhoto.Click += new System.EventHandler(this.buttonNextPhoto_Click);
            // 
            // pictureBoxFacebookItem
            // 
            this.pictureBoxFacebookItem.Location = new System.Drawing.Point(282, 372);
            this.pictureBoxFacebookItem.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFacebookItem.Name = "pictureBoxFacebookItem";
            this.pictureBoxFacebookItem.Size = new System.Drawing.Size(260, 215);
            this.pictureBoxFacebookItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFacebookItem.TabIndex = 6;
            this.pictureBoxFacebookItem.TabStop = false;
            this.pictureBoxFacebookItem.Visible = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(281, 111);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(130, 125);
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.miniToolStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miniToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.miniToolStrip.Location = new System.Drawing.Point(558, 288);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.miniToolStrip.Size = new System.Drawing.Size(264, 600);
            this.miniToolStrip.TabIndex = 0;
            // 
            // albumsToolStripMenuItem
            // 
            this.albumsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
            this.albumsToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.albumsToolStripMenuItem.Text = "Albums";
            // 
            // pagesToolStripMenuItem
            // 
            this.pagesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.pagesToolStripMenuItem.Text = "Pages";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // wallPostsToolStripMenuItem
            // 
            this.wallPostsToolStripMenuItem.Name = "wallPostsToolStripMenuItem";
            this.wallPostsToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.wallPostsToolStripMenuItem.Text = "Wall Posts";
            // 
            // Statistics
            // 
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(259, 36);
            this.Statistics.Text = "Statistics";
            // 
            // menuStripLeft
            // 
            this.menuStripLeft.AutoSize = false;
            this.menuStripLeft.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStripLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStripLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStripLeft.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripLeft.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripLeft.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.albumsToolStripMenuItem,
            this.pagesToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.wallPostsToolStripMenuItem,
            this.Statistics});
            this.menuStripLeft.Location = new System.Drawing.Point(0, 0);
            this.menuStripLeft.Name = "menuStripLeft";
            this.menuStripLeft.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStripLeft.Size = new System.Drawing.Size(264, 600);
            this.menuStripLeft.TabIndex = 0;
            this.menuStripLeft.Text = "Coose an action";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Desktop;
            this.menu.Controls.Add(this.albumsButton);
            this.menu.Controls.Add(this.pagesButton);
            this.menu.Controls.Add(this.groupsButton);
            this.menu.Controls.Add(this.postsButton);
            this.menu.Controls.Add(this.statisticsButton);
            this.menu.Controls.Add(this.buttonLogout);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 54);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(229, 602);
            this.menu.TabIndex = 12;
            // 
            // albumsButton
            // 
            this.albumsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.albumsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsButton.Image = ((System.Drawing.Image)(resources.GetObject("albumsButton.Image")));
            this.albumsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.albumsButton.Location = new System.Drawing.Point(3, 3);
            this.albumsButton.Name = "albumsButton";
            this.albumsButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.albumsButton.Size = new System.Drawing.Size(226, 41);
            this.albumsButton.TabIndex = 13;
            this.albumsButton.Text = "Albums";
            this.albumsButton.UseVisualStyleBackColor = false;
            this.albumsButton.Click += new System.EventHandler(this.albumsButton_Click);
            // 
            // pagesButton
            // 
            this.pagesButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pagesButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagesButton.Image = ((System.Drawing.Image)(resources.GetObject("pagesButton.Image")));
            this.pagesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pagesButton.Location = new System.Drawing.Point(3, 50);
            this.pagesButton.Name = "pagesButton";
            this.pagesButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.pagesButton.Size = new System.Drawing.Size(226, 41);
            this.pagesButton.TabIndex = 14;
            this.pagesButton.Text = "Pages";
            this.pagesButton.UseVisualStyleBackColor = false;
            this.pagesButton.Click += new System.EventHandler(this.pagesButton_Click);
            // 
            // groupsButton
            // 
            this.groupsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsButton.Image = ((System.Drawing.Image)(resources.GetObject("groupsButton.Image")));
            this.groupsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.groupsButton.Location = new System.Drawing.Point(3, 97);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.groupsButton.Size = new System.Drawing.Size(226, 41);
            this.groupsButton.TabIndex = 15;
            this.groupsButton.Text = "Groups";
            this.groupsButton.UseVisualStyleBackColor = false;
            this.groupsButton.Click += new System.EventHandler(this.groupsButton_Click);
            // 
            // postsButton
            // 
            this.postsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.postsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postsButton.Image = ((System.Drawing.Image)(resources.GetObject("postsButton.Image")));
            this.postsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postsButton.Location = new System.Drawing.Point(3, 144);
            this.postsButton.Name = "postsButton";
            this.postsButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.postsButton.Size = new System.Drawing.Size(226, 41);
            this.postsButton.TabIndex = 16;
            this.postsButton.Text = "Posts";
            this.postsButton.UseVisualStyleBackColor = false;
            this.postsButton.Click += new System.EventHandler(this.postsButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statisticsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statisticsButton.Image = ((System.Drawing.Image)(resources.GetObject("statisticsButton.Image")));
            this.statisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statisticsButton.Location = new System.Drawing.Point(3, 191);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.statisticsButton.Size = new System.Drawing.Size(226, 41);
            this.statisticsButton.TabIndex = 17;
            this.statisticsButton.Text = "Statistics";
            this.statisticsButton.UseVisualStyleBackColor = false;
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogout.Image")));
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(3, 238);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(226, 41);
            this.buttonLogout.TabIndex = 18;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 10;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // mostLikedPictureLabel
            // 
            this.mostLikedPictureLabel.AutoSize = true;
            this.mostLikedPictureLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostLikedPictureLabel.Location = new System.Drawing.Point(299, 333);
            this.mostLikedPictureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.mostLikedPictureLabel.Name = "mostLikedPictureLabel";
            this.mostLikedPictureLabel.Size = new System.Drawing.Size(133, 20);
            this.mostLikedPictureLabel.TabIndex = 28;
            this.mostLikedPictureLabel.Text = "Most Liked Picture:";
            this.mostLikedPictureLabel.Visible = false;
            // 
            // comboBoxForAlbum
            // 
            this.comboBoxForAlbum.FormattingEnabled = true;
            this.comboBoxForAlbum.Location = new System.Drawing.Point(484, 292);
            this.comboBoxForAlbum.Name = "comboBoxForAlbum";
            this.comboBoxForAlbum.Size = new System.Drawing.Size(234, 24);
            this.comboBoxForAlbum.TabIndex = 29;
            this.comboBoxForAlbum.Visible = false;
            this.comboBoxForAlbum.SelectedIndexChanged += new System.EventHandler(this.ComboBoxForAlbum_SelectedIndexChanged);
            // 
            // mostLikedPic
            // 
            this.mostLikedPic.Location = new System.Drawing.Point(282, 366);
            this.mostLikedPic.Name = "mostLikedPic";
            this.mostLikedPic.Size = new System.Drawing.Size(178, 145);
            this.mostLikedPic.TabIndex = 30;
            this.mostLikedPic.TabStop = false;
            this.mostLikedPic.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 656);
            this.Controls.Add(this.mostLikedPic);
            this.Controls.Add(this.comboBoxForAlbum);
            this.Controls.Add(this.mostLikedPictureLabel);
            this.Controls.Add(this.menu);
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
            this.Controls.Add(this.richTextBoxNewPost);
            this.Controls.Add(this.panelTop);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHamburger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLikesByMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.menuStripLeft.ResumeLayout(false);
            this.menuStripLeft.PerformLayout();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mostLikedPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.RichTextBox richTextBoxNewPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.PictureBox pictureBoxFacebookItem;
        private System.Windows.Forms.Label labelFaceBookItems;
        private System.Windows.Forms.ComboBox comboBoxFacebookItems;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLikesByMonth;
        private System.Windows.Forms.Button buttonNextPhoto;
        private System.Windows.Forms.Button buttonPreviousPhoto;
        private System.Windows.Forms.Button buttonDownloadAlbum;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox buttonHamburger;
        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.ToolStripMenuItem albumsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wallPostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Statistics;
        private System.Windows.Forms.MenuStrip menuStripLeft;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Button albumsButton;
        private System.Windows.Forms.Button pagesButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button postsButton;
        private System.Windows.Forms.Button statisticsButton;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label mostLikedPictureLabel;
        private System.Windows.Forms.ComboBox comboBoxForAlbum;
        private System.Windows.Forms.PictureBox mostLikedPic;
    }
}