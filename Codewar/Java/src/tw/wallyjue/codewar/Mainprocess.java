package tw.wallyjue.codewar;

import java.util.HashMap;

public class Mainprocess {

	public static void main(String[] args) {
		/*
		double[] input = new double[]{11.9, 2.3, 3.74, 12, 25.3};
		double[] output = null;
		 
		MovingAverage obj = new MovingAverage();
		try {
			output = obj.calculate(input);
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		for(int i = 0; i < output.length; i++){
			System.out.println("output["+i+"]:"+output[i]);
		}
		*/
		long input = 8181;
		HashMap<Integer,Integer> output;
		Fibonacci fibo = new Fibonacci();
		output = fibo.iterative(input);
		System.out.println();
		System.out.println("input:"+input);
		System.out.println("output:");
		for(int digit = output.size()-1; digit >= 0 ; digit--){
			System.out.print(output.get(digit));	
		}
		
		
	}

}
