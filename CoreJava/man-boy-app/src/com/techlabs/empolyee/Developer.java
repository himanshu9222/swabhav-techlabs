package com.techlabs.empolyee;

public class Developer extends Employee{

	private double perks;
	private double sal;
	public Developer(int e, String n, double b) {
		super(e, n, b);
	}

	@Override
	public double calNetSalary() {
		perks=basic*0.3;
		sal=basic+perks;
		return sal;
	}
	

}
