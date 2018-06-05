package test;

import refactored.DataService;

public class TestDataService {

	public static void main(String[] args) {
		DataService ds1 = DataService.getInstance();
		DataService ds2 = DataService.getInstance();

		System.out.println(ds1.hashCode());
		System.out.println(ds2.hashCode());

		ds1.doService();
		ds2.doService();

	}

}
