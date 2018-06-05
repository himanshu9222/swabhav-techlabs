package test;

import account.Account;
import accountlistener.EmailAccountListener;
import accountlistener.IAccountListener;
import accountlistener.SmsAccountListener;

public class Test {
	public static void main(String args[]) {
		IAccountListener listner1 = new SmsAccountListener();
		IAccountListener listner2 = new EmailAccountListener();

		Account acc = new Account(101, "Hiamsnhu", 5000, 80872,
				"himanshulal65@gmail.com");
		
		acc.addListener(listner1);
		acc.addListener(listner2);
		
		acc.deposit(100);
		acc.withdraw(200);
	}
}
