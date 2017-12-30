package com.techlabs.array;

public class TestStudent {

	public static void main(String[] args) {
		Student students = new Student();
		
		students.setName("Santosh");
		students.setLName("Singh");
		students.setEmail("santosh123@gmail.com");
		
		String resume=students.BuildResume();
		
		System.out.println(resume);
		
		
	}
}

