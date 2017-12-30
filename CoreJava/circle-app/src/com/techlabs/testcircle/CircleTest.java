package com.techlabs.testcircle;

import com.techlabs.circle.BorderStyleOption;
import com.techlabs.circle.Circle;

public class CircleTest {

	public static void main(String[] args) {
		Circle c1=new Circle(2.5f);
		c1.getRadius();
		new Circle(2.5f,BorderStyleOption.Single);
		c1.calculateArea();
		System.out.println(c1.calculateArea());
		
		Circle[] circles=new Circle[3];
		circles[0]= new Circle(2.5f);
		circles[1]= new Circle(2.5f,BorderStyleOption.Dotted);
		circles[2]= new Circle(2.5f,BorderStyleOption.Double);
		
		for(Circle circle:circles){
			displayDeails(circle);
		}
		
	}

	public static void displayDeails(Circle circle) {
		System.out.println(circle.getRadius());
		System.out.println(circle.calculateArea());
		System.out.println(circle.getBorderstyle());
		
	}

}
