package account.polymorphism.test;

import account.polymorphism.Account;
import account.polymorphism.CurrentAccount;
import account.polymorphism.SavingAccount;

public class Test {

	public static void main(String[] args) {
		Account acc = new SavingAccount("Himanshu", 5000);
		Account acc1 = new CurrentAccount("Ramesh", 2000);
		printDetails(acc);
		printDetails(acc1);
		acc.withdraw(4000);
		acc1.withdraw(4000);
		printDetails(acc);
		printDetails(acc1);
		
	}

	public static void printDetails(Account acc) {
		System.out.println("AccountNumber = " + acc.getAccountNumber()
				+ "\nName = " + acc.getName() + "\nBalance = "
				+ acc.getBalance() + "\nNo of withdraw = "
				+ acc.getWithdrawCount() + "\n No of Deposit = "
				+ acc.getDepositCount());
	}

}
