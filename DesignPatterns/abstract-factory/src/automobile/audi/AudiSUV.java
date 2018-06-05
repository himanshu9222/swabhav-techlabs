package automobile.audi;

import automobile.IAutomobile;

public class AudiSUV implements IAutomobile{
	@Override
	public void start() {
		System.out.println("AudiSUV Started");
		
	}

	@Override
	public void stop() {
		System.out.println("AudiSUV Stopped");
		
	}
}
