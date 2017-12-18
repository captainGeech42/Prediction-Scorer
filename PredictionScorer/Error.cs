using System;
using System.Windows.Forms;

namespace PredictionScorer
{
    public partial class Error : Form
    {
        public Error(string message)
        {
            InitializeComponent();
            textBox_Message.Text = message;
            textBox_Message.Select(0, 0);
            textBox_Message.GotFocus += TextBoxMessageOnGotFocus;
        }

        private void TextBoxMessageOnGotFocus(object sender, EventArgs eventArgs)
        {
            NativeMethods.HideCaret(this.Handle);
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
