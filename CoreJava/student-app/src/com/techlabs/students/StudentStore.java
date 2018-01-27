package com.techlabs.students;

import java.io.*;
import java.util.ArrayList;


public class StudentStore {

	
	//private static FileOutputStream fileOutputStream;
	//private static FileInputStream fileInputStream;
	//private static ObjectOutputStream objectOutputStream;
	//private static ObjectInputStream objectInputStream;
	//private static String defaultPath = "src//com//techlabs//students//";
	private static ArrayList<Student> studentList = new ArrayList<Student>();
	private static BufferedReader bufferedReader = new BufferedReader(
			new InputStreamReader(System.in));

	public static void main(String args[]) throws IOException, ClassNotFoundException, FileNotFoundException {
		
		

		int choice;
		do {
			
			System.out.println("1. Add \n2. Display \n3. Count\n4. Exit");
			System.out.println("Enter your choice: ");
			choice = Integer.parseInt(bufferedReader.readLine());
			if (choice == 1)
				addStudentRecord();
			else if (choice == 2)
				displayStudentRecords();
			else if (choice == 3)
				countStudentRecords();
			else if(choice == 4)
				break;
			else
				System.out.println("Enter correct choice...");
		} while(true);

		
	}

	
	
	//To add student record in ArrayList
	private static void addStudentRecord() throws IOException {
		Student student = new Student();
		System.out.println("Enter Data to add new Student:");
		System.out.println("First Name: ");
		student.setId(bufferedReader.readLine());
		System.out.println("Last Name: ");
		student.setName(bufferedReader.readLine());
		System.out.println("Address: ");
		student.setEmail(bufferedReader.readLine());
		studentList.add(student);
	}
	
	//To Display all student records
	private static void displayStudentRecords() {
		int count = 0;
		for (Student student : studentList) {
			System.out.println("\nStudent " + (++count) + ": ");
			displayStudentDetails(student);
		}
	}

	//To display particular student record
	private static void displayStudentDetails(Student student) {
		System.out.println("Id: " + student.getId() + " "
				+ student.getName());
		System.out.println("Address: " + student.getEmail());
	}

	//To count student record in the list
	private static void countStudentRecords() {
		System.out.println(studentList.size());
	}

	
}
