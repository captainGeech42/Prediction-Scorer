using System.Collections.Generic;
using System.Linq;

namespace PredictionScorer
{
    public static class GameManager
    {
        private static readonly List<Player> Players = new List<Player>();
        public static int Round { get; private set; }
        public static int Cards { get; private set; }

        public static bool AddPlayer(Player player)
        {
            var existing = Players.FirstOrDefault(p => p.Name == player.Name);
            if (existing != null) return false;
            Players.Add(player);
            return true;
        }

        public static void StartGame()
        {
            Round = 1;
            Cards = 1;
        }


        public static void UpdatePlayer(Player player)
        {
            var index = Players.IndexOf(Players.FirstOrDefault(p => p.Name == player.Name));
            Players.RemoveAt(index);
            Players.Insert(index, player);
        }

        public static List<object> GetPlayerNames()
        {
            var names = new List<object>();
            Players.ForEach(p => names.Add(p.Name));
            names.Sort();
            return names;
        }

        public static Player GetPlayer(string name)
        {
            return Players.Single(p => p.Name == name);
        }

        public static void EndRound()
        {
            Round++;
            if (Round > 10)
            {
                Cards--;
            }
            else
            {
                Cards++;
            }
            foreach (var player in Players)
            {
                if (player.Result == Result.Make)
                {
                    player.Score += 10 + player.Prediction;
                }
                player.Result = Result.None;
                player.Prediction = 0;
            }
        }

        public static bool VerifyValidPredictions()
        {
            var player = Players.FirstOrDefault(p => p.Prediction < 0 || p.Prediction > Cards);
            return player == null;
        }

        public static bool VerifyValidResults()
        {
            var player = Players.FirstOrDefault(p => p.Result == Result.None);
            return player == null;
        }

        public static string GetWinnerName()
        {
            var finalScore = 0;
            var name = "";
            foreach (var player in Players)
            {
                if (player.Score > finalScore)
                {
                    name = player.Name;
                }
            }
            return name;
        }

        public enum Result
        {
            Make,
            Miss,
            None
        }
    }
}
