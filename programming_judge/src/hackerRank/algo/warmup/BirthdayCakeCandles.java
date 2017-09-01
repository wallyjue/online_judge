package hackerRank.algo.warmup;

public class BirthdayCakeCandles {
	static int birthdayCakeCandles(int n, int[] ar) {
        // Complete this function
		int ret = 0, max = 0;
		for(int i = 0 ; i < ar.length; i++)
		{
			if(ar[i] > max){
				max = ar[i];
				ret = 1;
			}
			else if(ar[i] == max){
				ret++;
			}
		}
		
		return ret;
    }
}
