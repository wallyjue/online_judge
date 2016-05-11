package one;

public class Mainprocess {
	
	public static void main(String[] args) {
		int[] input = {2,-2,3,0,4,-7}; 
		Smartnews sn = new Smartnews();
		int ret = sn.numofzeroslice(input);
		System.out.println("num:"+ret);		
	}
}
