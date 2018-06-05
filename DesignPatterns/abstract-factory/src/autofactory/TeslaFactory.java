package autofactory;

import automobile.IAutomobile;
import automobile.tesla.TeslaHatchback;
import automobile.tesla.TeslaSUV;
import automobile.tesla.TeslaSedan;

public class TeslaFactory implements IAutoFactory {
	private static TeslaFactory service;
	
	public static TeslaFactory getInstance(){
		if (service == null) {
			service = new TeslaFactory();
		}
		return service;
	}

	@Override
	public IAutomobile makeSUV() {
		return new TeslaSUV();
	}

	@Override
	public IAutomobile makeSedan() {
		return new TeslaSedan();
	}

	@Override
	public IAutomobile makeHatchback() {
		return new TeslaHatchback();
	}
}
