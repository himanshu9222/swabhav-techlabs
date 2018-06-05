package test;

import factory.AutoMobileFactory;
import automobile.AutoType;
import automobile.IAutomobable;

public class Test {
	public static void main(String args[]){
		IAutomobable auto=AutoMobileFactory.make(AutoType.AUDI);
		System.out.println(auto.getClass());
		auto.start();
		auto.stop();
	}
}
