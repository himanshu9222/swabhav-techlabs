package com.techlabs.teststudents;

import java.util.ArrayList;
import java.util.Scanner;

import com.techlabs.students.Students;

public class TestStudent {
	static ArrayList<Students> studentsList = new ArrayList<Students>();
	Scanner sc = new Scanner(System.in);
	static int choice;

	public static void main(String[] args) {

		do {
			System.out
					.println("Enter\n 1.Display all student\n 2.AddStudent\n 3.No of student\n 4.Exit");
			new TestStudent().choice();
			switch (choice) {
			case 1:
				new TestStudent().displayStudents();
				break;
			case 2:
				new TestStudent().getStudentDetails();
				break;
			case 3:
				new TestStudent().displaySize();
				break;
			}
		} while (choice <= 3);
	}

	public void getStudentDetails() {
		System.out.println("Enter the Students Details in format\n Firstname");
		String fname = sc.nextLine();
		System.out.println("Lastname");
		String lname = sc.nextLine();
		System.out.println("Address");
		String address = sc.nextLine();
		Students s = new Students(fname, lname, address);
		studentsList.add(s);
		System.out.println(studentsList.size());

	}

	public void displayStudents() {
		System.out.println(studentsList.toString());
	}

	public void displaySize() {
		System.out.println(studentsList.size());
	}

	public void choice() {
		choice = sc.nextInt();
	}

}
