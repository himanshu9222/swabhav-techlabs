package account.polymorphism;

public class SavingAccount extends Account {

	private static final double MINIMUM_BALANCE = 500.0;

	public SavingAccount(String n, double b) {
		super(n, b);
	}

	@Override
	public void withdraw(double amt) {
		countWithdraw+=1;
		if (balance - amt < MINIMUM_BALANCE) {
			System.out.println("Insufficient Balance");
		} else
			balance -= amt;

	}

}
