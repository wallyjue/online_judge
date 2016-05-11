package creational.builder;

public interface TabBuilder {
	public void buildRecentHistory();
	public void buildFavorite();
	public void buildDirectory();
	public void buildCustomGroups();
	
	MainUI getMainUI();
}
