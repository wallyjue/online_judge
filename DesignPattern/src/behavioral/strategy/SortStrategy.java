package behavioral.strategy;

public class SortStrategy {
	private Sorting sorting;
	
	SortStrategy(Sorting sortingalgo){
		this.sorting = sortingalgo;
	}
	
	public int[] performSorting(int[] input){
		int[] output = this.sorting.sort(input);
		return output;
	}
}
