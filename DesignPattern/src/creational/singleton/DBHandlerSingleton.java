package creational.singleton;

public class DBHandlerSingleton {
	private DBHandlerSingleton(){};
	
	private DBHandlerSingleton thisobj = new DBHandlerSingleton();
	
	public DBHandlerSingleton getDBHandler(){
		return thisobj;
	}
}
