package test;

import components.Account;
import components.AccountLogger;
import components.IAccountable;

public class Test {

	public static void main(String[] args) {
		IAccountable acclogger=new AccountLogger(new Account(101, "Himanshu", 500));
		acclogger.deposit(100);
	}

}
