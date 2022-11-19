using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.takeaway.bitFlyer
{
    internal class btcQuiz
    {
        Dictionary<int, (int, double)> table = new Dictionary<int, (int, double)>();
        List<Dictionary<int, (int, double)>> groups = new List<Dictionary<int, (int, double)>>();
        double profit = double.MinValue;
        int profitSetIndex = 0;

        public double MaxProfit(int[] sizes, double[] fees, int blockSize)
        {
            int[] indices = new int[sizes.Length];
            for (int cnt = 0; cnt < indices.Length;cnt++)
            {
                indices[cnt] = cnt;
                table.Add(cnt, new(sizes[cnt], fees[cnt]));
            }

            backTracking(sizes.Length - 1, indices, fees, blockSize);
            var profitSet = groups[profitSetIndex];

            return profit + 12.5;
        }


        private void backTracking(int index, int[] addingArray, double[] fees, int remainingBlockSize)
        {
            if (addingArray.Length == 0 || index >= addingArray.Length)
            {
                return;
            }

            for (int i = index; i >= 0; i--)
            {
                var list = addingArray.Where(x => x != addingArray[i]).ToList();

                if (list.Count() == 0)
                {
                    continue;
                }

                long tempBlockSum = 0;
                double tempProfit = 0;
                Dictionary<int, (int, double)> temp = new Dictionary<int, (int, double)>();
                foreach (int id in list)
                {
                    temp.Add(id, new(table[id].Item1, table[id].Item2));
                    tempBlockSum += table[id].Item1;
                    tempProfit += table[id].Item2;
                }
                if (tempBlockSum <= remainingBlockSize)
                {
                    this.groups.Add(temp);
                    if (tempProfit > this.profit)
                    {
                        this.profit = tempProfit;
                        profitSetIndex = this.groups.IndexOf(temp);
                    }
                }

                backTracking(i - 1, list.ToArray(), fees, remainingBlockSize);
                list.Add(addingArray[i]);
            }
        }
    }
}
