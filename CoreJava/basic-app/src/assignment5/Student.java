package assignment5;

public class Student {
	private int rollNo;
	private String name;
	private int age;
	
	public Student(int r,String n,int a){
		this.rollNo=r;
		this.name=n;
		this.age=a;
	}
	
	public int getRollNO(){
		return rollNo;
	}
	
	public String getName(){
		return name;
	}
	
	public int getAge(){
		return age;
	}
	
	@Override
	public String toString(){
		return "ROllNO = "+getRollNO()+",Name = "+getName()+",Age = "+getAge()+"\n";
	}
	
	@Override
	public int hashCode(){
		return (this.rollNo+this.name.hashCode()+this.age);
	}
	
	@Override
	public boolean equals(Object obj){
		Student obj1=(Student) obj;
		return (this.name.equals(obj1.name));
		//if all the datatypes are string then return this.name.equals(obj1.name)&&this.rollNo.equals(obj1.rollNo)&&this.age.equals(obj1.age)
		
	}

}
