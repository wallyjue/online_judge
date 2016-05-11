package behavioral.command;

public class CommandA implements Command{

	@Override
	public void execute(AlgoInterface algo) {
		algo.methodA();
		algo.methodB();
	}

}
