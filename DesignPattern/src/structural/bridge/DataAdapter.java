package structural.bridge;

public class DataAdapter implements DataOperation{
	DatabaseOperation db;
	String DBType;
	public DataAdapter(String DBType){
		if(DBType.equals("MongoDB")){
			db = new MongoDBHandler();
		}else if(DBType.equals("Postgresql")){
			db = new PostgresqlHandler();
		}
		this.DBType = DBType;
	}

	@Override
	public String get(String... key) {
		// TODO Auto-generated method stub
		
		if(DBType.equals("MongoDB")){
			db.get(key[0], key[1]);
		}else if(DBType.equals("Postgresql")){
			db.get(key[0], key[1]);
		}
		
		return null;
	}

	@Override
	public void set(String... key) {
		if(DBType.equals("MongoDB")){
			db.set(key[0], key[1], key[2]);
		}else if(DBType.equals("Postgresql")){
			db.set(key[0], key[1], key[2]);
		}
	}

}
