package behavioral.visitor;

public class Usage {
	void main(){
		ContactQueryService service = new ContactQueryService();
		service.doService(new Member());
		service.doService(new VIP());
	}
}
