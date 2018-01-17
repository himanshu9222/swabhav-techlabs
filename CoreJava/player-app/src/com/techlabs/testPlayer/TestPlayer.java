package com.techlabs.testPlayer;

import com.techlabs.player.Player;

public class TestPlayer {

	public static void main(String[] args) {
		caseStudy1();
		Player sachin = new Player(10, "Sachin", 45);
		Player virat = new Player(10, "Sachin", 45);

		System.out.println(sachin == virat);
		System.out.println(sachin.equals(virat));

	}

	private static void caseStudy1() {
		Player sachin = new Player(10, "Sachin", 45);
		Player virat = new Player(10, "Sachin");

		System.out.println(sachin.equals(virat));
		System.out.println(sachin == virat);

		Player elder = sachin.whoIsElder(virat);
		System.out.println(sachin.getAge());
		System.out.println(virat.getAge());
		// System.out.print(virat.setAge(18));
		System.out.println(elder.getName());

		System.out.println(sachin);

		// System.out.println(sachin.toString());
	}

}
