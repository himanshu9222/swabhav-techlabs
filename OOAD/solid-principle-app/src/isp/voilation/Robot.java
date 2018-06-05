package isp.voilation;

public class Robot implements IWorker{

	@Override
	public void startWork() {
		System.out.println("Robot Start Working");
		
	}

	@Override
	public void stopWork() {
		System.out.println("Robot Stop Working");
		
	}

	@Override
	public void startEating() {
		throw new RuntimeException("Robot cannot Eat");
		
	}

	@Override
	public void stopEating() {
		throw new RuntimeException("Robot cannot Eat");
		
	}

}
