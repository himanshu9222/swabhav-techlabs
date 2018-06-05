package ocp.refactor;

public class FixedDeposit {
	private int accountNumber;
	private String name;
	private double principle;
	private int years;
	IFestivalRate festival;

	public FixedDeposit(int accountNumber, String name, double principle,
			int years, IFestivalRate festival) {
		this.accountNumber = accountNumber;
		this.name = name;
		this.principle = principle;
		this.years = years;
		this.festival = festival;
	}

	public double calculateTotalInterest() {
		double rate = this.festival.getRate();
		return (principle * years * rate) / 100;
	}

	public int getAccountNumber() {
		return accountNumber;
	}

	public void setAccountNumber(int accountNumber) {
		this.accountNumber = accountNumber;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

}
