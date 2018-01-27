package studentdetail.components;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.Scanner;

public class Student implements Serializable{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String id="";
	private String name="";
	private String email="";
	ArrayList<Student> studentList = new ArrayList<Student>();
	transient public Scanner input = new Scanner(System.in);

	public void setId(String id) {
		this.id = id;
	}

	public void setName(String name) {
		this.name = name;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public String getEmail() {
		return email;
	}

	public ArrayList<Student> getDetails() {
		Student detail = new Student();
		System.out.println("Enter Student Id:");
		detail.setId(input.nextLine());
		System.out.println("Enter Student Name:");
		detail.setName(input.nextLine());
		System.out.println("Enter Student Email:");
		detail.setEmail(input.nextLine());
		studentList.add(detail);
		return studentList;

	}

}
