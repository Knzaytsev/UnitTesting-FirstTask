using System;
using System.Collections.Generic;
using System.Linq;
using Chess;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_FirstTask
{
    public class Chess
    {
        private int[,] queens;

        public int[,] Queens
        {
            get { return queens; }
            private set
            {
                int length = value.GetLength(0);
                List<List<int>> pairs = new List<List<int>>();
                for(int i = 0; i < value.GetLength(0); ++i)
                {
                    List<int> pair = new List<int>()
                    {
                        value[i, 0],
                        value[i, 1]
                    };
                    for(int j = 0; j < pairs.Count; ++j)
                        if (pairs[j][0] == pair[0] && pairs[j][1] == pair[1])
                            throw new SameElementException();
                    pairs.Add(pair);
                }
                queens = value;
            }
        }

        public Chess(int[,] queens)
        {
            Queens = queens;
        }

        public bool CheckBeat()
        {
            int length = queens.GetLength(0);
            for(int i = 0; i < length - 1; ++i)
            {
                for(int j = i + 1; j < length; ++j)
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
