namespace PredictionScorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Score { get; set; }
        public int Prediction { get; set; }
        public GameManager.Result Result { get; set; }

        public Player(string name)
        {
            this.Name = name;
            Result = GameManager.Result.None;
        }
    }
}
