package automobile.bmw;

import automobile.IAutomobile;

public class BmwSUV implements IAutomobile{

	@Override
	public void start() {
		System.out.println("BmwSuv Started");
		
	}

	@Override
	public void stop() {
		System.out.println("BmwSuv Stopped");
		
	}

}
