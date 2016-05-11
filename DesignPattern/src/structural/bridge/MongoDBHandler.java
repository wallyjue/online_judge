package structural.bridge;

public class MongoDBHandler implements DatabaseOperation{

	@Override
	public int get(String table, String key) {
		// TODO Auto-generated method stub
		
		System.out.println("Uses "+this.getClass().getCanonicalName()
				+" to read table " + table +", key:"+key);
		
		return 0;
	}

	@Override
	public int set(String table, String key, String value) {
		// TODO Auto-generated method stub
		
		System.out.println("Uses "+this.getClass().getCanonicalName()
				+" to write to table " + table +", key:"+key+", value:"+value);
		
		return 0;
	}

}
