package creational.builder;

public class Usage {
	void render(){
		int[] tabs = {1,2,3,4};
		TopPageBuilder tabbuilder = new TopPageBuilder(tabs.length);
		TabDirector tabdirector = new TabDirector(tabbuilder, tabs);
		tabdirector.build().render();
	}
}
