package behavioral.visitor;

import java.util.ArrayList;
import java.util.List;

public class VIP extends User{
	public List<ContactDAO> getContactList(){
		// do contact list retrieval 
		return new ArrayList<ContactDAO>();
	}
	
	@Override
	public List<ContactDAO> acceptLevel(ContactHandler handler) {
		return handler.getContactList(this);
	}

}
