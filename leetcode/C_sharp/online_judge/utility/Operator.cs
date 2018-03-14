using System;
using System.Collections.Generic;
using System.Text;

namespace online_judge.utility
{
    public static class Operator
    {
		public static void Swap<T>(ref T lhs, ref T rhs)
		{
			T temp = lhs;
			lhs = rhs;
			rhs = temp;
		}
	}
}
