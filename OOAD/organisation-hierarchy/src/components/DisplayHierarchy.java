package components;

import java.io.IOException;

public class DisplayHierarchy {

	public void printReportees(Employee employee, int level) {
		for (Employee emp : employee.getReportees()) {
			System.out.println(String.format("%" + level + "s","    "+emp.getRole()+ " -> " +emp.getName()));
			printReportees(emp, level + 10);
		}
	}

	public void display(OrganisationBuilder build) throws IOException {
		Employee employee = build.hierarchyClassification();
		System.out.println(employee.getRole()+ " -> " +employee.getName());
		printReportees(employee, 10);
	}

}
