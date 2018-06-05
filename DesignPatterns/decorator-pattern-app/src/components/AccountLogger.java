package components;

public class AccountLogger implements IAccountable{

	protected IAccountable acc;
	
	public AccountLogger(IAccountable acc) {
		this.acc=acc;
	}
	
	@Override
	public void deposit(int amt) {
		System.out.println("Before deposit");
		this.acc.deposit(amt);	
		System.out.println("After deposit");
	}

	@Override
	public void withdraw(int amt) {
		System.out.println("Before withdraw");
		this.acc.withdraw(amt);	
		System.out.println("After withdraw");
	}
}
