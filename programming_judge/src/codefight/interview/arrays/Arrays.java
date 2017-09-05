package codefight.interview.arrays;

import java.util.HashSet;

public class Arrays {
	public static int firstDuplicate(int[] a) {
		int dupli = 0;
		HashSet<Integer> set = new HashSet();
		
		for(int i = 0 ; i < a.length; i++) {
			if(set.contains(a[i])) {
				dupli = a[i];
				break;
			}else {
				set.add(a[i]);
			}
		}
		if(dupli == 0) {
			return -1;
		}
		return dupli;
	}
	
	public static char firstNotRepeatingCharacter(String s) {
		if(s.length() == 1) return s.charAt(0);
		HashSet<Character> set = new HashSet();
		
		
		char ret = '_', temp = '_';
		for(int i = 0 ; i < s.length(); i++) {
			if( set.contains(s.charAt(i)) ) {
				if(ret == s.charAt(i)) {
					ret = '_';
				}
			}else {
				ret = s.charAt(i);
				set.add(s.charAt(i));
			}
		}
		return ret;
	}
}
