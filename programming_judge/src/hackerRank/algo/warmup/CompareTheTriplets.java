package hackerRank.algo.warmup;

public class CompareTheTriplets {
	static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2){
        // Complete this function
		int [] ret = {0,0};
		if(a0 > b0) {
			ret[0]++;
		}
		else if( a0 < b0){
			ret[1]++;
		}
		
		if(a1 > b1) {
			ret[0]++;
		}
		else if( a1 < b1){
			ret[1]++;
		}

		if(a2 > b2) {
			ret[0]++;
		}
		else if( a2 < b2){
			ret[1]++;
		}
		
		return ret;
    }
}
