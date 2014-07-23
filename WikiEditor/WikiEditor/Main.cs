using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WikiEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            setDefaults();
        }

        private void setDefaults()
        {
            languageCB.SelectedIndex = 0;
            codeTB.Text = "<h1>Hello World</h1>\r\n<p>Welcome to the WikiEditor</p>";
            previewBrowser.DocumentText = codeTB.Text;
        }

        private void clickListener(int index)
        {
            switch (index)
            {
                case 0:
                    break;
                case 1:
                    if (languageCB.SelectedItem.ToString().Equals("HTML"))
                    {
                        previewBrowser.DocumentText = codeTB.Text;
                    }
                    else
                    {
                        MessageBox.Show("Not HTML");
                    }
                    break;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            clickListener(tabControl.SelectedIndex);
        }
    }
}
