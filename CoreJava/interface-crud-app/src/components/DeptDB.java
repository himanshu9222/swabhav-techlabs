package components;

public class DeptDB implements ICrudabe {

	@Override
	public void create() {
		System.out.println("DeptDB created.");

	}

	@Override
	public void read() {
		System.out.println("DeptDB Read.");

	}

	@Override
	public void update() {
		System.out.println("DeptDB update.");

	}

	@Override
	public void delete() {
		System.out.println("DeptDB Deleted.");

	}

}
