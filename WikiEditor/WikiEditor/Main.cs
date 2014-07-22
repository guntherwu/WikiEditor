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
    }
}
