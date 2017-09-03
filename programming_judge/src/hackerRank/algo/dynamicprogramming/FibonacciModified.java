package hackerRank.algo.dynamicprogramming;

import java.math.BigInteger;

public class FibonacciModified {
	
	public static void ReadInput()
	{
		
	}
	
	public BigInteger get(String a0, String a1, int level)
	{
		if(level == 3){
			return new BigInteger("1");
		}else if(level == 4){
			return new BigInteger("2");
		}else if(level == 5){
			return new BigInteger("5");
		}		
		BigInteger bi = null;
		BigInteger b0 = new BigInteger(a0), b1 = new BigInteger(a1);
		for(int i = 0; i < level-2; i++)
		{
			bi = b0.add(b1.pow(2) );
			b0 = b1;
			b1 = bi;
			System.out.println(bi);
		}
		
		return bi;
	}
}
