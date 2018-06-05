package studentdetail.components;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

import studentdetail.resume.BuildResume;

public class StudentConsole {
	BuildResume build = new BuildResume();

	StudentSerializer serialize = new StudentSerializer();
	StudentDeserializer deserialize = new StudentDeserializer();
	StudentDataStore store = new StudentDataStore();
	Student student = new Student();
	public Scanner input = new Scanner(System.in);

	public void menu() throws IOException, NullPointerException,
			ClassNotFoundException {
		store.load();
		System.out.println("Size of List is :"
				+ store.getAllStudentList().size());
		int flag = 1;
		while (flag != 0) {
			System.out
					.println("Type the following keyword to perform the actions\nAdd   Display   Search   Remove   BuildResume   Exit");
			String choice = input.nextLine().toLowerCase();
			switch (choice) {
			case "add":
				store.addStudent(getDetails());
				break;

			case "display":
				printDetails(store.getAllStudentList());
				System.out.println("Size of List is :"
						+ store.getAllStudentList().size());
				break;

			case "search":
				
				System.out.println("Enter the Starting Letter of Student");
				ArrayList<Student> matchingStudent = store.searchStudent(input.nextLine());
				printDetails(matchingStudent);
				break;

			case "remove":
				System.out.println("Enter the Id of Student");
				store.removeStudent(input.nextLine());
				break;

			case "buildresume":
				build.buildResume(store.getAllStudentList());
				break;

			case "exit":
				flag = 0;
				break;

			default:
				System.out.println("Enter correct choice");
				break;
			}
		}
		store.save(store.getAllStudentList());
	}

	public Student getDetails() {
		Student detail = new Student();
		// System.out.println("Enter Student Id:");
		detail.setId();
		System.out.println("Enter Student Name:");
		detail.setName(input.nextLine());
		System.out.println("Enter Student Email:");
		detail.setEmail(input.nextLine());
		return detail;
	}

	public void printDetails(ArrayList<Student> studentList) {
		for (Student detail : studentList) {
			System.out.println("Id : " + detail.getId() + "\tName : "
					+ detail.getName() + "\tEmail : " + detail.getEmail());
		}
	}

	/*public void printDetails(Student student) {
		Student detail = student;
		System.out.println("Id : " + detail.getId() + "\tName : "
				+ detail.getName() + "\tEmail : " + detail.getEmail());
	}*/

}
