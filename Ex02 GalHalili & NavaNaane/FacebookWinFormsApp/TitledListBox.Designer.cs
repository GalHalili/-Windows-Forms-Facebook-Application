namespace BasicFacebookFeatures
{
    partial class TitledListBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.linkLabelTitle = new System.Windows.Forms.LinkLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleLabelText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelTitle
            // 
            this.linkLabelTitle.AutoSize = true;
            this.linkLabelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelTitle.Location = new System.Drawing.Point(0, 0);
            this.linkLabelTitle.Name = "linkLabelTitle";
            this.linkLabelTitle.Size = new System.Drawing.Size(80, 20);
            this.linkLabelTitle.TabIndex = 0;
            this.linkLabelTitle.TabStop = true;
            this.linkLabelTitle.Text = "linkLabel1";
            this.linkLabelTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTitle_LinkClicked);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox.Location = new System.Drawing.Point(86, 20);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(296, 96);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(331, 147);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(51, 20);
            this.label.TabIndex = 3;
            this.label.Text = "label1";
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // titleLabelText
            // 
            this.titleLabelText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabelText.AutoSize = true;
            this.titleLabelText.Location = new System.Drawing.Point(251, 147);
            this.titleLabelText.Name = "titleLabelText";
            this.titleLabelText.Size = new System.Drawing.Size(72, 20);
            this.titleLabelText.TabIndex = 4;
            this.titleLabelText.Text = "labelText";
            // 
            // TitledListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLabelText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.linkLabelTitle);
            this.Name = "TitledListBox";
            this.Size = new System.Drawing.Size(382, 167);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelTitle;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Label titleLabelText;
    }
}
