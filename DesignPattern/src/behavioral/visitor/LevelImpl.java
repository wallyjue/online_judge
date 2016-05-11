package behavioral.visitor;

import java.util.List;

public class LevelImpl implements ContactHandler{

	@Override
	public List<ContactDAO> getContactList(Member member) {
		// TODO Auto-generated method stub
		return member.getContactList();
	}

	@Override
	public List<ContactDAO> getContactList(VIP vip) {
		// TODO Auto-generated method stub
		return vip.getContactList();
	}

	@Override
	public List<ContactDAO> getContactList(Arbeit arbeit) {
		// TODO Auto-generated method stub
		return arbeit.getContactList();
	}

}
