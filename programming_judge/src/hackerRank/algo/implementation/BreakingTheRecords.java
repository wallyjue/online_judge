package hackerRank.algo.implementation;

public class BreakingTheRecords {
	public static int[] getRecord(int[] s){
        // Complete this function
		int max = s[0], min = s[0];
		int breakmax = 0, breakmin = 0;
		for(int i = 0 ; i < s.length; i++)
		{
			if(s[i] > max)
			{
				breakmax++;
				max = s[i];
			}
			
			if(s[i] < min)
			{
				breakmin++;
				min = s[i];
			}
		}
		
		int [] ret = {breakmax,breakmin};
		return ret;
    }
}
