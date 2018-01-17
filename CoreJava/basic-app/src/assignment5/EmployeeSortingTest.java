package assignment5;

import java.util.Arrays;

public class EmployeeSortingTest {

	public static void main(String[] args) {
		EmployeeComparable[] emp=new EmployeeComparable[4];
		emp[0]=new EmployeeComparable(1, "himashu", 50000);
		emp[1]=new EmployeeComparable(6, "himashu", 50000);
		emp[2]=new EmployeeComparable(2, "kunal", 5000);
		emp[3]=new EmployeeComparable(4, "shubham", 500);
		
		Arrays.sort(emp);
		System.out.println("Default sorting"+Arrays.toString(emp));
		
		Arrays.sort(emp, EmployeeComparable.NameComparator);
		System.out.println("Sorting by name"+Arrays.toString(emp));
		
		Arrays.sort(emp, EmployeeComparable.SalaryComparator);
		System.out.println("Sorting by Salary"+Arrays.toString(emp));
		
	}

}
