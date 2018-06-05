package autofactory;

import automobile.Audi;
import automobile.IAutomobile;

public class AudiFactory implements IAutoFactory {
	private static AudiFactory service;

	public static AudiFactory getInstance(){
		if (service == null) {
			service = new AudiFactory();
		}
		return service;
	}

	@Override
	public IAutomobile make() {
		return new Audi();
	}
}
