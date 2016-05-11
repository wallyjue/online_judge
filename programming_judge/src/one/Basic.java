package one;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Basic {
	public void fizzbuzz(int size){
		for(int i = 1; i < size-1; i++){
			if(i % 15 == 0){
				System.out.println("Fizz Buzz");
			}else if(i % 5 == 0){
				System.out.println("Buzz");
			}else if(i % 3 ==0){
				System.out.println("Fizz");
			}else{
				System.out.println(i);
			}
		}
	}
	class Item{
		int soldnum;
		String id;
	}
	public int test(List<Item> list , int i) {
		HashMap<Integer,ArrayList<Item>> ttllist = new HashMap<Integer,ArrayList<Item>>(); 
		
		for(int cnt = 0; cnt < list.size(); cnt++){
			
			Item obj = list.get(cnt);
			//ttllist.put(obj.soldnum, value)
		}
		return 0;
	}
	
	
	public int Hanoi(int height){
		return 0;
	}
	
	
	
	
	public int fibonacci(int input){
		int f[] = new int[256];
		f[0] = 0;
		f[1] = 1;
		f[2] = 1;
		
		for(int i = 3 ; i < input+1; i++){
			f[i] = f[i-2] + f[i-1];
		}
		return f[input];
	}
	
	public int partition (int[] arr, int begin, int end){
		int i = begin, j = end;
		int pivot = arr[(end+begin)/2];
		while(i <= j){
			while(arr[i] < pivot){
				i++;
			}
			while(arr[j] > pivot){
				j--;
			}
			if(i <= j){
				// swap arr[i] and arr[j] here
				int tmp = arr[i];
				arr[i] = arr[j];
				arr[j] = tmp;
				i++;
				j--;
			}
		}
		return i;
	}
	
	public void quicksort(int [] input, int left, int right){
		int index = partition(input, left, right);
		
		if(left < index -1){
			quicksort(input,left,index-1);
		}
		if(index < right){
			quicksort(input,index,right);
		}
	}
	
	public int binarySearch(int []input){
		int ret = 0;
		return ret;
	}
}
