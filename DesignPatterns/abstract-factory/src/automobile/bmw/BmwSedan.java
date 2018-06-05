package automobile.bmw;

import automobile.IAutomobile;

public class BmwSedan implements IAutomobile{
	@Override
	public void start() {
		System.out.println("BmwSedan Started");
		
	}

	@Override
	public void stop() {
		System.out.println("BmwSedan Stopped");
		
	}
}
