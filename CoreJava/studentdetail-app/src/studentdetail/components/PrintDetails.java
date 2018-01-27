package studentdetail.components;

import java.util.ArrayList;

public class PrintDetails {
	public void printDetails(ArrayList<Student> studentList) {
		for (Student detail : studentList) {
			System.out.println("Id : " + detail.getId() + "\tName : "
					+ detail.getName() + "\tEmail : " + detail.getEmail());
		}
	}
}
