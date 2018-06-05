package test;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import components.IBoard;
import components.IResultAnalyser;
import components.ThreeDBoard;
import components.Game;
import components.Player;
import components.ThreeDResultAnalyser;
import components.enums.Mark;
import components.enums.Result;

public class Test {
	
	static String displayResult[]={"1","2","3","4","5","6","7","8","9"};
	public static void main(String args[]) throws IOException {
		IBoard b = new ThreeDBoard();
		IResultAnalyser ra = new ThreeDResultAnalyser(b);
		BufferedReader input = new BufferedReader(new InputStreamReader(
				System.in));
		System.out.println("Enter name of 1st player");
		String player1 = input.readLine();
		System.out.println("Enter name of 2st player");
		String player2 = input.readLine();
 
		Player p1 = new Player(player1, Mark.X);
		Player p2 = new Player(player2, Mark.O);
		Player p[] = { p1, p2 };

		Game game = new Game(b, p, ra);

		System.out.println("Enter the Cell no from 1 to 9");

		for (int i = 0; i < 9; i++) {
			int a = Integer.parseInt(input.readLine());
			Result result=game.play(getRow(a), getColumn(a));
			displayResult[a-1]=b.getCell(getRow(a), getColumn(a)).toString();
			display();
			if(result==Result.WIN){
				System.out.println(game.getCurrentPlayer()+"  "+ result);
				break;
			}
			System.out.println(result);
		}
	}

	public static int getRow(int no) {
		return (no - 1) / 3;
	}

	public static int getColumn(int no) {
		return (no - 1) % 3;
	}
	
	public static void display(){
		int counter=0;
		for(int i=0; i<3; i++){		
			for(int j=0; j<3; j++){
				System.out.print(displayResult[counter]+"\t");
				counter+=1;
			}
			System.out.println();
		}	
	}
}
