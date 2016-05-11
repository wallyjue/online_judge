package one;

import java.util.HashMap;

public class Uva401 {
	
	HashMap<Character, Character> table;
	public Uva401(){
		this.table = new HashMap<Character, Character>();
		table.put('A', 'A');
		table.put('E', '3');
		table.put('H', 'H');
		table.put('I', 'I');
		table.put('J', 'L');
		table.put('L', 'J');
		table.put('M', 'M');
		table.put('O', 'O');
		table.put('T', 'T');
		table.put('U', 'U');
		table.put('V', 'V');
		table.put('W', 'W');
		table.put('Y', 'Y');
		table.put('Z', '5');
		table.put('1', '1');
		table.put('2', 'S');
		table.put('3', 'E');
		table.put('5', 'Z');
		table.put('8', '8');
	}
	
	
	public boolean isPalindrome(String input){
		for(int c = 0; c < input.length()-1; c++){
			if(input.charAt(c) != input.charAt(input.length()-1 -c)){
				return false;
			}
		}
		return true;
	}
	
	public boolean isMirrorString(String input){
		for(int c = 0; c < input.length()-1; c++){
			if( table.get(input.charAt(c)) != null && table.get(input.charAt(c)) != input.charAt(input.length()-1 -c)){
				return false;
			}
		}
		return true;
	}
}
