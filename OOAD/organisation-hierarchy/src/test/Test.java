package test;

import java.io.IOException;

import parser.EmployeeDTO;
import loader.FileLoader;
import components.DisplayHierarchy;
import components.OrganisationBuilder;

public class Test {

	public static void main(String[] args) throws IOException {
		OrganisationBuilder da = new OrganisationBuilder(new EmployeeDTO(new FileLoader()));
		DisplayHierarchy display=new DisplayHierarchy();
		display.display(da);
	}
}
