package autofactory;

import automobile.Bmw;
import automobile.IAutomobile;

public class BmwFactory implements IAutoFactory {
	private static BmwFactory service;
	
	public static BmwFactory getInstance(){
		if (service == null) {
			service = new BmwFactory();
		}
		return service;
	}

	@Override
	public IAutomobile make() {
		return new Bmw();
	}

}
