package assignment;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Hello implements ActionListener{
	public Hello(){
		
	}

	@Override
	public void actionPerformed(ActionEvent arg0) {
		System.out.println("Hello Everyone");
		
	}
}
