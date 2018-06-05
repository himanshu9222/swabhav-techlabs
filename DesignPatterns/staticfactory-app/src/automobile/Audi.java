package automobile;

public class Audi implements IAutomobable{
	@Override
	public void start() {
		System.out.println("Audi Started");
		
	}

	@Override
	public void stop() {
		System.out.println("Audi Stopped");
		
	}
}
