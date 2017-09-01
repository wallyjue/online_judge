package hackerRank.algo.warmup;

public class PlusMinus {
	public void PlusMinus(int[] arr)
	{
		int pos = 0, zero = 0, nega = 0;
		for(int i = 0 ; i < arr.length; i++) 
		{
			if(arr[i] == 0)
			{
				zero++;
			}
			if(arr[i] > 0)
			{
				pos++;
			}
			if(arr[i] < 0)
			{
				nega++;
			}
		}
		System.out.println( (float)pos/arr.length);
		System.out.println( (float)nega/arr.length);
		System.out.println( (float)zero/arr.length);
		
	}
}
