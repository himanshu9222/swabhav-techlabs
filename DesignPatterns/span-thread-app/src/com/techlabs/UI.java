package com.techlabs;

import javax.swing.JFrame;
import javax.swing.JButton;

import java.awt.EventQueue;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;

import javax.swing.JTextArea;

@SuppressWarnings("serial")
public class UI extends JFrame{
	private SyncThread sync=new SyncThread();
	private AsyncThread async=new AsyncThread();
	Thread t1=new Thread(async);
	private JTextArea textArea;
	
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {

			@Override
			public void run() {
				try {
					UI window = new UI();
					window.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});

	}
	
	
	public UI() {
		initialize();
	}
	
	public void initialize(){
		setBounds(0, 0, 600, 400);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		getContentPane().setLayout(null);
		
		JButton btnNewButton = new JButton("Sync");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				sync.run();
			}
		});
		btnNewButton.setBounds(10, 11, 113, 32);
		getContentPane().add(btnNewButton);
		
		JButton btnAsync = new JButton("Async");
		btnAsync.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				t1.start();}
		});
		btnAsync.setBounds(148, 11, 113, 32);
		getContentPane().add(btnAsync);
		
		JButton btnHello = new JButton("Hello");
		btnHello.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				textArea.append("hello");
			}
		});
		btnHello.setBounds(295, 11, 113, 32);
		getContentPane().add(btnHello);
		
		textArea = new JTextArea();
		textArea.setBounds(64, 100, 262, 79);
		getContentPane().add(textArea);
	}
}
