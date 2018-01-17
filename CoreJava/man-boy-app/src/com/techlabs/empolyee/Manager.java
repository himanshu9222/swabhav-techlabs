package com.techlabs.empolyee;

public class Manager extends Employee{
	
	private double hra;
	private double ta;
	private double sal;
	
	public Manager(int e, String n, double b) {
		super(e, n, b);
	}
	
	@Override
	public double calNetSalary() {
		hra=basic*0.5;
		ta=basic*0.4;
		sal=basic+hra+ta;
		return sal;
	}
	
}
