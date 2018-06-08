package components;

import java.io.IOException;
import java.util.HashSet;
import java.util.LinkedHashMap;
import java.util.Map;

import parser.EmployeeDTO;

public class OrganisationBuilder {
	private HashSet<Employee> employeeList = new HashSet<Employee>();
	private HashSet<EmployeeDTOModel> employeeListInString = new HashSet<EmployeeDTOModel>();
	private EmployeeDTO empDTO;
	private Map<Integer, Employee> employeeMap = new LinkedHashMap<Integer, Employee>();
	private Employee CEO;

	public OrganisationBuilder(EmployeeDTO empDTO) throws IOException {
		this.empDTO = empDTO;
		employeeList = buildEmployeeList();
		CEO();
	}

	public HashSet<Employee> buildEmployeeList() throws IOException {
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

	public Employee hierarchyClassification() throws IOException {
		for (Employee employee : employeeList) {
			if (employee.getManagerId() == 0) {
				employeeMap.put(employee.getId(), employee);
				break;
			}
		}
		for (Employee employee : employeeList) {
			if (employee.getManagerId() != 0) {
				employeeMap.put(employee.getId(), employee);
			}
		}

		for (Employee emp : employeeList) {
			if (employeeMap.containsKey(emp.getManagerId())) {
				employeeMap.get(emp.getManagerId()).addReportee(emp);
			}
		}

		return employeeMap.entrySet().iterator().next().getValue();
	}
	
	public void CEO(){
		CEO=employeeMap.get(7839);
	}
	
	public Employee getCEO(){
		return CEO;
	}

}
