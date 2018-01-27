package com.techlabs.students;

import java.io.Serializable;

public class Student implements Serializable{
	
	private String id;
	private String name;
	private String email;

	//public Student(String f, String l, String a) {
		//this.id = f;
		//this.name = l;
		//this.email = a;
	//}

	public void setName(String n){
		this.name=n;
	}
	
	public void setId(String id){
		this.id=id;
	}

	public void setEmail(String e){
		this.email=e;
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

	@Override
	public String toString() {
		return id+ "\t"+name+"\t"+email;
	}
}
