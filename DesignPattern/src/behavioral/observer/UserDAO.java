package behavioral.observer;

public class UserDAO {
	int userUniqId;
	String accountId;
	
	UserDAO(int userUid, String accountId){
		this.userUniqId = userUid;
		this.accountId = accountId;
	}
}
