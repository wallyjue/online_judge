package tw.wallyjue.codewar;

import java.util.HashMap;

public class Fibonacci {
	public HashMap<Integer,Integer> iterative(long input) {
		HashMap<Integer,Integer> ret = new HashMap<Integer,Integer>();
		if(input == 0){
			ret.put(0,0);
			return ret;
		}else if (input == 1 || input == 2){
			ret.put(0,1);
			return ret;
		}
		HashMap<Integer,Integer> a,b,c;
		a = new HashMap<Integer,Integer>();
		b = new HashMap<Integer,Integer>();
		c = new HashMap<Integer,Integer>();
		a.put(0,1);
		b.put(0,1);		
		int digit_size = 0, offset = 0;
		//long i = 1, j = 1, k = 0;
		for(long cnt = 2; cnt < input;cnt++){
			digit_size = a.size();
			if(digit_size < b.size()){
				digit_size = b.size();
			}
			// c = a + b
			for(int digit = 0; digit < digit_size; digit++){
				if(a.get(digit) == null){
					offset = b.get(digit)+offset;
				}else{
					offset = a.get(digit)+b.get(digit)+offset;
				}
				if(offset >= 10){
					c.put(digit, offset-10);
					c.put(digit+1, 1);
					offset = 1;
				}else{
					c.put(digit, offset);
					offset = 0;
				}
				
			}
			// a = b;
			for(int digit = 0; digit < b.size(); digit++){
				a.put(digit, b.get(digit));
			}
			// b = c;
			for(int digit = 0; digit < c.size(); digit++){
				b.put(digit, c.get(digit));
			}
			offset = 0;
			System.out.println("cnt:"+cnt);
			System.out.print("a:");
			for(int displaydigit = a.size()-1; displaydigit >= 0 ; displaydigit--){
				System.out.print(a.get(displaydigit));	
			}System.out.println();
			System.out.print("b:");
			for(int displaydigit = b.size()-1; displaydigit >= 0 ; displaydigit--){
				System.out.print(b.get(displaydigit));	
			}
			System.out.println();
			System.out.print("c:");
			for(int displaydigit = c.size()-1; displaydigit >= 0; displaydigit--){
				System.out.print(c.get(displaydigit));	
			}
			System.out.println();
		}
		return c;
	}
	
	
	public long recursive(long input){
		if(input == 0){
			return 0;
		}else if (input == 1 || input == 2){
			return 1;
		}
		return this.recursive(input-1) +this.recursive(input-2);
	}
}
