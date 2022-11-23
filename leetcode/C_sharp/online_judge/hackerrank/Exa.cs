using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.hackerrank
{
    internal class Exa
    {
        public void Solution(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */

            var target = Console.ReadLine();
            Dictionary<char, bool> table = new Dictionary<char, bool>();
            for (int cnt = 0; cnt < target.Length;cnt++)
            {
                if (!table.ContainsKey(target[cnt]))
                {
                    table.Add(target[cnt], true);
                }
            }
            int ret = 0;

            var words = Console.ReadLine().Split(' ');
            Hashtable hashtable = new Hashtable();

            foreach (string word in words)
            {
                Dictionary<char, bool> temp = new Dictionary<char, bool>(table);
                bool hasExtra = false;
                for (int cnt = 0; cnt < word.Length;cnt++)
                {
                    if (!temp.ContainsKey(word[cnt]))
                    {
                        hasExtra = true;
                        break;
                    }
                    else
                    {
                        temp.Remove(word[cnt]);
                        temp.Add(word[cnt], false);
                    }
                }
                if (!hasExtra && temp.Where(x => x.Value == true).Count() == 0)
                {
                    if (!hashtable.ContainsKey(word))
                    {
                        hashtable.Add(word, true);
                    }
                }
            }

            Console.WriteLine(hashtable.Count);
        }
    }
}
