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
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebookItem = new System.Windows.Forms.PictureBox();
            this.labelFaceBookItems = new System.Windows.Forms.Label();
            this.comboBoxFacebookItems = new System.Windows.Forms.ComboBox();
            this.chartLikesByMonth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStripLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLikesByMonth)).BeginInit();
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
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1062, 107);
            this.panelTop.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(437, 16);
            this.labelHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(303, 31);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Welcome To FaceBook!";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(129, 51);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(102, 34);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.Location = new System.Drawing.Point(129, 13);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(102, 34);
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
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 549);
            this.panel2.TabIndex = 1;
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
            this.friendsByMyLocationToolStripMenuItem});
            this.menuStripLeft.Location = new System.Drawing.Point(0, 0);
            this.menuStripLeft.Name = "menuStripLeft";
            this.menuStripLeft.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStripLeft.Size = new System.Drawing.Size(264, 547);
            this.menuStripLeft.TabIndex = 0;
            this.menuStripLeft.Text = "Coose an action";
            // 
            // albumsToolStripMenuItem
            // 
            this.albumsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumsToolStripMenuItem.Name = "albumsToolStripMenuItem";
            this.albumsToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.albumsToolStripMenuItem.Text = "Albums";
            this.albumsToolStripMenuItem.Click += new System.EventHandler(this.albumsToolStripMenuItem_Click);
            // 
            // pagesToolStripMenuItem
            // 
            this.pagesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pagesToolStripMenuItem.Name = "pagesToolStripMenuItem";
            this.pagesToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.pagesToolStripMenuItem.Text = "Pages";
            this.pagesToolStripMenuItem.Click += new System.EventHandler(this.pagesToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // wallPostsToolStripMenuItem
            // 
            this.wallPostsToolStripMenuItem.Name = "wallPostsToolStripMenuItem";
            this.wallPostsToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.wallPostsToolStripMenuItem.Text = "Wall Posts";
            this.wallPostsToolStripMenuItem.Click += new System.EventHandler(this.wallPostsToolStripMenuItem_Click);
            // 
            // friendsByMyLocationToolStripMenuItem
            // 
            this.friendsByMyLocationToolStripMenuItem.Name = "friendsByMyLocationToolStripMenuItem";
            this.friendsByMyLocationToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.friendsByMyLocationToolStripMenuItem.Text = "Frinds By My Location";
            // 
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Location = new System.Drawing.Point(426, 111);
            this.richTextBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(570, 126);
            this.richTextBoxStatus.TabIndex = 2;
            this.richTextBoxStatus.Text = "";
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
            // pictureBoxFacebookItem
            // 
            this.pictureBoxFacebookItem.Location = new System.Drawing.Point(282, 372);
            this.pictureBoxFacebookItem.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFacebookItem.Name = "pictureBoxFacebookItem";
            this.pictureBoxFacebookItem.Size = new System.Drawing.Size(260, 215);
            this.pictureBoxFacebookItem.TabIndex = 6;
            this.pictureBoxFacebookItem.TabStop = false;
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
            this.comboBoxFacebookItems.Location = new System.Drawing.Point(282, 333);
            this.comboBoxFacebookItems.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFacebookItems.Name = "comboBoxFacebookItems";
            this.comboBoxFacebookItems.Size = new System.Drawing.Size(261, 24);
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
            this.chartLikesByMonth.Location = new System.Drawing.Point(591, 333);
            this.chartLikesByMonth.Name = "chartLikesByMonth";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartLikesByMonth.Series.Add(series1);
            this.chartLikesByMonth.Size = new System.Drawing.Size(418, 254);
            this.chartLikesByMonth.TabIndex = 9;
            this.chartLikesByMonth.Text = "chartLikesByMonth";
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 656);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.menuStripLeft.ResumeLayout(false);
            this.menuStripLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLikesByMonth)).EndInit();
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
    }
}