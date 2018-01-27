package com.techlabs.account;

public class InsufficientFundException extends RuntimeException {

	private int accno;
	private String name;
	private double balance;

	public InsufficientFundException(Account acc, double amt) {
		this.accno = acc.getAccountNumber();
		this.name = acc.getName();
		this.balance = acc.getBalance();
	}

	@Override
	public String getMessage() {
		return "\nInsufficient Account Balance In Your Account Number " + accno
				+ "\nAccount Holder Name:" + name + "\nBalance is " + balance
				+ "\nYou need to maintain your minimum balance 500\n";

	}

}
