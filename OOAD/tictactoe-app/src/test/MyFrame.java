package test;

import javax.swing.JFrame;
import javax.swing.JTextField;
import javax.swing.JButton;

import components.Game;
import components.IBoard;
import components.IResultAnalyser;
import components.Player;
import components.ThreeDBoard;
import components.ThreeDResultAnalyser;
import components.enums.Mark;
import components.enums.Result;

import java.awt.EventQueue;
import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;
import javax.swing.JTextArea;

@SuppressWarnings("serial")
public class MyFrame extends JFrame {
	private JTextField player1;
	private JTextField player2;
	private JButton btnNewButton;
	private JButton button1,button2,button3,button4,button5,button6,button7,button8,button9;
	IBoard b = new ThreeDBoard();
	IResultAnalyser ra = new ThreeDResultAnalyser(b);
	private Game game;
	private Player playerA;
	private Player playerB;
	private JTextArea textArea;
	private JTextArea currentPlayerTextArea;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {

			@Override
			public void run() {
				try {
					MyFrame window = new MyFrame();
					window.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});

	}

	public MyFrame() {
		initialize();
		inputButton(false);
	}

	public void initialize() {
		setBounds(0, 0, 438, 499);
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		getContentPane().setLayout(null);

		player1 = new JTextField();
		player1.setBounds(22, 24, 109, 30);
		getContentPane().add(player1);
		player1.setColumns(10);

		player2 = new JTextField();
		player2.setBounds(167, 24, 93, 30);
		getContentPane().add(player2);
		player2.setColumns(10);

		btnNewButton = new JButton("Start");
		btnNewButton.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				playerA=new Player(player1.getText(), Mark.X);
				playerB=new Player(player2.getText(), Mark.O);
				Player p[] = { playerA, playerB };
				game = new Game(b, p, ra);
				startButton(false);
				inputButton(true);
			}
		});
		btnNewButton.setBounds(301, 28, 89, 23);
		getContentPane().add(btnNewButton);

		button1 = new JButton("1");
		button1.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button1,1);
			}
		});
		button1.setBounds(41, 125, 45, 37);
		getContentPane().add(button1);

		button2 = new JButton("2");
		button2.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button2,2);
			}
		});
		button2.setBounds(110, 125, 45, 37);
		getContentPane().add(button2);

		button3 = new JButton("3");
		button3.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button3,3);
			}
		});
		button3.setBounds(180, 125, 45, 37);
		getContentPane().add(button3);

		button4 = new JButton("4");
		button4.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button4,4);
			}
		});
		button4.setBounds(41, 183, 45, 37);
		getContentPane().add(button4);

		button5 = new JButton("5");
		button5.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button5,5);
			}
		});
		button5.setBounds(110, 183, 45, 37);
		getContentPane().add(button5);

		button6 = new JButton("6");
		button6.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button6,6);
			}
		});
		button6.setBounds(180, 183, 45, 37);
		getContentPane().add(button6);

		button7 = new JButton("7");
		button7.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button7,7);
			}
		});
		button7.setBounds(41, 248, 45, 37);
		getContentPane().add(button7);

		button8 = new JButton("8");
		button8.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button8,8);
			}
		});
		button8.setBounds(110, 248, 45, 37);
		getContentPane().add(button8);

		button9 = new JButton("9");
		button9.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				takeInput(button9,9);
			}
		});
		button9.setBounds(180, 248, 45, 37);
		getContentPane().add(button9);
		
		textArea = new JTextArea();
		textArea.setBounds(53, 312, 299, 104);
		getContentPane().add(textArea);
		
		currentPlayerTextArea = new JTextArea();
		currentPlayerTextArea.setBounds(41, 65, 183, 42);
		getContentPane().add(currentPlayerTextArea);
		
		
	}
	
	public void takeInput(JButton button,int input){
		Result result=game.play(getRow(input), getColumn(input));
		currentPlayerTextArea.setText(currentPlayerText());
		button.setText(b.getCell(getRow(input), getColumn(input)).toString());
		if(result==Result.WIN){
			String str=game.getCurrentPlayer()+"  "+ result+"!!!";
			textArea.append(str);
			inputButton(false);
		}
		if(result==Result.TIE){
			textArea.append("Its a "+result);
		}
		button.setEnabled(false);
	}
	
	public String currentPlayerText(){
		return game.getCurrentPlayer()+" turn ";
	}
	
	public int getRow(int no) {
		return (no - 1) / 3;
	}

	public int getColumn(int no) {
		return (no - 1) % 3;
	}
	
	public void startButton(boolean type){
		btnNewButton.setEnabled(type);
	}
	
	public void inputButton(boolean type){
		button1.setEnabled(type);
		button2.setEnabled(type);
		button3.setEnabled(type);
		button4.setEnabled(type);
		button5.setEnabled(type);
		button6.setEnabled(type);
		button7.setEnabled(type);
		button8.setEnabled(type);
		button9.setEnabled(type);
	}
}
