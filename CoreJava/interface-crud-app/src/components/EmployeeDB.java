package components;

public class EmployeeDB implements ICrudabe {

	@Override
	public void create() {
		System.out.println("Employee created.");

	}

	@Override
	public void read() {
		System.out.println("Employee Read.");

	}

	@Override
	public void update() {
		System.out.println("Employee Update.");

	}

	@Override
	public void delete() {
		System.out.println("Employee Deleted.");

	}

}
