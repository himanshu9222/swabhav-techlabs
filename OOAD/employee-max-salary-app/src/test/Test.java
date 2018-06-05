package test;

import java.io.IOException;

import parser.CSVParser;
import loader.FileLoader;
import loader.WebLoader;
import components.DataAnalyser;
import components.Employee;

@SuppressWarnings("unused")
public class Test {

	public static void main(String[] args) throws IOException {
		DataAnalyser da = new DataAnalyser(new CSVParser(new FileLoader()));
		Employee employee = da.getSalary();
		System.out.println("The Employee Name with max salary is = "
				+ employee.getName() + "\n" + employee.getDoteOfJoining()
				+ "Salary is = " + employee.getSalary());
		da.getDeptWiseNumberOfEmployee();
		da.getRolesWiseNumberOfEmployee();
	}
}
