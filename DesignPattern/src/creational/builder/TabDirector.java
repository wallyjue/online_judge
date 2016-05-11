package creational.builder;

public class TabDirector {
	private int[] tabs;
	private TabBuilder builder;
	TabDirector(TabBuilder builder, int[] tabs){
		super();
		this.builder = builder;
		this.tabs = tabs;
	}
	
	MainUI build(){
		for(int i = 0;i < tabs.length; i++){
			switch(tabs[i]){
				case 1:
					builder.buildRecentHistory();
					break;
				case 2:
					builder.buildFavorite();
					break;
				case 3:
					builder.buildCustomGroups();
					break;
				case 4:
					builder.buildDirectory();
					break;
			}
		}
		return builder.getMainUI();
	}
}
