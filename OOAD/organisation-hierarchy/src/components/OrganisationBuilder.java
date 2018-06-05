package components;

import java.io.IOException;
import java.util.HashSet;
import java.util.LinkedHashMap;
import parser.EmployeeDTO;

public class OrganisationBuilder {
	HashSet<Employee> employeeList = new HashSet<Employee>();
	HashSet<EmployeeDTOModel> employeeListInString = new HashSet<EmployeeDTOModel>();
	HashSet<Employee> employeeHierarchyList = new HashSet<Employee>();
	EmployeeDTO empDTO;

	public OrganisationBuilder(EmployeeDTO empDTO) throws IOException {
		this.empDTO = empDTO;
		employeeList = loadEmployeeList();
	}

	public HashSet<Employee> loadEmployeeList() throws IOException {
		employeeListInString = empDTO.getListOfEmployeeInStringFormat();
		for (EmployeeDTOModel employee : employeeListInString) {
			if (employee.getManagerId().equals("NULL")) {
				employee.setManagerId("0");
			}
			if (employee.getCommission().equals("NULL")) {
				employee.setCommission("0");
			}
			employeeList.add(new Employee(Integer.parseInt(employee.getId()),
					employee.getName(), employee.getRole(), Integer
							.parseInt(employee.getManagerId()), employee
							.getDoteOfJoining(), Double.parseDouble(employee
							.getSalary()), Double.parseDouble(employee
							.getCommission()), Integer.parseInt(employee
							.getDeptId())));
		}
		return employeeList;
	}

	public void hierarchyClassification() {
		HashSet<Employee> employeeListCopy = employeeList;

		for (Employee employee : employeeListCopy) {
			if (employee.getManagerId() == 0) {
				employeeHierarchyList.add(employee);
				//addRepotees(employee);

				for (Employee employee1 : employeeListCopy) {
					if (employee.getId() == employee1.getManagerId()) {
						employeeHierarchyList.add(employee1);

						// for (Employee employee2 : employeeListCopy) {
						// if (employee1.getId() == employee2.getManagerId()) {
						// employeeHierarchyList.add(employee2);
						// }
						// }
					}
				}
			}
		}

		for (Employee employee : employeeHierarchyList) {
			System.out.println(employee);
		}
	}

	//public void addRepotees(Employee employee) {
		//for (Employee employee1 : employeeList) {
			//if (employee.getId() == employee1.getManagerId()) {
				//employeeHierarchyList.add(employee1);
				//addRepotees(employee1);
			//}
		//}
	//}

	public void display() throws IOException {
		for (Employee employee : employeeList) {
			System.out.println(employee);
		}
	}

	public Employee getSalary() throws IOException {
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
