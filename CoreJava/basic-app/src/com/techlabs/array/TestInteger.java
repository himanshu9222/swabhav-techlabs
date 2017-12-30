package com.techlabs.array;

public class TestInteger {

	public static void main(String[] args) {
		int mark = 100;
		changeMark(mark);
		System.out.println(mark);
		int[] marks = { 10, 20, 30, 40 };
		changeMarks(marks);
		for (int display : marks) {
			System.out.println(display);
		}
	}

	static void changeMark(int markPass) {
		markPass = 0;
	}

	static void changeMarks(int marksPass[]) {
		for (int count = 0; count < marksPass.length; count++) {
			marksPass[count] = 0;
		}
	}
}
