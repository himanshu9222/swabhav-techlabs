package ocp.voilation.test;

import ocp.refactor.NewYear;
import ocp.refactor.FixedDeposit;

public class TestRefactoredFixedDeposit {

	public static void main(String[] args) {
		FixedDeposit fixedDeposit = new FixedDeposit(123, "Himanshu", 10000, 3,
				new NewYear());
		System.out.println(fixedDeposit.calculateTotalInterest());
	}

}
