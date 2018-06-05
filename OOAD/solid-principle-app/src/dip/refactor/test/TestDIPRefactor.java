package dip.refactor.test;

import dip.refactor.Csv;
import dip.refactor.TaxCalculator;


public class TestDIPRefactor {
	public static void main(String[] args) {
		TaxCalculator tc=new TaxCalculator(new Csv());
		System.out.println(tc.calculate(1000, 0));
		
	}
}
