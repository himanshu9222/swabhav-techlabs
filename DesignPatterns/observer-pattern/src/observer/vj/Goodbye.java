package observer.vj;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Goodbye implements ActionListener{
	public Goodbye(){
		
	}

	@Override
	public void actionPerformed(ActionEvent arg0) {
		System.out.println("Goodbye Everyone");
		
	}
}
