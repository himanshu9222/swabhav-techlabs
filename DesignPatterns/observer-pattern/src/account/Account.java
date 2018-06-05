package account;

import java.util.ArrayList;
import accountlistener.IAccountListener;

public class Account {
	private int id;
	private String name;
	private int balance;
	private int mobileno;
	private String email;
	ArrayList<IAccountListener> list=new ArrayList<IAccountListener>();
	
	public Account(int id,String name,int balance,int mobileno, String email){
		this.setId(id);
		this.setName(name);
		this.setBalance(balance);
		this.setMobileno(mobileno);
		this.setEmail(email);
	}
	
	public void deposit(int amt){
		this.balance=this.balance+amt;
		this.notifyAccount();
	}
	
	public void withdraw(int amt){
		this.balance=this.balance-amt;
		this.notifyAccount();
	}
	
	private void notifyAccount(){
		for(IAccountListener accountListner : list){
			accountListner.balanceChanged(this);
		}
	}

	public void addListener(IAccountListener listener){
		list.add(listener);
	}
	public int getBalance() {
		return balance;
	}

	public void setBalance(int balance) {
		this.balance = balance;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getMobileno() {
		return mobileno;
	}

	public void setMobileno(int mobileno) {
		this.mobileno = mobileno;
	}

	public String getEmail() {
		return email;
	}

	public void setEmail(String email) {
		this.email = email;
	}
	
	
}
