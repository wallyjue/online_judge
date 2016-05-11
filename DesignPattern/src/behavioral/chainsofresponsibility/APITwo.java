package behavioral.chainsofresponsibility;

public class APITwo extends Chain{
	APITwo(Chain next) {
		super(next);
	}
	@Override
	void handle(AuthDAO auth) {
		// do authentication with api version 2
	}
}
