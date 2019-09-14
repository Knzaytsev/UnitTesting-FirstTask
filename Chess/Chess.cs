using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_FirstTask
{
    public class Chess
    {
        private int[,] queens;

        public Chess(int[,] queens)
        {
            this.queens = queens;
        }

        public bool CheckBeat()
        {
            for(int i = 0; i < queens.GetLongLength(0) - 1; ++i)
            {
                for(int j = i + 1; j < queens.GetLongLength(0); ++j)
                {
                    if (queens[i, 0] == queens[j, 0] || queens[i, 1] == queens[j, 1] || 
                        Math.Abs(queens[i, 0] - queens[j, 0]) == Math.Abs(queens[i, 1] - queens[j, 1]))
                        return true;
                }
            }
            return false;
        }
    }
}
