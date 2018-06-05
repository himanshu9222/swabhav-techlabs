package ocp.voilation.test;

import ocp.voilation.FestivalType;
import ocp.voilation.FixedDeposit;

public class TestFixedDeposit {

	public static void main(String[] args) {
		FixedDeposit fixedDeposit=new FixedDeposit(123, "Himanshu",10000 , 3, FestivalType.HOLI);
		System.out.println(fixedDeposit.calculateTotalInterest());

	}

}
