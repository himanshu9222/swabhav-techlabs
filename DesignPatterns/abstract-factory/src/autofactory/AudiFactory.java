package autofactory;

import automobile.IAutomobile;
import automobile.audi.AudiHatchback;
import automobile.audi.AudiSUV;
import automobile.audi.AudiSedan;

public class AudiFactory implements IAutoFactory {
	private static AudiFactory service;

	public static AudiFactory getInstance(){
		if (service == null) {
			service = new AudiFactory();
		}
		return service;
	}

	@Override
	public IAutomobile makeSUV() {
		return new AudiSUV();
	}

	@Override
	public IAutomobile makeSedan() {
		return new AudiSedan();
	}

	@Override
	public IAutomobile makeHatchback() {
		return new AudiHatchback();
	}
}
