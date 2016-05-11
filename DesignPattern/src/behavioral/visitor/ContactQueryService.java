package behavioral.visitor;

import java.util.List;

public class ContactQueryService {
	private ContactHandler contacthandler = new LevelImpl();
	List<ContactDAO> doService(User user){
		return user.acceptLevel(contacthandler);
	}
}
