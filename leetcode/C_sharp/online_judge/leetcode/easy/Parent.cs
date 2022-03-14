using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace online_judge.leetcode.easy
{
    public class Parent
    {
        int falsenumber;
        public Parent(int falsenumber)
        {
            this.falsenumber = falsenumber;
        }

        protected bool isBadVersion(int n)
        {
            return n >= this.falsenumber;
        }

    }
}
