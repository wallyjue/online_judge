package creational.builder;

public class TopPageBuilder implements TabBuilder{
	private int tabsize;
	private TabDAO[] tabs;
	TopPageBuilder(int tabsize){
		this.tabsize = tabsize;
		tabs = new TabDAO[tabsize];
	}
	
	@Override
	public void buildRecentHistory() {
		// get the data of recent history
	}

	@Override
	public void buildFavorite() {
		// get the data of favorite
	}

	@Override
	public void buildDirectory() {
		// get the data of directory
	}

	@Override
	public void buildCustomGroups() {
		// get the data of custom groups
	}

	@Override
	public MainUI getMainUI() {
		MainUI ui = new MainUI(){
			@Override
			public void render() {
				for(int i = 0; i < tabsize;i++){
					System.out.println("tab "+i+" :"+tabs[i]);
				}
			}
		};
		return ui;
	}

}
