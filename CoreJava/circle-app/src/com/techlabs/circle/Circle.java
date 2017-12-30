package com.techlabs.circle;

public class Circle {

	private final float radius;
	private BorderStyleOption borderstyle;

	public Circle(float r) {
		radius = r;
	}

	public BorderStyleOption getBorderstyle() {
		return borderstyle;
	}

	public void setBorderstyle(BorderStyleOption borderstyle) {
		this.borderstyle = borderstyle;
	}

	public float getRadius() {
		return radius;
	}

	public Circle(float rad, BorderStyleOption border_style) {
		radius = rad;
		setBorderstyle(border_style);

	}

	public float calculateArea() {
		return (float) (3.14 * radius);
	}

	

}
