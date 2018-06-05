package automobile.bmw;

import automobile.IAutomobile;

public class BmwHatchback implements IAutomobile{
	@Override
	public void start() {
		System.out.println("BmwHatchback Started");
		
	}

	@Override
	public void stop() {
		System.out.println("BmwHatchback Stopped");
		
	}
}
