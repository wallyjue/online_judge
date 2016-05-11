package one;

import java.util.Arrays;

public class CodilityLesson1 {
	public int TapeEquilibrium(int A[]){
		if(A.length == 2){
			return Math.abs(A[0]-A[1]);
		}
		int ret = Integer.MAX_VALUE;
		int prev = A[0], last = 0;
		for(int c = 1; c < A.length; c++){
			last += A[c];
		}
		for(int c = 1; c < A.length; c++){
			prev += A[c];
			last -= A[c];
			ret = Math.min(Math.abs(prev-last), ret);
		}
		return ret;
	}
	
	public int PermMissingElem(int[] A){
		//if(A.length == 0){
//			return 1;
		//}
		
		
		int cnt = 1;
		Arrays.sort(A);
		for(int c = 0; c < A.length;c++){
			if(A[c] != cnt){
				return cnt;
			}
			cnt++;
		}
		return cnt;
	}
}
