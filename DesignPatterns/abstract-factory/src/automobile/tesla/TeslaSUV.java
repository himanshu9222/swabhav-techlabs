package automobile.tesla;

import automobile.IAutomobile;

public class TeslaSUV implements IAutomobile{
	@Override
	public void start() {
		System.out.println("TeslaSUV Started");
		
	}

	@Override
	public void stop() {
		System.out.println("TeslaSUV Stopped");
		
	}
}
