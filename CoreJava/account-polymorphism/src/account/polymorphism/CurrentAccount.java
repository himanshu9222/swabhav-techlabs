package account.polymorphism;

public class CurrentAccount extends Account {

	private static final double OVERDRAFT = -5000.0;

	public CurrentAccount(String n, double b) {
		super(n, b);
		
	}

	@Override
	public void withdraw(double amt) {
		countWithdraw+=1;
		if (balance - amt < OVERDRAFT) {
			System.out.println("Insufficient Balance");
		} else
			balance -= amt;

	}


}
