package polymorphismcomponets;

public class Man implements IMannerable{

	@Override
	public void wish() {
		System.out.println("Man wish.");	
	}

	@Override
	public void depart() {
		System.out.println("Man depart.");	
	}

}
