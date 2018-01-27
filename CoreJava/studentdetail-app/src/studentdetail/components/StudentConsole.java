package studentdetail.components;

import java.io.IOException;
import java.util.ArrayList;
import java.util.Scanner;

public class StudentConsole {
	private static ArrayList<Student> studentList = new ArrayList<Student>();
	PrintDetails print = new PrintDetails();
	Student getDetail = new Student();
	BuildResume build = new BuildResume();
	SerializeStudent serialize = new SerializeStudent();
	public Scanner input = new Scanner(System.in);

	public void switchcase() throws IOException, NullPointerException,
			ClassNotFoundException {
		//serialize.deserializeObject(studentList);
		int flag = 1;
		while (flag != 0) {
			System.out
					.println("Type the following keyword to perform the actions\nAdd\nDisplay\nBuildResume\nExit");
			String choice = input.nextLine().toLowerCase();
			switch (choice) {
			case "add":
				studentList = getDetail.getDetails();
				serialize.serializeObject(studentList);
				break;
			case "display":
				print.printDetails(studentList);
				System.out.println("Size of List is :" + studentList.size());
				break;
			case "buildresume":
				build.buildResume(studentList);
				break;
			case "exit":
				flag = 0;
				break;
			default:
				System.out.println("Enter correct choice");
				break;
			}
		}
	}

}
