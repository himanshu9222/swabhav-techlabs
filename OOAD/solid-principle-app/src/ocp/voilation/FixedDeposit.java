package ocp.voilation;

public class FixedDeposit {
	private int accountNumber;
	private String name;
	private double principle;
	private int years;
	FestivalType festival;
	
	public FixedDeposit(int accountNumber,String name,double principle,int years,FestivalType festival){
		this.accountNumber=accountNumber;
		this.name=name;
		this.principle=principle;
		this.years=years;
		this.festival=festival;
	}
	
	public double calculateTotalInterest(){
		if(festival.equals(FestivalType.HOLI)){
			return (principle*years*(8.5))/100;
		}
		if(festival.equals(FestivalType.NEW_YEAR)){
			return (principle*years*(8))/100;
		}
		if(festival.equals(FestivalType.NORMAL)){
			return (principle*years*(7))/100;
		}
		return -1;
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
