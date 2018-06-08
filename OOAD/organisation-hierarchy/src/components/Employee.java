package components;

import java.util.ArrayList;

public class Employee {
	private int id;
	private String name;
	private String role;
	private int managerId;
	private String doteOfJoining;
	private double salary;
	private double commission;
	private int deptId;
	private ArrayList<Employee> reportees=new ArrayList<Employee>() ;

	public Employee(int id, String name, String role, int managerId,
			String dateOfJoining, double salary, double commission, int deptid) {
		this.id = id;
		this.name = name;
		this.role = role;
		this.managerId = managerId;
		this.doteOfJoining = dateOfJoining;
		this.salary = salary;
		this.commission = commission;
		this.deptId = deptid;
	}
	
	public void addReportee(Employee emp){
		this .reportees.add(emp);
	}
	
	public ArrayList<Employee> getReportees(){
		return reportees;
	}
	
	public void getDetails(int count){
		makeIndent(count);
		System.out.println(this.getRole()+"->"+this.getName());
		for(Employee e: this.getReportees()){
			e.getDetails(count+1);
		}
	}
	
	public void makeIndent(int count){
		for(int i=0;i<count;i++){
			System.out.print("    ");
		}
	}
	
	public void check(){
		if(reportees.isEmpty()){
			System.out.println("empty");
		}
	}
	public String toString(){
		return "ID= "+id+" Name= "+name+" Role= "+role+" ManagerId= "+managerId+" DOJ= "+doteOfJoining+" Salary= "+salary+" Commission= "+commission+" DeptId= "+deptId;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getRole() {
		return role;
	}

	public void setRole(String role) {
		this.role = role;
	}

	public int getManagerId() {
		return managerId;
	}

	public void setManagerId(int managerId) {
		this.managerId = managerId;
	}

	public String getDoteOfJoining() {
		return doteOfJoining;
	}

	public void setDoteOfJoining(String doteOfJoining) {
		this.doteOfJoining = doteOfJoining;
	}

	public double getSalary() {
		return salary;
	}

	public void setSalary(double salary) {
		this.salary = salary;
	}

	public double getCommission() {
		return commission;
	}

	public void setCommission(double commission) {
		this.commission = commission;
	}

	public int getDeptId() {
		return deptId;
	}

	public void setDeptId(int deptId) {
		this.deptId = deptId;
	}
	
	@Override
	public boolean equals(Object obj){
		Employee emp=(Employee) obj;
		return this.getId()==emp.getId();
	}
	
	@Override
	public int hashCode(){
		return this.getId();
	}

}
