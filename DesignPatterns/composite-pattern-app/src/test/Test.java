package test;

import components.File;
import components.Folder;

public class Test {
	public static void main(String args[]){
		Folder root=new Folder("Root Folder");
		root.addItem(new File("app.exe", 4000, ".exe"));
		
		Folder hindiMovies=new Folder("HindiMovie");
		hindiMovies.addItem(new File("Movie.avi", 500, ".avi"));
		hindiMovies.addItem(new File("text.txt", 5, ".txt"));
		hindiMovies.addItem(new File("image.jpeg", 15, ".jpeg"));
		root.addItem(hindiMovies);
		
		root.showDetails(0);
	}
}
