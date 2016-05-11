package creational.abstractfactory;

public class Chatroom {
	Chatroom(){
		super();
	}
	
	void renderChatroom(ChatroomFactory factory){
		Color color = factory.getColor();
		Font font = factory.getFont();
		
		// uses color and font to set the attribute
	}
}
