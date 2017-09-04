package hackerRank.algo.Graph;

import java.util.ArrayList;
import java.util.HashMap;

public class Graph {
	HashMap<Integer, Node> nodes;
	ArrayList<Edge> edges;
	
	HashMap<Integer, Integer> nodeCount;
	public Graph(){
		this.nodes = new HashMap<Integer, Node>();
		this.edges = new ArrayList<Edge>();
		this.nodeCount = new HashMap<Integer, Integer>();
	}
	
	public Graph(int nodeCount){
		this.nodes = new HashMap<Integer, Node>();
		this.edges = new ArrayList<Edge>();
		this.nodeCount = new HashMap<Integer, Integer>();
		for(int i = 0; i < nodeCount; i++){
			this.nodeCount.put(i, 0);
		}
	}
}
