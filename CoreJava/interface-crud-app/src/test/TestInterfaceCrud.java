package test;

import components.CustomerDB;
import components.DeptDB;
import components.EmployeeDB;
import components.ICrudabe;

public class TestInterfaceCrud {
	public static void main(String[] args) {
		ICrudabe x;
		x = new CustomerDB();
		x.create();

		x = new DeptDB();
		x.create();

		doDBOperation(new CustomerDB());
		doDBOperation(new EmployeeDB());
		doDBOperation(new DeptDB());
	}

	public static void doDBOperation(ICrudabe x) {
		System.out.println("\nIn DoDBOperation Method.");
		x.create();
		x.read();
		x.update();
		x.delete();
	}

}
