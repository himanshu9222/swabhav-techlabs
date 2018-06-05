package withoutrefactored;

public class DataService {
	private DataService service;

	public DataService() {
		System.out.println("Service Created");
	}

	public static DataService getInstance() {
		return new DataService();
	}

	public void doService() {
		System.out.println("Service with this Id " + getInstance().hashCode()
				+ " is doing work");
	}

	public DataService getService() {
		return service;
	}

	public void setService(DataService service) {
		this.service = service;
	}
}
