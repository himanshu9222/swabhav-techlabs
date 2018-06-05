package components;

import java.util.ArrayList;

public class Folder implements IDriveItem{
	private String name;
	ArrayList<IDriveItem> driveItemList=new ArrayList<IDriveItem>();
	
	public Folder(String name){
		this.name=name;
	}
	
	public void addItem(IDriveItem obj){
		driveItemList.add(obj);
	}

	@Override
	public void showDetails(int level) {
		int levelcopy=level;
		while(level>0){
			System.out.print("\t");
			level--;
		}
			System.out.println("Folder name: " +name);
			for(IDriveItem item: driveItemList){
				item.showDetails(levelcopy+1);
			}
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	
}
