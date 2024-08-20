using System.ComponentModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    [ComplexBindingProperties("DataSource", "DataMember")]
    public partial class TitledDataLabel : UserControl
    {
        public TitledDataLabel()
        {
            InitializeComponent();
        }

        public string Title
        {
            get 
            { 
                return this.labelTitle.Text; 
            }
            set 
            { 
                this.labelTitle.Text = value; 
            }
        }

        public string DataText
        {
            get 
            { 
                return this.labelData.Text; 
            }
            set 
            { 
                this.labelData.Text = value; 
            }
        }
    }
}