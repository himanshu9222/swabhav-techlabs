package com.techlabs.students;

public class Students {
	private String fname;
	private String lname;
	private String address;

	public Students(String f, String l, String a) {
		this.fname = f;
		this.lname = l;
		this.address = a;
	}

	public String getFname() {
		return fname;
	}

	public String getLname() {
		return lname;
	}

	public String getAddress() {
		return address;
	}

	public String toString() {
		return fname;
	}
}
