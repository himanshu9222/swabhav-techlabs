package com.techlabs.array;

public class CustomArithmeticException extends ArithmeticException {
	private static final long serialVersionUID = 652325545058196579L;

	public CustomArithmeticException(String s) {
		//Constructs an ArithmeticException with specified detail message 
		super(s);
	}
}
