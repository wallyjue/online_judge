package tw.wallyjue.codewar;

public class MovingAverage {
	public double[] calculate(double[] input) throws Exception{
		if(input.length <= 2){
			return input;
		}
		double[] ret = new double[input.length-2];
		for(int i = 1; i < input.length -1; i++){
			ret[i-1] = (input[i-1]+input[i]+input[i+1])/3;
		}
		return ret;
	}
}
