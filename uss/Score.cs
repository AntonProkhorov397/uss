using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uss
{
    internal class Score
    {
        private int score;
        public int level;
        public int speed;
        public Score(int score, int level)
        {
            this.score = score;
            this.level = level;
        }
        public bool ScoreUp()//Увеличение очков
        {
            score += 1;
            if (score % 10 == 0)//с каждыми 10 очками уровень повышается
            {
                level += 1;
                return true;
            }
            else { return false; }
        }
        public void ScoreWrite()
        {
            Console.SetCursorPosition(70, 1);
            Console.WriteLine("Score:" + score.ToString());
            Console.SetCursorPosition(70, 2);
            Console.WriteLine("Level:" + level.ToString());
        }
    }
}
