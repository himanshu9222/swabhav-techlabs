package com.techlabs.array;

import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class StudentHtml {
	private String Fname;
	private String number;
	private String Email;

	public String getName() {
		return Fname;
	}

	public String setName(String name) {
		return this.Fname = name;
	}

	public String getMobileNo() {
		return number;
	}

	public String setMobileNo(String no) {
		return this.number = no;

	}

	public String getEmail() {
		return Email;
	}

	public String setEmail(String mail) {
		return this.Email = mail;
	}

	public String BuildResume() {
		System.out.println();

		String resume = "<html><head><title>Resume</title></head><body style=’background-color:#ccc’>";
		resume += "<h1>Resume</h1><h3><p>Name         :  " + getName();
		resume += "</p></h3><h3><p>Email        :  " + getEmail();
		resume += "</p></h3><h3><p>Phone        :  " + getMobileNo()
				+ "</p></h3></body></html>";
		return resume;
	}

	public void build() {
		File file = new File("MyHtml.html");   //it should be always in a function
		// FileWriter fileWriter = null;
		// BufferedWriter bufferWriter;
		try {
			FileWriter fileWriter = new FileWriter(file);
			BufferedWriter bufferWriter = new BufferedWriter(fileWriter);

			String html = BuildResume();
			bufferWriter.write(html);
			System.out.println("Html Page created");
			bufferWriter.flush();// it is used to throw the IOException
			fileWriter.flush();
			bufferWriter.close();
			fileWriter.close();
		} catch (IOException ex) {
			ex.printStackTrace();
		}
	}
}

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