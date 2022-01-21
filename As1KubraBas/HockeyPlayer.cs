using System;
using System.Collections.Generic;
using System.Text;

namespace As1KubraBas
{
    class HockeyPlayer: Player
    {

        public int _assists;
        public int _goals;
        public int totalPoints;
        private PlayerType type;

        
     
        public int Assists { get; set; }
        

        public int Goals { get; set; }

        public int TotalPoints { get;}

        public HockeyPlayer() { }
        public HockeyPlayer(int playerId, string playerName, string teamName, int gamesPlayed, int assists, int goals)
                     : base(playerId, playerName, teamName, gamesPlayed)

        {

            _assists = assists;
            _goals = goals;
            Points();
        }


        public override int Points()
        {
            totalPoints = _assists + (2 * _goals);
            return totalPoints;
        }
        public override PlayerType Type()
        {

            type = PlayerType.HockeyPlayer;
            return type;
        }


      public override string ToString()
        {

            return String.Format($"{type,-16} | {PlayerId,9} | {PlayerName,-20} | {TeamName,-15} | {GamesPlayed,12} |" +
                                 $" {_assists,10} | {_goals,11} | {Points(),8}\n");  
        }

    }
}
