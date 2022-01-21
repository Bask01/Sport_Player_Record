using System;
using System.Collections.Generic;
using System.Text;

namespace As1KubraBas
{
    class BaseballPlayer : Player
    {

        private int _runs;
        private int _homeRuns;
        private int _totalPoints;
        private PlayerType type;

        public int Runs { get; set; }
        public int HomeRuns { get; set; }
        public int TotalPoints { get; }


        public BaseballPlayer() { }
        public BaseballPlayer(int playerId, string playerName, string teamName, int gamesPlayed, int runs, int homeRuns)
                         : base(playerId, playerName, teamName, gamesPlayed)
        {
            _runs = runs;
            _homeRuns = homeRuns;
            Points();
        }

        public override int Points()
        {
            _totalPoints = (_runs - _homeRuns) + (2 * _homeRuns);
            return _totalPoints;
        }

        public override PlayerType Type()
        {

            type = PlayerType.BaseBallPlayer;
            return type;
        }

        public override string ToString()
        {
            return String.Format($"{type,-16} | {PlayerId,9} | {PlayerName,-20} | {TeamName,-15} | {GamesPlayed,12} |" +
                                 $" {_runs,10} | {_homeRuns,11} | {Points(),8}\n");
        }
    }
}

