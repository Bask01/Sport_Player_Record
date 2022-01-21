using System;
using System.Collections.Generic;
using System.Text;

namespace As1KubraBas


{

    public enum PlayerType
    {
        HockeyPlayer, BasketballPlayer, BaseBallPlayer
    }

    public abstract class Player
    {


        private int playerId;
        private string playerName;
        private string teamName;
        private int gamesPlayed;

        public Player() { }

        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public string TeamName { get; set; }

        public int GamesPlayed { get; set; }

        public Player(int playerId, string playerName, string teamName,
                int gamesPlayed)
        {
            PlayerId = playerId;
            PlayerName = playerName;
            TeamName = teamName;
            GamesPlayed = gamesPlayed;
        }

        public abstract PlayerType Type();


        public abstract int Points();

    }
}
