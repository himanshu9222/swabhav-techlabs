package assignment5;

import java.util.Comparator;

public class EmployeeComparable implements Comparable<EmployeeComparable> {

	private int id;
	private String name;
	private int salary;

	public EmployeeComparable(int i, String n, int s) {
		this.id = i;
		this.name = n;
		this.salary = s;
	}

	public int getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public int getSalary() {
		return salary;
	}

	@Override
	public int compareTo(EmployeeComparable o) {
		return (this.id - o.id);// Sorting WRT id
	}

	public String toString() {
		return "Id = " + this.id + ",Name = " + this.name + ",Salary = "
				+ this.salary;

	}
	
	public static Comparator<EmployeeComparable> NameComparator=new Comparator<EmployeeComparable>() {

		@Override
		public int compare(EmployeeComparable e1, EmployeeComparable e2) {
			return e1.getName().compareTo(e2.getName());
		}
	};
	
	public static Comparator<EmployeeComparable> SalaryComparator=new Comparator<EmployeeComparable>() {

		@Override
		public int compare(EmployeeComparable e1, EmployeeComparable e2) {
			return e1.getSalary()-e2.getSalary();
		}
	};

}
