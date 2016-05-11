package creational.abstractfactory;

public class Usage {
	void renderChatroom(){
		Chatroom chatroom = new Chatroom();
		ChatroomFactory factory = new ChatroomFactory(){

			@Override
			public Color getColor() {
				return new Color(){

					@Override
					public String getBackground() {
						return "white";
					}

					@Override
					public String getFontColor() {
						return "black";
					}

					@Override
					public String getDialogColor() {
						return "gray";
					}
				};
			}

			@Override
			public Font getFont() {
				return new Font(){

					@Override
					public String getFont() {
						return "monospace";
					}
				};
			}
			
		};
		
		chatroom.renderChatroom(factory);
		
	}
}
