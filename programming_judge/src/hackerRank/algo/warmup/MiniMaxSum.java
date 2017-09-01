package hackerRank.algo.warmup;

public class MiniMaxSum {
	public static long[] MinMax(int[] input){
		long [] ret = {0,0};
		long min = input[0], max = 0, sum = 0;
		for(int i = 0; i < input.length; i++)
		{
			sum += input[i];
			if(input[i] > max)
			{
				max = input[i];
			}
			
			if(input[i] < min)
			{
				min = input[i];
			}
		}
		ret[0] = sum - max;
		ret[1] = sum - min;
		return ret;
	}
	
}
