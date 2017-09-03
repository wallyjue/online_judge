package hackerRank.algo.Graph;

public class Edge implements Comparable<Edge>{
	public int weight;
	public boolean directed;
	public int start;
	public int end;
	
	public boolean equal(Edge edge)
	{
		return this.equal(edge.start, edge.end, edge.directed, edge.weight);
	}
	
	public boolean equal(int start, int end, boolean directed, int weight)
	{
		if(directed){
			return this.start == start && this.end == end && this.weight == weight;
		}else{
			return ((this.start == start && this.end == end) || (this.end == start && this.start == end)) 
					&& this.weight == weight;
		}
	}
	
	public Edge(){}
	public Edge(int start, int end, int weight)
	{
		this.start = start;
		this.end = end;
		this.weight = weight;
	}

	@Override
	public int compareTo(Edge arg0) {
		// TODO Auto-generated method stub
		if(this.weight > arg0.weight){
			return 1;
		}else if(this.weight < arg0.weight){
			return -1;
		}else {
			return 0;
		}
	}
}
