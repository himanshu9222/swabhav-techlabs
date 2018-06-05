package components;

import components.enums.Result;

public class Game {
	private IBoard board;
	private Player[] players = new Player[2];
	private Player currentPlayer;
	private IResultAnalyser resultAnalyser;

	public Game(IBoard board, Player[] players, IResultAnalyser ra) {
		this.board = board;
		this.players = players;
		this.resultAnalyser = ra;
		this.currentPlayer = players[0];
	}

	
	public String getCurrentPlayer(){
		return this.currentPlayer.toString();
	}
	public Result play(int x, int y) {
		board.setCell(x, y, currentPlayer.getMark());
		Result r = resultAnalyser.analyse();
		if (r == Result.WIN) {
			return Result.WIN;
		} else if (r == Result.TIE) {
			return Result.TIE;
		} else {
			changePlayer();
			return Result.INPROGRESS;
		}
	}

	private void changePlayer() {
		if (currentPlayer.toString().equals(players[0].toString())) {
			currentPlayer = players[1];
		} else {
			currentPlayer = players[0];
		}
}
}
