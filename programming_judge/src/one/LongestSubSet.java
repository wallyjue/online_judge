package one;

import java.util.ArrayList;
import java.util.HashMap;

public class LongestSubSet {
	public int longestCommonSubsequence(String A, String B) {
        int n = A.length();
	    int m = B.length();
        int f[][] = new int[n + 1][m + 1];
        for(int i = 1; i <= n; i++){
            for(int j = 1; j <= m; j++){
                f[i][j] = Math.max(f[i - 1][j], f[i][j - 1]);
                if(A.charAt(i - 1) == B.charAt(j - 1))
                    f[i][j] = f[i - 1][j - 1] + 1;
            }
        }
        return f[n][m];
    }
	public int longestCommonSubstring(String A, String B) {
        // write your code here
        int maxlen = 0;
        int xlen = A.length();
        int ylen = B.length();
        for(int i = 0; i < xlen; ++i)
	    {
		    for(int j = 0; j < ylen; ++j)
		    {
			    int len = 0;
                while (i + len < xlen && j + len < ylen && 
                    A.charAt(i + len) == B.charAt(j + len))
                        len ++;
			    if(len > maxlen)
				    maxlen = len;
		    }
	    }
        return maxlen;
    }
	
	
	public int longestincreasingnum(int[] input){
		//HashMap<Integer, Boolean> c = new HashMap<Integer,Boolean>();
		
		int q[] = new int[input.length];
		for(int i = 0; i < input.length; i++){
			q[i] = 0;
		}
		int max = 0;
		for(int i = 0; i < input.length; i++){
			max = 0;
			for(int j = 0; j < i; j++){
				if( input[i] > input[j] && q[j] > max){
					max = q[j];
				}
			}
			q[i] = max +1;
		}
		
		max = 0;
		for(int i = 0; i < input.length; i++){
			if(q[i] > max){
				max = q[i];
			}
		}
		return max;
	}
	
	public int longestsubstring(String input){
		boolean q[] = new boolean[input.length()];
		int last = 0, max = 1;
		HashMap<Character, Boolean> c = new HashMap<Character,Boolean>();
		for(int i = 0; i < input.length(); i++){
			char in = input.charAt(i);
			Boolean ex = c.get(in); 
			if(ex != null){
				max = i-last;
				last = i;
			}
			c.put(in, true);
		}
		
		return max;
	}
	
	public char[] getsubString(String input){
		char [] ret = new char[input.length()];
		input.getChars(1, input.length(), ret, 0);;
		return ret;
	}
	
	public String insertChar(String in, char firstChar, int position){
		return in.substring(0, position) + firstChar + in.substring(position); 
	}
	
	public ArrayList<String> getPermutation(String input){
		if(input == null){
			return null;
		}
		
		ArrayList<String> ret = new ArrayList<String>();
		if(input.length() == 0){
			ret.add("");
			return ret;
		}else if(input.length() == 1){
			ret.add(input);
			return ret;
		}
		char firstChar = input.charAt(0);
		String substring = input.substring(1);
		
		ArrayList<String> subset = getPermutation(substring);
		for( String word:subset){
			for(int i = 0; i <= word.length();i++){
				String s = insertChar(word,firstChar,i);
				ret.add(s);
			}
		}
		return ret;
	}
}
