package behavioral.chainsofresponsibility;

public abstract class Chain {
	protected Chain next;
	Chain(Chain next) {
        this.next = next;
    }    
    void doNext(AuthDAO auth) {
        if(next != null) {
           next.handle(auth);
        }
    }
    abstract void handle(AuthDAO auth);
}
