namespace BasicFacebookFeatures
{
    partial class FormFilterFriends
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
            this.checkedListBoxFilterFeatures = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxFriendsListAfterFilter = new System.Windows.Forms.ListBox();
            this.comboBoxPrivacy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCreateGroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.titleledTextBoxGroupName = new BasicFacebookFeatures.TitleledTextBox();
            this.SuspendLayout();
            // 
            // checkedListBoxFilterFeatures
            // 
            this.checkedListBoxFilterFeatures.FormattingEnabled = true;
            this.checkedListBoxFilterFeatures.Location = new System.Drawing.Point(51, 131);
            this.checkedListBoxFilterFeatures.Name = "checkedListBoxFilterFeatures";
            this.checkedListBoxFilterFeatures.Size = new System.Drawing.Size(150, 142);
            this.checkedListBoxFilterFeatures.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select the categories by which you would like to filter your friends list";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Filtered Friends List:";
            // 
            // listBoxFriendsListAfterFilter
            // 
            this.listBoxFriendsListAfterFilter.FormattingEnabled = true;
            this.listBoxFriendsListAfterFilter.ItemHeight = 20;
            this.listBoxFriendsListAfterFilter.Location = new System.Drawing.Point(307, 131);
            this.listBoxFriendsListAfterFilter.Name = "listBoxFriendsListAfterFilter";
            this.listBoxFriendsListAfterFilter.Size = new System.Drawing.Size(191, 184);
            this.listBoxFriendsListAfterFilter.TabIndex = 3;
            // 
            // comboBoxPrivacy
            // 
            this.comboBoxPrivacy.FormattingEnabled = true;
            this.comboBoxPrivacy.Location = new System.Drawing.Point(827, 285);
            this.comboBoxPrivacy.Name = "comboBoxPrivacy";
            this.comboBoxPrivacy.Size = new System.Drawing.Size(181, 28);
            this.comboBoxPrivacy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Privacy:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(51, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Show Friends";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonShowFilteredFriendsList_Click);
            // 
            // buttonCreateGroup
            // 
            this.buttonCreateGroup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCreateGroup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCreateGroup.Location = new System.Drawing.Point(518, 368);
            this.buttonCreateGroup.Name = "buttonCreateGroup";
            this.buttonCreateGroup.Size = new System.Drawing.Size(129, 41);
            this.buttonCreateGroup.TabIndex = 7;
            this.buttonCreateGroup.Text = "Create Group";
            this.buttonCreateGroup.UseVisualStyleBackColor = false;
            this.buttonCreateGroup.Click += new System.EventHandler(this.buttonCreateGroup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(601, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "When creating a group, an email will be sent to all your friend who appeared in a" +
    "bove\r\n";
            // 
            // titleledTextBoxGroupName
            // 
            this.titleledTextBoxGroupName.Location = new System.Drawing.Point(827, 163);
            this.titleledTextBoxGroupName.Name = "titleledTextBoxGroupName";
            this.titleledTextBoxGroupName.Size = new System.Drawing.Size(181, 59);
            this.titleledTextBoxGroupName.TabIndex = 9;
            this.titleledTextBoxGroupName.Title = "Group Name:";
            this.titleledTextBoxGroupName.UserText = "";
            // 
            // FormFilterFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 545);
            this.Controls.Add(this.titleledTextBoxGroupName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCreateGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPrivacy);
            this.Controls.Add(this.listBoxFriendsListAfterFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxFilterFeatures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFilterFriends";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFilterFriends";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxFilterFeatures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFriendsListAfterFilter;
        private System.Windows.Forms.ComboBox comboBoxPrivacy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCreateGroup;
        private System.Windows.Forms.Label label4;
        private TitleledTextBox titleledTextBoxGroupName;
    }
}