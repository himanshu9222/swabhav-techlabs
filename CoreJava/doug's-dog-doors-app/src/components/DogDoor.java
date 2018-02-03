package components;

import java.util.Timer;
import java.util.TimerTask;

public class DogDoor {
	private boolean open;

	public DogDoor() {
		this.open = false;
	}

	public void open() {
		System.out.println("The Dog Door Open.");
		this.open = true;

		final Timer timer = new Timer();
		timer.schedule(new TimerTask() {
			@Override
			public void run() {
				close();
				timer.cancel();
			}
		}, 5000);
	}

	public void close() {
		System.out.println("The Dog Door Close.");
		this.open = false;
	}

	public boolean isOpen() {
		return open;
	}

}
