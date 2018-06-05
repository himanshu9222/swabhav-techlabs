package assignment;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

@SuppressWarnings("serial")
public class WelcomeFrame extends JFrame {
	JButton b = new JButton("Hello");
	JFrame frame;

	WelcomeFrame() {
		getContentPane().setLayout(null);
		b.setBounds(31, 62, 100, 40);
		getContentPane().add(b);
		
		JButton exitButton = new JButton("Exit");
		exitButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				frame = new JFrame("Exit");
				if (JOptionPane.showConfirmDialog(frame,
						"Confirm if you want to exit",
						"Exit Application", JOptionPane.YES_NO_OPTION) == JOptionPane.YES_NO_OPTION) {
					System.exit(0);
					
				}
			}
		});
		exitButton.setBounds(197, 62, 100, 40);
		getContentPane().add(exitButton);
		this.setSize(398, 218);
		this.setVisible(true);
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		b.addActionListener(new Hello());
	}
}
