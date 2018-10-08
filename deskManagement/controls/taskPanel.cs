using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deskManagement.controls
{
    public partial class taskPanel : UserControl
    {
        public taskPanel()
        {
            InitializeComponent();
        }

        public Image ImageDefault
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        public string LabelStatus
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string LabelNome
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
    }
}
