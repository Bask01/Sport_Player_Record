using System;
using System.Collections.Generic;
using System.Text;

namespace As1KubraBas
{
    class BasketballPlayer : Player
    {

        private int _threePointers;
        private int _fieldGoals;
        private int _totalPoints;
        private PlayerType type;

        public BasketballPlayer() { }

        public int ThreePointers { get; set; }
        public int FieldGoals { get; set; }
        public int TotalPoints { get; }


        public BasketballPlayer(int playerId, string playerName, string teamName, int gamesPlayed,
                                int threePointers, int fieldGoals) : base(playerId, playerName, teamName, gamesPlayed)
        {
            _threePointers = threePointers;
            _fieldGoals = fieldGoals;
            Points();
        }

        public override int Points()
        {
            _totalPoints = (_fieldGoals - _threePointers) + (2 * _threePointers);
            return _totalPoints;
        }

        public override PlayerType Type()
        {
            type = PlayerType.BasketballPlayer;
            return type;
        }

        public override string ToString()
        {
            return String.Format($"{type,-16} | {PlayerId,9} | {PlayerName,-20} | {TeamName,-15} | {GamesPlayed,12} |" +
                                 $" {_threePointers,10} | {_fieldGoals,11} | {Points(),8}\n");
        }
    }
}
