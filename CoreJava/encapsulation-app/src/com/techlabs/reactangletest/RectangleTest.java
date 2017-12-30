package com.techlabs.reactangletest;

import com.techlabs.rectangle.Rectangle;

public class RectangleTest {

	public static void main(String[] args) {
		Rectangle rectangle1;
		rectangle1 = new Rectangle();
		rectangle1.setWidth(100);
		rectangle1.setHeight(-5);
		rectangle1.setColour("Green");
		
		Rectangle rectangle2=new Rectangle();
		rectangle2.setWidth(50);
		rectangle2.setHeight(50);
		rectangle2.setColour("pink");
		
		Rectangle rectangle3=rectangle2;
		rectangle3.setWidth(10);
		rectangle3.setHeight(10);
        
		//printDetails(rectangle1);
		//printDetails(rectangle2);
		printDetails(new Rectangle());
	}
	public static void printDetails(Rectangle rectangle){
		System.out.println("Height="+rectangle.getHeight());
		System.out.println("Width="+rectangle.getWidth());
		System.out.println("Area="+rectangle.calculateArea());
		System.out.println("Colour="+rectangle.borderColour());
		
	}
		
	}
	
