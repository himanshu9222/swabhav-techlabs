package autofactory;

import automobile.IAutomobile;

public interface IAutoFactory {
	public IAutomobile makeSUV();
	public IAutomobile makeSedan();
	public IAutomobile makeHatchback();
}
