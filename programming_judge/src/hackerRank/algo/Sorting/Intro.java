package hackerRank.algo.Sorting;

import java.io.IOException;
import java.nio.file.FileSystems;
import java.nio.file.Files;
import java.nio.file.Path;
import java.util.ArrayList;
import java.util.Scanner;

public class Intro {
	public static void main(String[] args) {
		int v = 0, n;
		ArrayList<Integer> ar = new ArrayList<Integer>();
		Path path = FileSystems.getDefault().getPath("data_set", "input.txt");
		Scanner in;
		try {
			in = new Scanner(System.in);
			v = in.nextInt();
			n = in.nextInt();
			for(int i = 0 ; i < n; i++){
				ar.add(in.nextInt());
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		System.out.println(ar.indexOf(v));
		
		/*
		try {
			Files.lines(path).forEach((x) -> {
				System.out.println(x);
			});
		} catch (IOException e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		*/
	}
}
