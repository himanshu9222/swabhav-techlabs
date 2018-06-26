using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static string[] displayResult = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static void Main(string[] args)
        {
        IBoard b = new ThreeDBoard();
		ResultAnalyser ra = new ResultAnalyser(b);
		Console.WriteLine("Enter name of 1st player");
		string player1 = Console.ReadLine();
		Console.WriteLine("Enter name of 2st player");
		String player2 = Console.ReadLine();
 
		Player p1 = new Player(player1, Mark.X);
		Player p2 = new Player(player2, Mark.O);
		Player[] p = { p1, p2 };

		Game game = new Game(b, p, ra);

		Console.WriteLine("Enter the Cell no from 1 to 9");

        //for (int i = 0; i < 9; i++) {
        //    int a = int.Parse(Console.ReadLine());
        //    Result result=game.play(a-1);
        //    displayResult[a-1]=b.getCell(a-1).ToString();
        //    display();
        //    if(result==Result.WIN){
        //        Console.WriteLine(game.getCurrentPlayer()+"  "+ result);
        //        break;
        //    }
        //    Console.WriteLine(result);
        //}
        Console.ReadKey();
	}
	
	public static void display(){
		int counter=0;
		for(int i=0; i<9; i++){		
				Console.WriteLine(displayResult[counter]+"\t");
				counter+=1;
                if (counter == 2 || counter == 5 || counter == 8) { Console.WriteLine(); }
		}	
	}
    
    }
}
