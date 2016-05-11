package behavioral.observer;

public class UserEvent {
	int userUniqId;
	String accountId;
	UserEvent(UserDAO user){
		this.userUniqId = user.userUniqId;
		this.accountId = user.accountId;
	}
}
