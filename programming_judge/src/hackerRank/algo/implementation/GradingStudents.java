package hackerRank.algo.implementation;

public class GradingStudents {
	static int[] solve(int[] grades){
        // Complete this function
		for(int i = 0; i < grades.length ; i++)
		{
			if(grades[i] >= 38)
			{
				if(grades[i] % 5  == 3){
					grades[i] += 2;
				}else if(grades[i] % 5  == 4){
					grades[i] += 1;
				}
			}
		}
		return grades;
    }
}
