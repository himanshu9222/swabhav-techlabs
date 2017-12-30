package com.techlabs.rectangle;

public class Rectangle {
	private int widthh;
	private int heightt;
	private String colour;

	public String setColour(String s) {
		if (s.equalsIgnoreCase("red") || s.equalsIgnoreCase("blue")
				|| s.equalsIgnoreCase("green")) {
			colour = s;
		}

		else {
			colour = "red";
		}

		return colour;
	}

	public String borderColour() {
		return colour;
	}

	public int getWidth() {
		return widthh;
	}

	public int setWidth(int w) {
		int a = set(w);
		return widthh = a;
	}

	public int getHeight() {
		return heightt;
	}

	public int setHeight(int h) {
		int a = set(h);
		return heightt = a;
	}

	public int set(int x) {
		if (x < 1) {
			x = 1;
		} else if (x > 100) {
			x = 100;
		}
		return x;

	}

	public int calculateArea() {
		return widthh * heightt;
	}

	
}
