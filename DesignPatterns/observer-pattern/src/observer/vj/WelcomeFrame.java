package observer.vj;

import javax.swing.JButton;
import javax.swing.JFrame;

@SuppressWarnings("serial")
public class WelcomeFrame extends JFrame {
	JButton b = new JButton("Source");

	WelcomeFrame() {
		b.setBounds(100, 100, 100, 40);
		this.add(b);
		this.setSize(300, 400);
		this.setLayout(null);
		this.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		b.addActionListener(new Hello());
		b.addActionListener(new Goodbye());
	}

}
