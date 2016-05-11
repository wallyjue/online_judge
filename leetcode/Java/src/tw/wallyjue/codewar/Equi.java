package tw.wallyjue.codewar;

public class Equi {
	public int solution(int A[]){
		int[] tmp = new int[A.length];
		
		int cnt = 0, size = A.length;
		for( cnt = 1; cnt < A.length; cnt++){
			tmp[cnt] = tmp[cnt-1] + A[cnt];
			tmp[size-cnt+1] = tmp[size-cnt] + A[size-cnt];
		}
		System.out.print("");
		return -1;
	}
}
