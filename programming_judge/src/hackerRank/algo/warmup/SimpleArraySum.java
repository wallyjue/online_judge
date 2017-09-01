package hackerRank.algo.warmup;

public class SimpleArraySum {
	static int simpleArraySum(int n, int[] ar) {
        // Complete this function
		int ret = 0;
		for(int i = 0; i < ar.length; i++)
		{
			ret += ar[i];
		}
		return ret;
    }
}
