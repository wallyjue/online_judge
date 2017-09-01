package hackerRank.algo.warmup;

public class DiagonalDifference {
	public static int Diff(int[][] a)
	{
		int ret = 0;
		int sum1 = 0, sum2 = 0;
		for(int i = 0; i < a.length; i++) {
			sum1 += a[i][i];
			sum2 += a[i][a.length-i-1];
		}
		
		ret = sum1 - sum2;
		if(ret < 0) {
			ret = -ret;
		}
		
		return ret; 
	}
}
