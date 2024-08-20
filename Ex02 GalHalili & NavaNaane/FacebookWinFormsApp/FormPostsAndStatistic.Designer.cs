namespace BasicFacebookFeatures
{
    partial class FormPostsAndStatistic
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
            System.Windows.Forms.Label messageLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label nameLabel;
            this.titledDataLabelMaleLikes = new BasicFacebookFeatures.TitledDataLabel();
            this.titledDataLabelFemaleLikes = new BasicFacebookFeatures.TitledDataLabel();
            this.titledDataLabelLikes = new BasicFacebookFeatures.TitledDataLabel();
            this.titledDataLabelComments = new BasicFacebookFeatures.TitledDataLabel();
            this.titleledTextBoxPost = new BasicFacebookFeatures.TitleledTextBox();
            this.buttonSetStatus = new System.Windows.Forms.Button();
            this.labelUserInstructions = new System.Windows.Forms.Label();
            this.buttonShowStatistics = new System.Windows.Forms.Button();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkLabelFetchPosts = new System.Windows.Forms.LinkLabel();
            this.buttonSaveStatistics = new System.Windows.Forms.Button();
            this.labelPostStatistic = new System.Windows.Forms.Label();
            this.listBoxPostType = new System.Windows.Forms.ListBox();
            this.TextBoxPostMessage = new System.Windows.Forms.TextBox();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            messageLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(141, 173);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(78, 20);
            messageLabel.TabIndex = 24;
            messageLabel.Text = "Message:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(439, 249);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(108, 20);
            createdTimeLabel.TabIndex = 25;
            createdTimeLabel.Text = "Created Time:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(439, 209);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 27;
            nameLabel.Text = "Name:";
            // 
            // titledDataLabelMaleLikes
            // 
            this.titledDataLabelMaleLikes.DataText = "0";
            this.titledDataLabelMaleLikes.Location = new System.Drawing.Point(902, 355);
            this.titledDataLabelMaleLikes.Margin = new System.Windows.Forms.Padding(4);
            this.titledDataLabelMaleLikes.Name = "titledDataLabelMaleLikes";
            this.titledDataLabelMaleLikes.Size = new System.Drawing.Size(303, 29);
            this.titledDataLabelMaleLikes.TabIndex = 23;
            this.titledDataLabelMaleLikes.Title = "Male\'s Likes:";
            // 
            // titledDataLabelFemaleLikes
            // 
            this.titledDataLabelFemaleLikes.DataText = "0";
            this.titledDataLabelFemaleLikes.Location = new System.Drawing.Point(902, 312);
            this.titledDataLabelFemaleLikes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.titledDataLabelFemaleLikes.Name = "titledDataLabelFemaleLikes";
            this.titledDataLabelFemaleLikes.Size = new System.Drawing.Size(303, 34);
            this.titledDataLabelFemaleLikes.TabIndex = 22;
            this.titledDataLabelFemaleLikes.Title = "Female\'s Likes:";
            // 
            // titledDataLabelLikes
            // 
            this.titledDataLabelLikes.DataText = "0";
            this.titledDataLabelLikes.Location = new System.Drawing.Point(902, 264);
            this.titledDataLabelLikes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.titledDataLabelLikes.Name = "titledDataLabelLikes";
            this.titledDataLabelLikes.Size = new System.Drawing.Size(303, 38);
            this.titledDataLabelLikes.TabIndex = 21;
            this.titledDataLabelLikes.Title = "Likes:";
            // 
            // titledDataLabelComments
            // 
            this.titledDataLabelComments.DataText = "0";
            this.titledDataLabelComments.Location = new System.Drawing.Point(902, 401);
            this.titledDataLabelComments.Margin = new System.Windows.Forms.Padding(4);
            this.titledDataLabelComments.Name = "titledDataLabelComments";
            this.titledDataLabelComments.Size = new System.Drawing.Size(303, 29);
            this.titledDataLabelComments.TabIndex = 20;
            this.titledDataLabelComments.Title = "Comments:";
            // 
            // titleledTextBoxPost
            // 
            this.titleledTextBoxPost.Location = new System.Drawing.Point(25, 47);
            this.titleledTextBoxPost.Margin = new System.Windows.Forms.Padding(4);
            this.titleledTextBoxPost.Name = "titleledTextBoxPost";
            this.titleledTextBoxPost.Size = new System.Drawing.Size(539, 59);
            this.titleledTextBoxPost.TabIndex = 19;
            this.titleledTextBoxPost.Title = "Post Status:";
            this.titleledTextBoxPost.UserText = "";
            // 
            // buttonSetStatus
            // 
            this.buttonSetStatus.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSetStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSetStatus.Location = new System.Drawing.Point(613, 61);
            this.buttonSetStatus.Name = "buttonSetStatus";
            this.buttonSetStatus.Size = new System.Drawing.Size(75, 34);
            this.buttonSetStatus.TabIndex = 18;
            this.buttonSetStatus.Text = "Post";
            this.buttonSetStatus.UseVisualStyleBackColor = false;
            this.buttonSetStatus.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // labelUserInstructions
            // 
            this.labelUserInstructions.AutoSize = true;
            this.labelUserInstructions.Location = new System.Drawing.Point(82, 470);
            this.labelUserInstructions.Name = "labelUserInstructions";
            this.labelUserInstructions.Size = new System.Drawing.Size(501, 20);
            this.labelUserInstructions.TabIndex = 17;
            this.labelUserInstructions.Text = "Select a post from the list and click the button to see statistics about it";
            // 
            // buttonShowStatistics
            // 
            this.buttonShowStatistics.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonShowStatistics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonShowStatistics.Location = new System.Drawing.Point(224, 535);
            this.buttonShowStatistics.Name = "buttonShowStatistics";
            this.buttonShowStatistics.Size = new System.Drawing.Size(181, 39);
            this.buttonShowStatistics.TabIndex = 16;
            this.buttonShowStatistics.Text = "Show Statistics";
            this.buttonShowStatistics.UseVisualStyleBackColor = false;
            this.buttonShowStatistics.Click += new System.EventHandler(this.buttonShowStatistics_Click);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // linkLabelFetchPosts
            // 
            this.linkLabelFetchPosts.AutoSize = true;
            this.linkLabelFetchPosts.Location = new System.Drawing.Point(21, 173);
            this.linkLabelFetchPosts.Name = "linkLabelFetchPosts";
            this.linkLabelFetchPosts.Size = new System.Drawing.Size(98, 20);
            this.linkLabelFetchPosts.TabIndex = 14;
            this.linkLabelFetchPosts.TabStop = true;
            this.linkLabelFetchPosts.Text = "Fetch Posts:";
            this.linkLabelFetchPosts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFetchPosts_LinkClicked);
            // 
            // buttonSaveStatistics
            // 
            this.buttonSaveStatistics.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSaveStatistics.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveStatistics.Location = new System.Drawing.Point(983, 488);
            this.buttonSaveStatistics.Name = "buttonSaveStatistics";
            this.buttonSaveStatistics.Size = new System.Drawing.Size(178, 45);
            this.buttonSaveStatistics.TabIndex = 13;
            this.buttonSaveStatistics.Text = "Save Statistics";
            this.buttonSaveStatistics.UseVisualStyleBackColor = false;
            this.buttonSaveStatistics.Click += new System.EventHandler(this.buttonSavePostStatistics_Click);
            // 
            // labelPostStatistic
            // 
            this.labelPostStatistic.AutoSize = true;
            this.labelPostStatistic.Location = new System.Drawing.Point(1002, 218);
            this.labelPostStatistic.Name = "labelPostStatistic";
            this.labelPostStatistic.Size = new System.Drawing.Size(110, 20);
            this.labelPostStatistic.TabIndex = 12;
            this.labelPostStatistic.Text = "Post Statistics";
            // 
            // listBoxPostType
            // 
            this.listBoxPostType.DataSource = this.postBindingSource;
            this.listBoxPostType.DisplayMember = "Type";
            this.listBoxPostType.FormattingEnabled = true;
            this.listBoxPostType.ItemHeight = 20;
            this.listBoxPostType.Location = new System.Drawing.Point(25, 206);
            this.listBoxPostType.Name = "listBoxPostType";
            this.listBoxPostType.Size = new System.Drawing.Size(94, 224);
            this.listBoxPostType.TabIndex = 24;
            this.listBoxPostType.SelectedIndexChanged += new System.EventHandler(this.listBoxPostType_SelectedIndexChanged);
            // 
            // TextBoxPostMessage
            // 
            this.TextBoxPostMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.TextBoxPostMessage.Location = new System.Drawing.Point(145, 206);
            this.TextBoxPostMessage.Multiline = true;
            this.TextBoxPostMessage.Name = "TextBoxPostMessage";
            this.TextBoxPostMessage.Size = new System.Drawing.Size(271, 224);
            this.TextBoxPostMessage.TabIndex = 25;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(553, 249);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(144, 27);
            this.createdTimeLabel1.TabIndex = 26;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(553, 209);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(144, 28);
            this.nameLabel1.TabIndex = 28;
            // 
            // FormPostsAndStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 630);
            this.Controls.Add(createdTimeLabel);
            this.Controls.Add(this.createdTimeLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(messageLabel);
            this.Controls.Add(this.TextBoxPostMessage);
            this.Controls.Add(this.listBoxPostType);
            this.Controls.Add(this.titledDataLabelMaleLikes);
            this.Controls.Add(this.titledDataLabelFemaleLikes);
            this.Controls.Add(this.titledDataLabelLikes);
            this.Controls.Add(this.titledDataLabelComments);
            this.Controls.Add(this.titleledTextBoxPost);
            this.Controls.Add(this.buttonSetStatus);
            this.Controls.Add(this.labelUserInstructions);
            this.Controls.Add(this.buttonShowStatistics);
            this.Controls.Add(this.linkLabelFetchPosts);
            this.Controls.Add(this.buttonSaveStatistics);
            this.Controls.Add(this.labelPostStatistic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormPostsAndStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPostsAndStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TitledDataLabel titledDataLabelMaleLikes;
        private TitledDataLabel titledDataLabelFemaleLikes;
        private TitledDataLabel titledDataLabelLikes;
        private TitledDataLabel titledDataLabelComments;
        private TitleledTextBox titleledTextBoxPost;
        private System.Windows.Forms.Button buttonSetStatus;
        private System.Windows.Forms.Label labelUserInstructions;
        private System.Windows.Forms.Button buttonShowStatistics;
        private System.Windows.Forms.LinkLabel linkLabelFetchPosts;
        private System.Windows.Forms.Button buttonSaveStatistics;
        private System.Windows.Forms.Label labelPostStatistic;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.ListBox listBoxPostType;
        private System.Windows.Forms.TextBox TextBoxPostMessage;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.Label nameLabel1;
    }
}