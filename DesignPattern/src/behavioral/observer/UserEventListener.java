package behavioral.observer;

public interface UserEventListener {
	void userAdded(UserEvent userEvent);
	void userDeleted(UserEvent userEvent);
}
