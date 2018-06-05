package components;

public class Account implements IAccountable{
	private int id;
	private String name;
	private int balance;
	
	public int getBalance() {
		return balance;
	}

	public void setBalance(int balance) {
		this.balance = balance;
	}

	public Account(int id,String name, int balance){
		this.setId(id);
		this.setName(name);
		this.balance=balance;
	
	}

	@Override
	public void deposit(int amt) {
		this.balance= this.balance+amt;
		System.out.println(balance);
	}

	@Override
	public void withdraw(int amt) {
		this.balance=this.balance-amt;
		System.out.println(balance);
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
}
