package behavioral.visitor;

import java.util.List;

public interface ContactHandler {
	List<ContactDAO> getContactList(Member member);
	List<ContactDAO> getContactList(VIP vip);
	List<ContactDAO> getContactList(Arbeit arbeit);
}
