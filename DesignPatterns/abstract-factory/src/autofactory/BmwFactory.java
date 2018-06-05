package autofactory;

import automobile.IAutomobile;
import automobile.bmw.BmwHatchback;
import automobile.bmw.BmwSUV;
import automobile.bmw.BmwSedan;

public class BmwFactory implements IAutoFactory {
	private static BmwFactory service;
	
	public static BmwFactory getInstance(){
		if (service == null) {
			service = new BmwFactory();
		}
		return service;
	}

	@Override
	public IAutomobile makeSUV() {
		return new BmwSUV();
	}

	@Override
	public IAutomobile makeSedan() {
		return new BmwSedan();
	}

	@Override
	public IAutomobile makeHatchback() {
		return new BmwHatchback();
	}
}
