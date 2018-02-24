package components;

import java.io.Serializable;

public class Student implements Serializable{
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private String id = "";
	private String name = "";
	private String email = "";
	
	
	public Student(String id,String name,String email){
		this.id=id;
		this.name=name;
		this.email=email;
		
	}

	public void setId(String id) {
		this.id = id;
	}

	public void setName(String name) {
		this.name = name;
	}

	public void setEmail(String email) {
		this.email = email;
	}

	public String getId() {
		return id;
	}

	public String getName() {
		return name;
	}

	public String getEmail() {
		return email;
	}
	
	public String toString(){
		return "Id = "+getId()+"\n Name ="+getName()+"\n Email ="+getEmail();
				
	}
}
