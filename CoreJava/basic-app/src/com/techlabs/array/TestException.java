package com.techlabs.array;

public class TestException {
	public static void main(String [] args) {
		try{
			testArithmeticException();
		}
		catch(CustomArithmeticException ex){
			System.out.println("Caught CustomArithmeticException()\t"+ex.getMessage());
		}
		}
	private static void testArithmeticException(){
		int divbyzero=0;
		try{
			divbyzero=100/0;
			System.out.println("Divided by zero="+divbyzero);
		}
		catch(ArithmeticException ex){
			throw new CustomArithmeticException("ArithmeticException occurred : " +ex.getMessage());
		}
	}
}
