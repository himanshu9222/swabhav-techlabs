package com.techlabs.account.test;

import com.techlabs.account.Account;
import com.techlabs.account.InsufficientFundException;

public class AccountTest {

	public static void main(String[] args) {
		Account acc = new Account(123, "himanshu", 300);
		try {
			acc.withdraw(100);
		} 
		catch (InsufficientFundException ex) {
			System.out.println(ex.getMessage());
		}
		catch (Exception ex) {
			System.out.println(ex.getMessage());
		}
		
		
		printDetails(acc);

		Account acc1 = new Account(124, "him");
		acc1.deposit(200);
		printDetails(acc1);
	}

	public static void printDetails(Account o) {
		System.out.println("AccountNumber=" + o.getAccountNumber() + "\n Name="
				+ o.getName() + "\n Balance=" + o.getBalance() + "\nCount="
				+ o.getCount());

	}

}
