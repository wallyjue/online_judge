package hackerRank.algo.implementation;

public class BirthdayChocolate {
	public static int solve(int n, int[] s, int d, int m){
        // Complete this function
		int ret = 0, temp = 0;
		int end;
		for(int start = 0; start < n; start++)
		{
			for(end = start ; (end < n) && (end < start+m); end++)
			{
				temp += s[end];
			}
			
			if(temp == d)
			{
				ret++;
			}
			temp = 0;
		}
		return ret;
    }
}
