package behavioral.observer;

import java.util.ArrayList;
import java.util.List;

public class UserQueue {
	//private List<UserDAO> clients = new ArrayList<UserDAO>();
    private List<UserEventListener> listeners = new ArrayList<UserEventListener>();
            
    void addClientListener(UserEventListener listener) {
        listeners.add(listener);
    }
    void removeClientListener(UserEventListener listener) {
        listeners.remove(listener);
    }
    
    void notifyAdded(UserDAO client) {
    	UserEvent event = new UserEvent(client);
        for(UserEventListener listener : listeners) {
            listener.userAdded(event);
        }
    }
    void notifyRemoved(UserDAO client) {
    	UserEvent event = new UserEvent(client);
        for(UserEventListener listener : listeners) {
            listener.userDeleted(event);
        }
    }
    
    void add(UserDAO user){
    	//clients.add(user);
    	notifyAdded(user);
    }
    
    void delete(UserDAO user){
    	//clients.remove(user);
    	notifyRemoved(user);
    }
}
