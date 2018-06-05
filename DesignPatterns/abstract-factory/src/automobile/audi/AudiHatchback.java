package automobile.audi;

import automobile.IAutomobile;

public class AudiHatchback implements IAutomobile{
	@Override
	public void start() {
		System.out.println("AudiHatchback Started");
		
	}

	@Override
	public void stop() {
		System.out.println("AudiHatchback Stopped");
		
	}
}
