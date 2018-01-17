package account.polymorphism;

public abstract class Account {
	protected int accno;
	private static int accnoGenerator;
	private String name;
	protected double balance;
	protected static int countDeposit;
	protected static int countWithdraw;

	static {
		accnoGenerator = 10000;
		countDeposit=0;
		countWithdraw=0;
	}

	public Account(String n, double b) {
		accnoGenerator++;
		name = n;
		balance = b;
		accno=accnoGenerator;
	}

	public void deposit(int amt) {
		balance += amt;
		countDeposit+=1;
	}

	public int getAccountNumber(){
		return accno;
	}

	public String getName() {
		return name;
	}

	public double getBalance() {
		return balance;
	}

	public abstract void withdraw(double amt);
	
	public int getWithdrawCount(){
		return countWithdraw;
	}
	
	public int getDepositCount(){
		return countDeposit;
	}
}
