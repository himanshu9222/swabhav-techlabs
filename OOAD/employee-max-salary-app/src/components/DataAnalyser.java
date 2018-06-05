package components;

import java.io.IOException;
import java.util.HashSet;
import java.util.LinkedHashMap;

import parser.IParsable;

public class DataAnalyser {
	HashSet<Employee> employeeList = new HashSet<Employee>();
	IParsable parse;

	public DataAnalyser(IParsable parser) {
		parse = parser;
	}

	public HashSet<Employee> loadEmployeeList() throws IOException {
		employeeList = parse.parse();
		return employeeList;
	}

	public Employee getSalary() throws IOException {
		employeeList = loadEmployeeList();
		double temp = 0;
		Employee employeeWithMaxSalary = null;
		for (Employee employee : employeeList) {
			if (employee.getSalary() > temp) {
				temp = employee.getSalary();
				employeeWithMaxSalary = employee;
			}
		}
		return employeeWithMaxSalary;
	}

	public void getDeptWiseNumberOfEmployee() {

		LinkedHashMap<Integer, Integer> employeeWithId = new LinkedHashMap<Integer, Integer>();
		for (Employee employee : employeeList) {
			if (!employeeWithId.containsKey(employee.getDeptId())) {
				int count = 1;
				employeeWithId.put(employee.getDeptId(), count);
			} else
				employeeWithId.put(employee.getDeptId(),
						employeeWithId.get(employee.getDeptId()) + 1);
		}
		System.out.println(employeeWithId);
	}

	public void getRolesWiseNumberOfEmployee() {

		LinkedHashMap<String, Integer> employeeWithRole = new LinkedHashMap<String, Integer>();
		for (Employee employee : employeeList) {
			if (!employeeWithRole.containsKey(employee.getRole())) {
				int count = 1;
				employeeWithRole.put(employee.getRole(), count);
			} else
				employeeWithRole.put(employee.getRole(),
						employeeWithRole.get(employee.getRole()) + 1);
		}
		System.out.println(employeeWithRole);
	}
}
