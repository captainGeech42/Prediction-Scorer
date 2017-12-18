namespace PredictionScorer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button_AddPlayer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Players = new System.Windows.Forms.ListBox();
            this.label_PlayerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_PlayerScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_CardPerHand = new System.Windows.Forms.Label();
            this.button_StartGame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Result = new System.Windows.Forms.ComboBox();
            this.button_LockPredictions = new System.Windows.Forms.Button();
            this.button_EndRound = new System.Windows.Forms.Button();
            this.label_WinnerPreface = new System.Windows.Forms.Label();
            this.label_Winner = new System.Windows.Forms.Label();
            this.numericUpDown_Prediction = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Prediction)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AddPlayer
            // 
            this.button_AddPlayer.Location = new System.Drawing.Point(12, 12);
            this.button_AddPlayer.Name = "button_AddPlayer";
            this.button_AddPlayer.Size = new System.Drawing.Size(132, 23);
            this.button_AddPlayer.TabIndex = 0;
            this.button_AddPlayer.Text = "Add Player";
            this.button_AddPlayer.UseVisualStyleBackColor = true;
            this.button_AddPlayer.Click += new System.EventHandler(this.button_AddPlayer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Player:";
            // 
            // listBox_Players
            // 
            this.listBox_Players.FormattingEnabled = true;
            this.listBox_Players.Location = new System.Drawing.Point(13, 42);
            this.listBox_Players.Name = "listBox_Players";
            this.listBox_Players.Size = new System.Drawing.Size(131, 134);
            this.listBox_Players.TabIndex = 2;
            // 
            // label_PlayerName
            // 
            this.label_PlayerName.AutoSize = true;
            this.label_PlayerName.Location = new System.Drawing.Point(244, 42);
            this.label_PlayerName.Name = "label_PlayerName";
            this.label_PlayerName.Size = new System.Drawing.Size(67, 13);
            this.label_PlayerName.TabIndex = 3;
            this.label_PlayerName.Text = "Player Name";
            this.label_PlayerName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Score:";
            // 
            // label_PlayerScore
            // 
            this.label_PlayerScore.AutoSize = true;
            this.label_PlayerScore.Location = new System.Drawing.Point(206, 59);
            this.label_PlayerScore.Name = "label_PlayerScore";
            this.label_PlayerScore.Size = new System.Drawing.Size(13, 13);
            this.label_PlayerScore.TabIndex = 5;
            this.label_PlayerScore.Text = "0";
            this.label_PlayerScore.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cards Per Hand:";
            // 
            // label_CardPerHand
            // 
            this.label_CardPerHand.AutoSize = true;
            this.label_CardPerHand.Location = new System.Drawing.Point(253, 17);
            this.label_CardPerHand.Name = "label_CardPerHand";
            this.label_CardPerHand.Size = new System.Drawing.Size(13, 13);
            this.label_CardPerHand.TabIndex = 7;
            this.label_CardPerHand.Text = "1";
            this.label_CardPerHand.Visible = false;
            // 
            // button_StartGame
            // 
            this.button_StartGame.Location = new System.Drawing.Point(13, 183);
            this.button_StartGame.Name = "button_StartGame";
            this.button_StartGame.Size = new System.Drawing.Size(131, 23);
            this.button_StartGame.TabIndex = 8;
            this.button_StartGame.Text = "Start Game";
            this.button_StartGame.UseVisualStyleBackColor = true;
            this.button_StartGame.Click += new System.EventHandler(this.button_StartGame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Prediction:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Result:";
            // 
            // comboBox_Result
            // 
            this.comboBox_Result.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Result.Enabled = false;
            this.comboBox_Result.FormattingEnabled = true;
            this.comboBox_Result.Items.AddRange(new object[] {
            "Make",
            "Miss"});
            this.comboBox_Result.Location = new System.Drawing.Point(217, 120);
            this.comboBox_Result.Name = "comboBox_Result";
            this.comboBox_Result.Size = new System.Drawing.Size(126, 21);
            this.comboBox_Result.TabIndex = 13;
            // 
            // button_LockPredictions
            // 
            this.button_LockPredictions.Enabled = false;
            this.button_LockPredictions.Location = new System.Drawing.Point(13, 213);
            this.button_LockPredictions.Name = "button_LockPredictions";
            this.button_LockPredictions.Size = new System.Drawing.Size(131, 23);
            this.button_LockPredictions.TabIndex = 14;
            this.button_LockPredictions.Text = "Lock Predictions";
            this.button_LockPredictions.UseVisualStyleBackColor = true;
            this.button_LockPredictions.Click += new System.EventHandler(this.button_LockPredictions_Click);
            // 
            // button_EndRound
            // 
            this.button_EndRound.Enabled = false;
            this.button_EndRound.Location = new System.Drawing.Point(13, 243);
            this.button_EndRound.Name = "button_EndRound";
            this.button_EndRound.Size = new System.Drawing.Size(131, 23);
            this.button_EndRound.TabIndex = 15;
            this.button_EndRound.Text = "End Round";
            this.button_EndRound.UseVisualStyleBackColor = true;
            this.button_EndRound.Click += new System.EventHandler(this.button_EndRound_Click);
            // 
            // label_WinnerPreface
            // 
            this.label_WinnerPreface.AutoSize = true;
            this.label_WinnerPreface.Location = new System.Drawing.Point(173, 183);
            this.label_WinnerPreface.Name = "label_WinnerPreface";
            this.label_WinnerPreface.Size = new System.Drawing.Size(100, 13);
            this.label_WinnerPreface.TabIndex = 16;
            this.label_WinnerPreface.Text = "And, the winner is...";
            this.label_WinnerPreface.Visible = false;
            // 
            // label_Winner
            // 
            this.label_Winner.AutoSize = true;
            this.label_Winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Winner.Location = new System.Drawing.Point(193, 218);
            this.label_Winner.Name = "label_Winner";
            this.label_Winner.Size = new System.Drawing.Size(90, 16);
            this.label_Winner.TabIndex = 17;
            this.label_Winner.Text = "Player Name!";
            this.label_Winner.Visible = false;
            // 
            // numericUpDown_Prediction
            // 
            this.numericUpDown_Prediction.Enabled = false;
            this.numericUpDown_Prediction.Location = new System.Drawing.Point(234, 95);
            this.numericUpDown_Prediction.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Prediction.Name = "numericUpDown_Prediction";
            this.numericUpDown_Prediction.Size = new System.Drawing.Size(109, 20);
            this.numericUpDown_Prediction.TabIndex = 18;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 278);
            this.Controls.Add(this.numericUpDown_Prediction);
            this.Controls.Add(this.label_Winner);
            this.Controls.Add(this.label_WinnerPreface);
            this.Controls.Add(this.button_EndRound);
            this.Controls.Add(this.button_LockPredictions);
            this.Controls.Add(this.comboBox_Result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_StartGame);
            this.Controls.Add(this.label_CardPerHand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_PlayerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_PlayerName);
            this.Controls.Add(this.listBox_Players);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_AddPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Prediction Scorer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Prediction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Players;
        private System.Windows.Forms.Label label_PlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_PlayerScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_CardPerHand;
        private System.Windows.Forms.Button button_StartGame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Result;
        private System.Windows.Forms.Button button_LockPredictions;
        private System.Windows.Forms.Button button_EndRound;
        private System.Windows.Forms.Label label_WinnerPreface;
        private System.Windows.Forms.Label label_Winner;
        private System.Windows.Forms.NumericUpDown numericUpDown_Prediction;
    }
}

