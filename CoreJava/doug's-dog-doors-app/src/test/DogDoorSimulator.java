package test;

import components.BarkRecognizer;
import components.DogDoor;
import components.Remote;

public class DogDoorSimulator {

	public static void main(String[] args) {
		DogDoor door = new DogDoor();
		BarkRecognizer recognizer = new BarkRecognizer(door);
		//Remote remote = new Remote(door);

		System.out.println("Fido barks to go outside...");
		recognizer.recognize("Woof");
		// remote.pressButton();
		System.out.println("\nFido has gone outside...");
		// remote.pressButton();
		System.out.println("\nFido's all done...");
		// remote.pressButton();
		System.out.println("\nFido's back inside...");
		// remote.pressButton();

		try {
			Thread.currentThread();
			Thread.sleep(10000);
		} catch (InterruptedException e) {
		}

		System.out.println("...but he's stuck otside!");
		System.out.println("\nFido starts barking...");
		recognizer.recognize("Woof");
		// System.out.println("\n...so Gina grabs the remote control.");
		// remote.pressButton();
		System.out.println("\nFido's back inside...");

	}

}
