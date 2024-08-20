using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class TitledListBox : UserControl
    {
        public TitledListBox()
        {
            InitializeComponent();
        }

        public event LinkLabelLinkClickedEventHandler LinkClicked;
        
        public string Title
        {
            get
            {
                return this.linkLabelTitle.Text;
            }
            set
            {
                this.linkLabelTitle.Text = value;
            }
        }

        [Bindable(true)]
        public string LabelText
        {
            get
            {
                return this.label.Text;
            }
            set
            {
                this.label.Text = value;
            }
        }

        public string TitleLabelText
        {
            get
            {
                return this.titleLabelText.Text;
            }
            set
            {
                this.titleLabelText.Text = value;
            }
        }

        [Bindable(true)]
        public Image Picture
        {
            get
            {
                return this.pictureBox.Image;
            }
            set
            {
                this.pictureBox.Image = value;
            }
        }

        private void linkLabelTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkClicked?.Invoke(this, e);
        }
    }
}