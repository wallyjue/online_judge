package one;

import java.util.Arrays;

public class Smartnews {
	public int numofzeroslice(int[] input){
		if(input.length == 1){
			if(input[0] == 0){
				return 1;
			}else{
				return 0;
			}
		}
		
		// f[n] = f[n-1] + num(  sum(a[0],a[n-1])==a[n] );
		int ret = 0;
		int f[] = new int[input.length];
		int tmp[];
		for(int i = 1; i < input.length; i++){
			tmp = Arrays.copyOfRange(input, 0, i);
			f[i] = numofzeroslice(tmp) + numberofequal(tmp, input[i]);
		}
		return f[input.length-1];
	}
	private int numberofequal(int input[], int sum){
		int ret = 0, tmp = 0;
		if(sum == 0){
			ret++;
		}
		for(int i = input.length-1; i >= 0; i--){
			tmp += input[i];
			if( sum + tmp == 0){
				ret++;
			}
		}
		return ret;
	}
}
