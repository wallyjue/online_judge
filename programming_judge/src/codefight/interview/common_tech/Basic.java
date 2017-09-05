package codefight.interview.common_tech;

import java.math.BigInteger;
import java.util.Arrays;
import java.util.HashSet;

public class Basic {
	boolean sumOfTwo(int[] a, int[] b, int v) {
		HashSet<Integer> set = new HashSet();
	    for(int i : a){
	        set.add(i);
	    }
	    for(int i  = 0;i<b.length;i++){
	        if(set.contains((v-b[i]))){
	            return true;
	        }
	    }
	    return false;
	}
	
	boolean containsDuplicates(int[] a) {
		HashSet<Integer> set = new HashSet();
		for(int i : a){
			if( set.contains(i) ) {
				return true;
			}
	        set.add(i);
	    }
		return false;
	}
	
	public static int sumInRange(int[] nums, int[][] queries) {
		int modulo = 1000000007;
		
		int [] xs = Arrays.copyOf(nums, nums.length+1);
		for(int i = xs.length-1; i > 0; i--) {
			xs[i] = xs[i-1];
		}
		xs[0] = 0;
		for(int i = 0; i < xs.length-1; i++) {
			xs[i+1] = xs[i] + nums[i];
		}
		
		
		int ret = 0;
		int start = 0, end = 0;
		for(int i = 0; i < queries.length; i++) {
			start = queries[i][0];
			end = queries[i][1];
			ret = xs[end+1] - xs[start] + ret; 
			while(ret > modulo) {
				ret -= modulo;
			}
			
			while(ret < 0) {
				ret += modulo;
			}
		}
		return ret;
	}
}
