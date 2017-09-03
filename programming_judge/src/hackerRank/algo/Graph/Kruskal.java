package hackerRank.algo.Graph;

import java.io.*;
import java.nio.file.FileSystems;
import java.nio.file.Path;
import java.util.*;

public class Kruskal {
	public static void main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution. */
		int n, m;
		Graph g = new Graph();
		
		Path path = FileSystems.getDefault().getPath("data_set", "input.txt");
		Scanner in;
		try {
			in = new Scanner(path);
			n = in.nextInt();
			for(int i = 0 ; i < n; i++){
				g.nodes.put(i, new Node(i));
			}
			m = in.nextInt();
			for(int i = 0 ; i < m; i++){
				int start = in.nextInt();
				int end = in.nextInt();
				int weight = in.nextInt();
				g.edges.add(new Edge(start, end, weight));
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		Graph ret = new Graph();
		ret.nodes.putAll(g.nodes);
		g.edges.sort((p1, p2) -> p1.compareTo(p2));
		g.edges.forEach(f -> {
			if( !isCyclic(ret, f)){
				ret.edges.add(f);
			}
		});
		
		int sum = 0;
		sum = ret.edges.stream().mapToInt(i -> i.weight).sum();
		
		System.out.println(sum);
		
		
    }
	
	public static boolean isCyclic(Graph g, Edge new_edge){
		return false;
	}
}
