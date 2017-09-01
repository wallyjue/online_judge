package hackerRank.algo.warmup;

public class AVeryBigSum {
	static long aVeryBigSum(int n, long[] ar) {
        // Complete this function
		long ret = 0;
		for(int i = 0; i < ar.length; i++)
		{
			ret += ar[i];
		}
		return ret;
    }
}
