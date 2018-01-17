package com.techlabs.employee.test;

import com.techlabs.empolyee.Developer;
import com.techlabs.empolyee.Employee;
import com.techlabs.empolyee.Manager;

public class Test {

	public static void main(String[] args) {
		Employee e1=new Manager(100, "Himanshu", 1000);
		Employee e2=new Developer(200, "him", 1000);
		
		printDetails(e1);
		printDetails(e2);
	}
	
	public static void printDetails(Employee e){
		System.out.println("EmployeeId = "+e.getEmpno()+"\nName = "+e.getName()+"\n Salary = "+e.calNetSalary()+"");
	}

}
