package studentprofessor.components;

import java.util.Date;

public class Student extends Person{
	EBranch branch;
	
	public EBranch getBranch() {
		return branch;
	}

	public void setBranch(EBranch branch) {
		this.branch = branch;
	}

	public Student(String name,String address,Date date,EBranch branch){
		super(name,address,date);
		this.branch=branch;
	}
	
	
}
