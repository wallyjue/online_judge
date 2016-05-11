package one;

import java.util.BitSet;

public class CountPrime204 {
	public int countPrimes(int input) {
		int ret = 0;
		if (input <= 2) return 0;
		for( int cnt = 2; cnt < input ; cnt+=2){
			if( true == isPrime(cnt) ){
				ret++;
			}
		}
		return ret;
    }
	
	public boolean isPrime(int input){
		for( int cnt = 2; cnt < (input/2)+1 ; cnt++){
			if( input%cnt == 0 ){
				return false;
			}
		}
		return true;
	}
	
	public int countPrimesAC(int n) {
		if (n <= 2) return 0;
       BitSet compounds = new BitSet(n);
       int count = 0;
       for (int i = 2; i < n; i++) {
           if (compounds.get(i) == false) {
               count++;
               for (int j = i + i; j < n; j += i) compounds.set(j);
           }
       }
       return count;
	}
}
