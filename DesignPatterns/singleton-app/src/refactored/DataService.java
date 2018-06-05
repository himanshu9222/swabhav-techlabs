package refactored;

public class DataService {
	private static DataService service;

	public DataService() {
		System.out.println("Service Created");
	}

	public static DataService getInstance() {
		if (service == null) {
			service = new DataService();
		}
		return service;
	}

	public void doService() {
		System.out.println("Service with this Id " + getInstance().hashCode()
				+ " is doing work");
	}
}
