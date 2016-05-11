package structural.bridge;

public interface DatabaseOperation {
	public int get(String table, String key);
	public int set(String table, String key,String value);
}
