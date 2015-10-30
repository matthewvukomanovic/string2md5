using System;
using System.Windows.Forms;
using string2md5;

namespace string2md5g
{
    public partial class MD5Form : Form
    {
        public MD5Form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            md5OutputControl.Text = MD5Generation.GetMD5FromString(inputControl.Text);
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(md5OutputControl.Text);
        }
    }
}
