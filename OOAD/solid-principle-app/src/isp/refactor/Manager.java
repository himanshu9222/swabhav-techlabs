package isp.refactor;

public class Manager implements IWorkableEatable{
	@Override
	public void startWork() {
		System.out.println("Manager Start Working");
		
	}

	@Override
	public void stopWork() {
		System.out.println("Manager Stop Working");
	}

	@Override
	public void startEating() {
		System.out.println("Manager Start Eating");
	}

	@Override
	public void stopEating() {
		System.out.println("Manager Stop Eating");
	}
}
