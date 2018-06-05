package automobile.audi;

import automobile.IAutomobile;

public class AudiSedan implements IAutomobile{
	@Override
	public void start() {
		System.out.println("AudiSedan Started");
		
	}

	@Override
	public void stop() {
		System.out.println("AudiSedan Stopped");
		
	}
}
