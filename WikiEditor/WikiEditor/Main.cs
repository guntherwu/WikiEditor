using System;
using System.Text.RegularExpressions;
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
            codeTB.Text = "<h1>Hello World</h1>\r\n<p>Welcome to the WikiEditor</p>\r\n==Hello World==\r\nWelcome to the WikiEditor";
            previewBrowser.DocumentText = codeTB.Text;
        }

        private void clickListener(int index)
        {
            switch (index)
            {
                case 0:
                    break;
                case 1:
                    previewCode(languageCB.SelectedItem.ToString());
                    break;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            clickListener(tabControl.SelectedIndex);
        }

        private void previewCode(String code)
        {
            switch (code)
            {
                case "HTML":
                    previewBrowser.DocumentText = codeTB.Text;
                    break;
                case "WikiCreole":
                    String originalContent = codeTB.Text;
                    String content = "";
                    RegexOptions options = RegexOptions.IgnorePatternWhitespace | RegexOptions.Multiline;

                    content = Regex.Replace(originalContent, "^==", "<h1>", options);
                    content = Regex.Replace(content, "==", "</h1>", options);

                    content = Regex.Replace(content, "^//", "<i>", options);
                    content = Regex.Replace(content, "//", "</i>", options);

                    content = Regex.Replace(content, "^" + Regex.Escape("**"), "<b>", options);
                    content = Regex.Replace(content, Regex.Escape("**"), "</b>", options);

                    previewBrowser.DocumentText = content;
                    break;
            }
        }
    }
}
