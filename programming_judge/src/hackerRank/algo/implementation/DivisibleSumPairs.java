package hackerRank.algo.implementation;

public class DivisibleSumPairs {
	public static int divisibleSumPairs(int n, int k, int[] ar) {
        // Complete this function
		int ret = 0;
		for(int i = 0; i < n; i++)
		{
			for(int j = i+1; j < n;j++)
			{
				if( ((ar[i]+ar[j]) % k ) == 0 )
				{
					ret++;
				}
			}
		}
		return ret;
    }
}
