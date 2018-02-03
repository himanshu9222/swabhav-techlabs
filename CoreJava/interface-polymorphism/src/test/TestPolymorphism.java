package test;

import polymorphismcomponets.Boy;
import polymorphismcomponets.IEmotionable;
import polymorphismcomponets.IMannerable;
import polymorphismcomponets.Man;

public class TestPolymorphism {

	public static void main(String[] args) {
		Man x = new Man();
		Boy y = new Boy();
		
		atTheParty(x);
		atTheParty(y);
		
		atTheMovie(y);
		//atTheMovie(x);
	}

	public static void atTheParty(IMannerable obj) {
		System.out.println("\nAt the Party");
		obj.depart();
		obj.wish();
	}

	public static void atTheMovie(IEmotionable obj) {
		System.out.println("\nAt the Movie");
		obj.cry();
		obj.laugh();
	}
}
