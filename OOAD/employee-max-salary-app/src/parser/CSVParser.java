package parser;

import java.io.BufferedReader;
import java.io.IOException;
import java.util.HashSet;

import components.Employee;
import loader.ILoadable;

public class CSVParser implements IParsable {
	HashSet<Employee> employeeList = new HashSet<Employee>();
	Employee employee;
	ILoadable load;
	BufferedReader bufferedReader;
	public CSVParser(ILoadable load) {
		this.load=load;
	}

	@Override
	public HashSet<Employee> parse() throws IOException {
		final int ID=0,NAME=1,ROLE=2,MANAGERID=3,DOJ=4,SALARY=5,COMMISSION=6,DEPTID=7;
		String finalContent = load.loadFile();
		//System.out.println(finalContent);
		String[] content = finalContent.split("/");
		for (int i = 0; i < content.length; i++) {
			String[] information = content[i].split(",");
			if(information[3].equals("NULL")){
				information[3]="0";
			}
			if(information[6].equals("NULL")){
				information[6]="0";
			}
				employeeList.add(new Employee(Integer.parseInt(information[ID]),
					information[NAME], information[ROLE], Integer.parseInt(information[MANAGERID]),
					information[DOJ], Double.parseDouble(information[SALARY]),
					Double.parseDouble(information[COMMISSION]), Integer.parseInt(information[DEPTID])));
		}	
		return employeeList;
	}
}
