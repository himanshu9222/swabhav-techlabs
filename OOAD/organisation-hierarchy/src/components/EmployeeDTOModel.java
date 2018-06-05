package components;

public class EmployeeDTOModel {
	private String id;
	private String name;
	private String role;
	private String managerId;
	private String doteOfJoining;
	private String salary;
	private String commission;
	private String deptId;
	
	public EmployeeDTOModel(String id, String name, String role, String managerId,
			String dateOfJoining, String salary, String commission, String deptid) {
		this.setId(id);
		this.setName(name);
		this.role = role;
		this.managerId = managerId;
		this.doteOfJoining = dateOfJoining;
		this.salary = salary;
		this.setCommission(commission);
		this.deptId = deptid;
	}

	public String getId() {
		return id;
	}

	public void setId(String id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getCommission() {
		return commission;
	}

	public void setCommission(String commission) {
		this.commission = commission;
	}

	public String getRole() {
		return role;
	}

	public void setRole(String role) {
		this.role = role;
	}

	public String getManagerId() {
		return managerId;
	}

	public void setManagerId(String managerId) {
		this.managerId = managerId;
	}

	public String getDoteOfJoining() {
		return doteOfJoining;
	}

	public void setDoteOfJoining(String doteOfJoining) {
		this.doteOfJoining = doteOfJoining;
	}

	public String getSalary() {
		return salary;
	}

	public void setSalary(String salary) {
		this.salary = salary;
	}

	public String getDeptId() {
		return deptId;
	}

	public void setDeptId(String deptId) {
		this.deptId = deptId;
	}
	
}
