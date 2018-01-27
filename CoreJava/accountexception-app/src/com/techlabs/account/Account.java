package com.techlabs.account;

public class Account {
	private final int accountNumber;
	private final String name;
	private double balance;
	private static int count;
	private static final double Minimum_Balance = 500;

	public Account(int a, String n, double b) {
		this.accountNumber = a;
		this.name = n;
		this.balance = b;
		count += 1;
		System.out.println("Inside the constructor block");
	}

	static {
		count = 100;
		System.out.println("Inside the Static block");
	}

	public Account(int a, String n) {
		this(a, n, 500.0);
	}

	public void deposit(double amt) {
		balance = balance + amt;
	}

	public void withdraw(double amt) {
		if (balance - amt > Minimum_Balance) {
			balance = balance - amt;
		} else
			throw new InsufficientFundException(this, amt);
	}

	public int getAccountNumber() {
		return accountNumber;
	}

	public String getName() {
		return name;
	}

	public double getBalance() {
		return balance;
	}

	public int getCount() {
		return count;
	}

	public static int getHeadCount() {
		return count;
	}
}
