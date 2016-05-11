package behavioral.command;

import java.util.HashMap;
import java.util.Map;

public class CommandService {
	private Map<String, Command> commands = new HashMap<String, Command>();
    private AlgoInterface drawing = new AlgoImplementation();
    void addCommand(String effect, Command command) {
        commands.put(effect, command);
    }
    void doEffect(String algo) {
        commands.get(algo).execute(drawing);
    }
}
