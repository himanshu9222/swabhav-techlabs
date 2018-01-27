package com.techlabs.teststudents;

import java.util.ArrayList;

import java.util.Scanner;

import com.techlabs.students.Student;

public class TestStudent {
	static ArrayList<Student> studentsList = new ArrayList<Student>();
	Student student=new Student();
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
		System.out.println("Enter the Students Details in format\n Id");
		String id = sc.nextLine();
		System.out.println("name");
		String name = sc.nextLine();
		System.out.println("Email");
		String email = sc.nextLine();
		Student s = new Student();
		student.setId(id);
		student.setName(name);
		student.setEmail(email);
		
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
