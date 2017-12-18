using System;
using System.Windows.Forms;

namespace PredictionScorer
{
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }

        private void button_AddPlayer_Click(object sender, EventArgs e)
        {
            if (!GameManager.AddPlayer(new Player(textBox_Name.Text)))
            {
                var error = new Error("Duplicate player names are not allowed");
                error.ShowDialog();
                error.Dispose();
            }
            this.Dispose();
        }
    }
}
