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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStripLeft = new System.Windows.Forms.MenuStrip();
            this.albumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFaceBookItems = new System.Windows.Forms.Label();
            this.wallPostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frindsByMyLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxFacebookItems = new System.Windows.Forms.ComboBox();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStripLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1593, 97);
            this.panelTop.TabIndex = 0;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(655, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(482, 51);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Welcome To FaceBook!";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(412, 23);
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
            this.buttonLogin.Location = new System.Drawing.Point(243, 23);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(153, 53);
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
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 928);
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
            this.frindsByMyLocationToolStripMenuItem});
            this.menuStripLeft.Location = new System.Drawing.Point(0, 0);
            this.menuStripLeft.Name = "menuStripLeft";
            this.menuStripLeft.Size = new System.Drawing.Size(396, 926);
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
            // richTextBoxStatus
            // 
            this.richTextBoxStatus.Location = new System.Drawing.Point(641, 119);
            this.richTextBoxStatus.Name = "richTextBoxStatus";
            this.richTextBoxStatus.Size = new System.Drawing.Size(853, 194);
            this.richTextBoxStatus.TabIndex = 2;
            this.richTextBoxStatus.Text = "";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(1359, 319);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(135, 44);
            this.buttonPost.TabIndex = 3;
            this.buttonPost.Text = "Post!";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(641, 319);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 44);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(423, 119);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(194, 194);
            this.pictureBoxProfile.TabIndex = 4;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(423, 581);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 336);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelFaceBookItems
            // 
            this.labelFaceBookItems.AutoSize = true;
            this.labelFaceBookItems.Location = new System.Drawing.Point(243, 520);
            this.labelFaceBookItems.Name = "labelFaceBookItems";
            this.labelFaceBookItems.Size = new System.Drawing.Size(0, 25);
            this.labelFaceBookItems.TabIndex = 7;
            // 
            // wallPostsToolStripMenuItem
            // 
            this.wallPostsToolStripMenuItem.Name = "wallPostsToolStripMenuItem";
            this.wallPostsToolStripMenuItem.Size = new System.Drawing.Size(389, 54);
            this.wallPostsToolStripMenuItem.Text = "Wall Posts";
            this.wallPostsToolStripMenuItem.Click += new System.EventHandler(this.wallPostsToolStripMenuItem_Click);
            // 
            // frindsByMyLocationToolStripMenuItem
            // 
            this.frindsByMyLocationToolStripMenuItem.Name = "frindsByMyLocationToolStripMenuItem";
            this.frindsByMyLocationToolStripMenuItem.Size = new System.Drawing.Size(389, 54);
            this.frindsByMyLocationToolStripMenuItem.Text = "Frinds By My Location";
            // 
            // comboBoxFacebookItems
            // 
            this.comboBoxFacebookItems.FormattingEnabled = true;
            this.comboBoxFacebookItems.Location = new System.Drawing.Point(423, 520);
            this.comboBoxFacebookItems.Name = "comboBoxFacebookItems";
            this.comboBoxFacebookItems.Size = new System.Drawing.Size(390, 33);
            this.comboBoxFacebookItems.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 1025);
            this.Controls.Add(this.comboBoxFacebookItems);
            this.Controls.Add(this.labelFaceBookItems);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFaceBookItems;
        private System.Windows.Forms.ToolStripMenuItem wallPostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frindsByMyLocationToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxFacebookItems;
    }
}