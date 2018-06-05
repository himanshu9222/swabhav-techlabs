package automobile.tesla;

import automobile.IAutomobile;

public class TeslaSedan implements IAutomobile{
	@Override
	public void start() {
		System.out.println("TeslaSedan Started");
		
	}

	@Override
	public void stop() {
		System.out.println("TeslaSedan Stopped");
		
	}
}
