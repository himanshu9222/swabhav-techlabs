package com.techlabs.array;

import java.io.Serializable;

@SuppressWarnings("serial")
public class Serialization implements Serializable{
	
	/**
	 * 
	 */
	//private static final long serialVersionUID = 1L;
	String Fname;
	String Lname;
	
	public Serialization(String f,String l){
		Fname=f;
		Lname=l;
	}
	
	public String getFname(){
		return Fname;
	}
	
	public String getLname(){
		return Lname;
	}
	
}
