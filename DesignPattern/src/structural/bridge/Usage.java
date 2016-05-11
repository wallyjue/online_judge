package structural.bridge;

public class Usage {
	public void usage(){
		
		DataAdapter da_mongodb = new DataAdapter("mongodb");
		DataAdapter da_postgres = new DataAdapter("postgresql");
		da_mongodb.set("table1","key1","value1");
		
	}
}
