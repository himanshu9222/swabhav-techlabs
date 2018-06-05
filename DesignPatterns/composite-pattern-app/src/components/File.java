package components;

public class File implements IDriveItem {
	private String name;
	private int size;
	private String extension;

	public File(String name, int size, String extension) {
		this.name = name;
		this.size = size;
		this.extension = extension;
	}

	@Override
	public void showDetails(int level) {
		while(level>0){
			System.out.print("\t");
			level--;
		}
		System.out.println("File name: " + name + " Size=" + size
				+ " Extension is " + extension);
	}
}
