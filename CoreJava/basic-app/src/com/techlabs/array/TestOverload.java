package com.techlabs.array;

public class TestOverload {

	public static void main(String[] args) {
		print();
		print('=');
		print(3);
		print(10.5f);
		print(10.58);
		}
	
	private static void print()
	{
		System.out.print("-------------------------");
	}
	
	private static void print(char str)
	{
		for(int pattern=0;pattern<20;pattern++)
		System.out.print(str);
	}
	
	private static void print(int no)
	{
		System.out.print(no);
	}
	
	private static void print(float no)
	{
		System.out.print(no);
	}
	
	private static void print(double no)
	{
		System.out.print(no);
	}
	

}
