package studentprofessor.components;

import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.UUID;

public abstract class Person {
	private UUID id;
	private String name;
	private String address;
	private String pattern = "yyyy/MM/dd";
	private Date dob;
	
	
	public Person(String name,String address,Date dob){
		setId();
		this.name=name;
		this.address=address;
		this.dob=dob;
	}
	
	public String setDate(){
		SimpleDateFormat simpledateformat=new SimpleDateFormat(pattern);
		return simpledateformat.format(this.dob);
	}

	public String getAddress() {
		return address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public UUID getId() {
		return id;
	}

	public void setId() {
		this.id = UUID.randomUUID();
	}


	public void setDob(Date dob) {
		this.dob = dob;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
}
