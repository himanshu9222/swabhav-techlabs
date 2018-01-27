package guitar.component.test;

import guitar.component.Builder;
import guitar.component.Type;
import guitar.component.Wood;

public class GuitarSpec {
	
	private String model;
	Wood topWood;
	Wood backWood;
	Type type;
	Builder builder;
	
	
	public GuitarSpec(Builder builder,
			String model, Type type, Wood backWood, Wood topWood){
		this.builder = builder;
		this.model = model;
		this.type = type;
		this.backWood = backWood;
		this.topWood = topWood;
	}
	
	public Builder getBuilder() {
		return builder;
	}

	public String getModel() {
		return model;
	}

	public Type getType() {
		return type;
	}

	public Wood getBackWood() {
		return backWood;
	}

	public Wood getTopWood() {
		return topWood;
	}
	
	
}
