package studentdetail.test;

import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.border.TitledBorder;
import javax.swing.border.LineBorder;
import java.awt.Color;
import javax.swing.JLabel;
import java.awt.Font;
import javax.swing.JTextField;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;
import javax.swing.JOptionPane;
import javax.swing.JScrollPane;
import javax.swing.JButton;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import java.io.IOException;
import javax.swing.JTextArea;
import studentdetail.components.Student;
import studentdetail.components.StudentDataStore;

@SuppressWarnings("serial")
public class TestStudentJFrame extends JFrame {
	private JTextField nametextField;
	private JTextField emailtextField;
	private JTable table;
	private JScrollPane scrollPane;
	private JFrame frame;
	StudentDataStore store = new StudentDataStore();
	Student student = new Student();

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {

			@Override
			public void run() {
				try {
					TestStudentJFrame window = new TestStudentJFrame();
					window.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});

	}

	public TestStudentJFrame() {
		initialize();
	}

	public void initialize() {
		setBounds(0, 0, 1040, 644);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		getContentPane().setLayout(null);

		final JPanel panel = new JPanel();
		panel.setBorder(new TitledBorder(new LineBorder(new Color(64, 64, 64),
				4), "Student Recording System", TitledBorder.CENTER,
				TitledBorder.TOP, null, null));
		panel.setBounds(10, 11, 494, 270);
		getContentPane().add(panel);
		panel.setLayout(null);

		JLabel lblNewLabel = new JLabel("Name\r\n");
		lblNewLabel.setFont(new Font("Tahoma", Font.BOLD, 24));
		lblNewLabel.setBounds(25, 34, 135, 35);
		panel.add(lblNewLabel);

		nametextField = new JTextField();
		nametextField.setFont(new Font("Tahoma", Font.BOLD, 24));
		nametextField.setBounds(181, 34, 295, 35);
		panel.add(nametextField);
		nametextField.setColumns(10);

		JLabel lblEmail = new JLabel("Email");
		lblEmail.setFont(new Font("Tahoma", Font.BOLD, 24));
		lblEmail.setBounds(25, 96, 135, 35);
		panel.add(lblEmail);

		emailtextField = new JTextField();
		emailtextField.setFont(new Font("Tahoma", Font.BOLD, 24));
		emailtextField.setColumns(10);
		emailtextField.setBounds(181, 96, 295, 35);
		panel.add(emailtextField);

		JPanel panel_1 = new JPanel();
		panel_1.setBorder(new TitledBorder(new LineBorder(
				new Color(64, 64, 64), 4), "Student Transcript",
				TitledBorder.CENTER, TitledBorder.TOP, null, null));
		panel_1.setBounds(527, 11, 494, 270);
		getContentPane().add(panel_1);
		panel_1.setLayout(null);

		final JTextArea textArea = new JTextArea();
		textArea.setBounds(10, 22, 473, 237);
		panel_1.add(textArea);

		scrollPane = new JScrollPane();
		scrollPane.setBounds(10, 298, 1011, 224);
		getContentPane().add(scrollPane);

		table = new JTable();
		scrollPane.setViewportView(table);
		table.setModel(new DefaultTableModel(new Object[][] {}, new String[] {
				"Student_ID", "Name", "Gmail" }));

		JButton btnNewButton = new JButton("Add Result");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				DefaultTableModel model = (DefaultTableModel) table.getModel();

				student.setId();

				model.addRow(new Object[] { student.getId(),
						nametextField.getText(), emailtextField.getText(), });
				student.setName(nametextField.getText());
				student.setEmail(emailtextField.getText());
				store.addStudent(student);
			}
		});
		btnNewButton.setFont(new Font("Tahoma", Font.BOLD, 18));
		btnNewButton.setBounds(44, 545, 141, 41);
		getContentPane().add(btnNewButton);

		JButton btnTranscript = new JButton("Transcript");
		btnTranscript.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				textArea.append("\nStudent Detail Recording Systems\n"
						+ "=========================================\n"
						+ "Id    : \t\t" + student.getId() + "\nName:\t\t"
						+ nametextField.getText() + "\nEmail:\t\t"
						+ emailtextField.getText()
						+ "\n=========================================");
			}
		});
		btnTranscript.setFont(new Font("Tahoma", Font.BOLD, 18));
		btnTranscript.setBounds(377, 545, 141, 41);
		getContentPane().add(btnTranscript);

		//JButton btnDelete = new JButton("Delete");
		/*btnDelete.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				DefaultTableModel model = (DefaultTableModel) table.getModel();
				if (table.getSelectedRow() == -1) {
					if (table.getRowCount() == 0) {

						JOptionPane.showMessageDialog(null,
								"No data to delete", "Student Detail System",
								JOptionPane.OK_OPTION);
					} else {
						JOptionPane.showMessageDialog(null,
								"Select a row to delete",
								"Student Detail System", JOptionPane.OK_OPTION);
					}
				} else {
					model.removeRow(table.getSelectedRow());
				}
			}
		});*/
		//btnDelete.setFont(new Font("Tahoma", Font.BOLD, 18));
		//btnDelete.setBounds(213, 545, 141, 41);
		//getContentPane().add(btnDelete);

		JButton btnDisplay = new JButton("Reset");
		btnDisplay.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				JTextField temp = null;
				for (java.awt.Component c : panel.getComponents()) {
					if (c.getClass().toString()
							.contains("javax.swing.JTextField")) {
						temp = (JTextField) c;
						temp.setText(null);
					}
				}
			}
		});
		btnDisplay.setFont(new Font("Tahoma", Font.BOLD, 18));
		btnDisplay.setBounds(716, 545, 141, 41);
		getContentPane().add(btnDisplay);

		JButton button = new JButton("Exit");
		button.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				frame = new JFrame("Exit");
				if (JOptionPane.showConfirmDialog(frame,
						"Confirm if you want to exit",
						"Student Recording System", JOptionPane.YES_NO_OPTION) == JOptionPane.YES_NO_OPTION) {
					try {
						store.save(store.getAllStudentList());
					} catch (IOException e1) {
						e1.printStackTrace();
					}
					System.exit(0);
					
				}
			}
		});
		button.setFont(new Font("Tahoma", Font.BOLD, 18));
		button.setBounds(878, 545, 141, 41);
		getContentPane().add(button);

		JButton loadButton = new JButton("Load");
		loadButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					store.load();
				} catch (ClassNotFoundException | IOException e1) {
					e1.printStackTrace();
				}
				DefaultTableModel model = (DefaultTableModel) table.getModel();

				for (Student student : store.getAllStudentList()) {
					model.addRow(new Object[] { 
							student.getId(),
							student.getName(), 
							student.getEmail(), 
							});
				}
			}
		});
		loadButton.setFont(new Font("Tahoma", Font.BOLD, 18));
		loadButton.setBounds(545, 545, 141, 41);
		getContentPane().add(loadButton);
	}
}
