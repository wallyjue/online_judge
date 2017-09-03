package hackerRank.algo.Graph;

import java.util.ArrayList;
import java.util.HashMap;

public class Graph {
	HashMap<Integer, Node> nodes;
	ArrayList<Edge> edges;
	public Graph(){
		this.nodes = new HashMap<Integer, Node>();
		this.edges = new ArrayList<Edge>();
	}
}
