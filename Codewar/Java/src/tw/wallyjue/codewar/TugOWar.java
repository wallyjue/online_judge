package tw.wallyjue.codewar;

public class TugOWar {
	public static String tugOWar(final int[][] teams) {
		int sum1 = 0, sum2 = 0;
		for( int int1 : teams[0]){
			sum1 += int1;
		}
		for( int int2 : teams[1]){
			sum2 += int2;
		}
		if(sum1 > sum2){
			return "Team 1 wins!";
		}else if(sum1 < sum2){
			return "Team 2 wins!";
		}else{
			if(teams[0][0] > teams[1][4]){
				return "Team 1 wins!";
			}else if(teams[0][0] < teams[1][4]){
				return "Team 2 wins!";
			}else{
				return "It's a tie!";
			}
		}
	}
}
