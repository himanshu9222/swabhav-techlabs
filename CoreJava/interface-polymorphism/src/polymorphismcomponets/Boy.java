package polymorphismcomponets;

public class Boy implements IMannerable, IEmotionable {

	@Override
	public void cry() {
		System.out.println("Boy Cry.");
	}

	@Override
	public void laugh() {
		System.out.println("Boy laugh.");
	}

	@Override
	public void wish() {
		System.out.println("Boy wish.");
	}

	@Override
	public void depart() {
		System.out.println("Boy depart.");
	}

}
