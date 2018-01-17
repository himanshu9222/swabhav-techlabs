package com.techlabs.inheritance.test;

import com.techlabs.inheritance.Boy;
import com.techlabs.inheritance.Infant;
import com.techlabs.inheritance.Kid;
import com.techlabs.inheritance.Man;

public class TestInheritance {
	
	public static void main(String[] args) {
		//case1();
		case2();
		//case3();
		//case4();
	}

	public static void case1() {
			Man x;
			x=new Man();
			x.eat();
			x.play();
			x.read();
	}

	public static void case2() {
			Boy y;
			y=new Boy();
			y.eat();
			y.read();
			y.walk();
			y.play();
	}

	public static void case3() {
			Man x;
			x=new Boy();
			x.eat();
			x.read();
			x.play();
	}

	public static void case4() {
		atThePark(new Man());
		atThePark(new Boy());
		atThePark(new Kid());
		atThePark(new Infant());
	}

	public static void atThePark(Man x){
		System.out.println("At the Park");
		x.play();
	}
}
