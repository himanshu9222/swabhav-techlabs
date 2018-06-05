package test;

import static org.junit.Assert.*;
import java.io.IOException;
import java.util.HashSet;

import loader.FileLoader;
import loader.ILoadable;

import org.junit.Test;

import parser.CSVParser;
import components.Employee;

public class CSVParserTest {

	@Test
	public void testParse() throws IOException {
		ILoadable load = new FileLoader();
		CSVParser parse=new CSVParser(load);
		HashSet<Employee> parseList=new HashSet<Employee>();
		parseList=parse.parse();
		
		HashSet<Employee> employeeList=new HashSet<Employee>();
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
		
		assertEquals(employeeList.size(),parseList.size());
	}
}
