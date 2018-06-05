package autofactory;

import automobile.IAutomobile;
import automobile.Tesla;

public class TeslaFactory implements IAutoFactory {
	private static TeslaFactory service;
	
	public static TeslaFactory getInstance(){
		if (service == null) {
			service = new TeslaFactory();
		}
		return service;
	}

	@Override
	public IAutomobile make() {
		return new Tesla();
	}
}
