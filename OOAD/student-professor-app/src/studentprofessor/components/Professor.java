package studentprofessor.components;

import java.util.Date;

public class Professor extends Person implements ISalariedEmployee {

	private double salary,basicSalary;
	private double hra=0.2;
	//private double pa;
	
	public Professor(String name,String address,Date dob,double basicSalary) {
		super(name,address,dob);
		this.basicSalary=basicSalary;
	}

	@Override
	public double calculateSalary() {
		salary=basicSalary*hra+basicSalary;
		return salary;
	}
	

}
