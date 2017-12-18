using System;
using System.Windows.Forms;

namespace PredictionScorer
{
    public partial class MainWindow : Form
    {
        private Player _currentPlayer;

        public MainWindow()
        {
            InitializeComponent();
            comboBox_Result.Items.Insert(0, " ");
            listBox_Players.SelectedIndexChanged += ListBoxPlayersOnSelectedIndexChanged;
            numericUpDown_Prediction.TextChanged += TextBoxPredictionOnTextChanged;
            comboBox_Result.SelectedIndexChanged += ComboBoxResultOnSelectedIndexChanged;
        }

        private void ComboBoxResultOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            try
            {
                _currentPlayer.Result = (GameManager.Result) Enum.Parse(typeof(GameManager.Result), comboBox_Result.SelectedItem.ToString());
            }
            catch (Exception)
            {
                _currentPlayer.Result = GameManager.Result.None;
            }
        }

        private void TextBoxPredictionOnTextChanged(object sender, EventArgs eventArgs)
        {
            try
            {
                _currentPlayer.Prediction = int.Parse(numericUpDown_Prediction.Text);
            }
            catch (Exception)
            {
                //intentionally empty
            }
        }

        private void ListBoxPlayersOnSelectedIndexChanged(object sender, EventArgs eventArgs)
        {
            if (_currentPlayer != null)
            {
                GameManager.UpdatePlayer(_currentPlayer);
            }
            _currentPlayer = GameManager.GetPlayer((string) listBox_Players.SelectedItem);
            UpdatePlayerInfo();
        }

        private void button_AddPlayer_Click(object sender, EventArgs e)
        {
            var addPlayer = new AddPlayer();
            addPlayer.ShowDialog();
            addPlayer.Dispose();
            listBox_Players.Items.Clear();
            listBox_Players.Items.AddRange(GameManager.GetPlayerNames().ToArray());
        }

        private void UpdatePlayerInfo()
        {
            if (_currentPlayer == null) return;
            label_PlayerName.Text = _currentPlayer.Name;
            label_PlayerScore.Text = _currentPlayer.Score.ToString();
            numericUpDown_Prediction.Text = _currentPlayer.Prediction.ToString();
            comboBox_Result.SelectedItem = _currentPlayer.Result == GameManager.Result.None ? " " : _currentPlayer.Result.ToString();
        }

        private void button_StartGame_Click(object sender, EventArgs e)
        {
            if (listBox_Players.Items.Count < 1)
            {
                var error = new Error("Please add at least one player");
                error.ShowDialog();
                return;
            }

            GameManager.StartGame();

            listBox_Players.SelectedIndex = 0;

            label_PlayerName.Visible = true;
            label_PlayerScore.Visible = true;
            label_CardPerHand.Visible = true;

            button_AddPlayer.Enabled = false;
            button_LockPredictions.Enabled = true;
            numericUpDown_Prediction.Enabled = true;
            
            button_StartGame.Enabled = false;
        }

        private void button_LockPredictions_Click(object sender, EventArgs e)
        {
            if (GameManager.VerifyValidPredictions())
            {
                comboBox_Result.Enabled = true;
                button_EndRound.Enabled = true;
                numericUpDown_Prediction.ReadOnly = true;
                button_LockPredictions.Enabled = false;
            }
            else
            {
                var error = new Error("Please enter valid predictions for all players");
                error.ShowDialog();
            }
        }

        private void button_EndRound_Click(object sender, EventArgs e)
        {
            if (GameManager.VerifyValidResults())
            {
                if (GameManager.Round <= 18)
                {
                    GameManager.EndRound();
                    comboBox_Result.Text = "";
                    comboBox_Result.Enabled = false;
                    numericUpDown_Prediction.ReadOnly = false;
                    button_EndRound.Enabled = false;
                    button_LockPredictions.Enabled = true;
                    label_CardPerHand.Text = GameManager.Cards.ToString();
                    UpdatePlayerInfo();
                }
                else
                {
                    GameManager.EndRound();
                    UpdatePlayerInfo();
                    var name = GameManager.GetWinnerName();
                    PresentWinner(name);
                }
            }
            else
            {
                var error = new Error("Please select a result for each player");
                error.ShowDialog();
            }
        }

        private void PresentWinner(string name)
        {
            label_Winner.Text = name;
            label_Winner.Visible = true;
            label_WinnerPreface.Visible = true;
        }
    }
}
