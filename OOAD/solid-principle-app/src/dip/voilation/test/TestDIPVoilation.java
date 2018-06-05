package dip.voilation.test;

import dip.voilation.LogType;
import dip.voilation.TaxCalculator;

public class TestDIPVoilation {

	public static void main(String[] args) {
		TaxCalculator tc=new TaxCalculator(LogType.XML);
		System.out.println(tc.calculate(1000, 5));

	}

}
