package hackerRank.algo.warmup;

public class Staircase {
	public static String Staircase(int s) {
		for(int i = 0 ; i < s; i++)
		{
			for(int j = 0 ; j < s - i - 1; j++)
			{
				System.out.print(" ");
			}
			
			for(int x = s - i - 1; x < s; x++)
			{
				System.out.print("#");
			}
		}
		return null;
		
	}
}
