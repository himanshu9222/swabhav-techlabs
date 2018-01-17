package com.techlabs.array;

import java.util.Scanner;

public class TestHtmlResumeBuilder {
	static StudentHtml students = new StudentHtml();

	public static void main(String[] args) {

		takeInput();
		students.build();
	}

	public static void takeInput() {
		@SuppressWarnings("resource")
		Scanner input = new Scanner(System.in);

		System.out.println("Enter Name of Student");
		students.setName(input.nextLine());
		System.out.println("Enter Mobile Number of Student");
		students.setMobileNo(input.nextLine());
		System.out.println("Enter Email of Student");
		students.setEmail(input.nextLine());
	}
}

// File file = new
// File("C://Swabhav Techlabs/cloudrepository/MyFirstProject/CoreJava/basic-app/MyHtml.html");

// if (file.exists()) {
// System.out.println("File Already Exist");
// } else {
// FileWriter fileWriter = null;
// BufferedWriter bufferWriter = null;

// try {
// fileWriter = new FileWriter(file);
// bufferWriter = new BufferedWriter(fileWriter);

// String html =
// "<html><head><title>Resume</title></head><body style=’background-color:#ccc’>";
// bufferWriter.write(html);
// align="center"
// bufferWriter
// .append("<h1>Resume</h1><h3><p>Name         :  Himanshu Lal</p></h3><h3><p>DOB          :  24/08/1996</p></h3><h3><p>Email        :  himanshulal65@gmail.com</p></h3><h3><p>Phone        :  8087222901</p></h3><h3><p>Qualification:  BE</p></h3></body></html>");

// System.out.println("Html Page created");
// bufferWriter.flush();// it is used to throw the IOException
// error
// fileWriter.flush();
// }

// catch (IOException ex) {
// ex.printStackTrace();
// }

// finally {
// try {
// BufferedWriter bufferWriter = null;
// bufferWriter.close();
// BufferedWriter fileWriter = null;
// fileWriter.close();
// } catch (IOException e) {
// e.printStackTrace();
// }
// }
// }