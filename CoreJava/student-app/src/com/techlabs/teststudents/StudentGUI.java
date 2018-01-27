package com.techlabs.teststudents;

import java.awt.BorderLayout;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.util.ArrayList;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.JTextField;

import com.techlabs.students.Student;

@SuppressWarnings("serial")
public class StudentGUI extends JFrame {
	JTextArea studentTextArea= new JTextArea();
	JLabel idLabel = new JLabel("ID: ");
	JTextField idTextField = new JTextField(10);
	JLabel NameLabel = new JLabel("Name: ");
	JTextField NameTextField = new JTextField(10);
	JLabel emailLabel = new JLabel("Email: ");
	JTextField emailTextField = new JTextField(10);

	JButton addButton = new JButton("Add");
	JButton deleteButton = new JButton("Delete");
	JButton displayAllButton = new JButton("Display All");
	JButton exitButton = new JButton("Exit");
	
	private ArrayList<Student> studentList=new ArrayList<Student>();

	public StudentGUI() {
		JPanel flow1Panel = new JPanel(new FlowLayout(FlowLayout.CENTER));
		JPanel flow2Panel = new JPanel(new FlowLayout(FlowLayout.CENTER));
		JPanel gridPanel = new JPanel(new GridLayout(2, 1));

		studentTextArea.setEditable(false);
		 
		flow1Panel.add(idLabel);
		flow1Panel.add(idTextField);
		flow1Panel.add(NameLabel);
		flow1Panel.add(NameTextField);
		flow1Panel.add(emailLabel);
		flow1Panel.add(emailTextField);

		flow2Panel.add(addButton);
		flow2Panel.add(deleteButton);
		flow2Panel.add(displayAllButton);
		flow2Panel.add(exitButton);

		gridPanel.add(flow1Panel);
		gridPanel.add(flow2Panel);

		add(studentTextArea,BorderLayout.CENTER);
		add(gridPanel, BorderLayout.SOUTH);
		

	}
	
	private void addStudent(){
		studentList.add(new Student(idTextField.getText(),NameTextField.getText(),emailTextField.getText()));
	}

	public static void main(String[] args) {
		StudentGUI app = new StudentGUI();
		app.setVisible(true);
		app.setSize(500, 500);
		app.setLocation(200, 100);
		app.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

	}

}
