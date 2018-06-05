package studentprofessor.components;

import java.text.SimpleDateFormat;
import java.util.Calendar;
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
	
	public String getDate(){
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
	
	public static int getAge(Calendar dob) throws Exception {
		
		Calendar today = Calendar.getInstance();
		int curYear = today.get(Calendar.YEAR);
		int dobYear = dob.get(Calendar.YEAR);
		int age = curYear - dobYear;
		
		// if dob is month or day is behind today's month or day
		// reduce age by 1
		int curMonth = today.get(Calendar.MONTH);
		int dobMonth = dob.get(Calendar.MONTH);
		
		if (dobMonth > curMonth) { // this year can't be counted!
			age--;
		} else if (dobMonth == curMonth) { // same month? check for day
				int curDay = today.get(Calendar.DAY_OF_MONTH);
				int dobDay = dob.get(Calendar.DAY_OF_MONTH);
				if (dobDay > curDay) { // this year can't be counted!
					age--;
				}
		}
		return age;	
	}
		
}


















//age from quickprogrammingtips
