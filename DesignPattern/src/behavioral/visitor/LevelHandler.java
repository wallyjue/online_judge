package behavioral.visitor;

import java.util.List;

public interface LevelHandler {
	List<ContactDAO> acceptLevel(ContactHandler handler);
}
