package parser;

import java.io.BufferedReader;
import java.io.IOException;
import java.util.HashSet;

import loader.ILoadable;
import components.Employee;
import components.EmployeeDTOModel;

public class EmployeeDTO {
	HashSet<EmployeeDTOModel> employeeList = new HashSet<EmployeeDTOModel>();
	Employee employee;
	ILoadable load;
	BufferedReader bufferedReader;

	public EmployeeDTO(ILoadable load) {
		this.load = load;
	}

	public HashSet<EmployeeDTOModel> getListOfEmployeeInStringFormat() throws IOException {
		final int ID = 0, NAME = 1, ROLE = 2, MANAGERID = 3, DOJ = 4, SALARY = 5, COMMISSION = 6, DEPTID = 7;
		String finalContent = load.loadFile();
		String[] content = finalContent.split("/");
		for (int i = 0; i < content.length; i++) {
			String[] information = content[i].split(",");
			employeeList.add(new EmployeeDTOModel(information[ID],
					information[NAME], information[ROLE],information[MANAGERID],
					information[DOJ],information[SALARY],
					information[COMMISSION], information[DEPTID]));
		}
		return employeeList;
	}

}
