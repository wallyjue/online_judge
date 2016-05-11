package one;

public class Indeed {
	private static int A = 97;
	private class Char{
		int times = 0;
		char content;
	}
	
	public String[] A(String input){
		String[] ret = null;
		Char[] arr = new Char[26];
		for(int x = 0; x < input.length(); x++){
			System.out.println((int)input.charAt(x));
			arr[(int)(input.charAt(x))-A].times++;
			arr[(int)(input.charAt(x))-A].content = input.charAt(x); 
		}
		
		return ret;
	}
	
	public String[] B(String[] input){
		String[] ret = null;
		
		
		
		return ret;
	}
}
