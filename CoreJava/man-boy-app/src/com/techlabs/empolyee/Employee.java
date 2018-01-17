package com.techlabs.empolyee;

public abstract class Employee {
	private int empno;
	private String name;
	protected double basic;
	
	public Employee(int e,String n,double b){
		empno=e;
		name=n;
		basic=b;
	}
	
	public abstract double calNetSalary();


	public int getEmpno(){
		return empno;
	}
	
	public String getName(){
		return name;
	}
	
	public double getBasic(){
		return basic;
	}
}
