package behavioral.chainsofresponsibility;

public class APIOne extends Chain{
	APIOne(Chain next) {
		super(next);
	}
	@Override
	void handle(AuthDAO auth) {
		// do authentication with api version 2
	}
}
