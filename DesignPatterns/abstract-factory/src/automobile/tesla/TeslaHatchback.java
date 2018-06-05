package automobile.tesla;

import automobile.IAutomobile;

public class TeslaHatchback implements IAutomobile{
	@Override
	public void start() {
		System.out.println("TeslaHatchback Started");
		
	}

	@Override
	public void stop() {
		System.out.println("TeslaHatchback Stopped");
		
	}
}
