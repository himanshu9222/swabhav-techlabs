package test;

import components.Bark;
import components.BarkRecognizer;
import components.DogDoor;
import components.Remote;

public class DogDoorSimulator {

	public static void main(String[] args) {
		DogDoor door = new DogDoor();
		door.addAllowedBark(new Bark("rowlf"));
		door.addAllowedBark(new Bark("rooowlf"));
		door.addAllowedBark(new Bark("rawlf"));
		door.addAllowedBark(new Bark("woof"));
		BarkRecognizer recognizer = new BarkRecognizer(door);
		Remote remote = new Remote(door);

		// Simulate the hardware hearing a bark
		System.out.println("Bruce starts barking");
		recognizer.recognize(new Bark("rowlf"));

		System.out.println("\nBruce has gone outside...");

		try {
			Thread.currentThread();
			Thread.sleep(10000);
		} catch (InterruptedException e) {
		}

		System.out.println("\nBruce's all done...");
		System.out.println("...but he's stuck otside!");

		// Simulate the hardware hearing a not a Bruce bark
		System.out.println("\nA small start barking...");
		recognizer.recognize(new Bark("yip"));

		try {
			Thread.currentThread();
			Thread.sleep(5000);
		} catch (InterruptedException e) {
		}

		// Simulate the hardware hearing a bark
		System.out.println("Bruce starts barking");
		recognizer.recognize(new Bark("rooowlf"));
		
		System.out.println("\nBruce back Inside");
	}

}
