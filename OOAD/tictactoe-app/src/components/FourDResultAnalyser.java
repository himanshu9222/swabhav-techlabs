package components;

import components.enums.Mark;
import components.enums.Result;

public class FourDResultAnalyser implements IResultAnalyser{
	private FourDBoard board;
	private Cell cell[][];
	
	public FourDResultAnalyser(IBoard board) {
		this.board = (FourDBoard) board;
		this.cell = board.getAllCell();
	}
	
	@Override
	public Result analyse() {
		if (Win()) {
			return Result.WIN;
		} else if (board.isFull()) {
			return Result.TIE;
		} else
			return Result.INPROGRESS;
	}
	
	private Boolean Win() {
		if (horizontal(0) || horizontal(1) || horizontal(2) || horizontal(3)) {
			return true;
		} else if (vertical(0) || vertical(1) || vertical(2) || vertical(3)){
			return true;
		} else if (diagonal()) {
			return true;
		} else
			return false;
	}

	private Boolean horizontal(int x) {
		if (cell[x][0].getMark() != Mark.EMPTY
				&& cell[x][0].getMark() == cell[x][1].getMark()
				&& cell[x][1].getMark() == cell[x][2].getMark()) {
			return true;
		} else
			return false;

	}

	private Boolean vertical(int y) {
		if (cell[0][y].getMark() != Mark.EMPTY
				&& cell[0][y].getMark() == cell[1][y].getMark()
				&& cell[1][y].getMark() == cell[2][y].getMark()) {
			return true;
		} else
			return false;

	}

	private Boolean diagonal() {
		if (cell[0][0].getMark() != Mark.EMPTY
				&& cell[0][0].getMark() == cell[1][1].getMark()
				&& cell[1][1].getMark() == cell[2][2].getMark()
				&&cell[2][2].getMark()== cell[3][3].getMark()) {
			return true;
		} else if (cell[3][3].getMark() != Mark.EMPTY
				&& cell[3][0].getMark() == cell[2][1].getMark()
				&& cell[2][1].getMark() == cell[1][2].getMark()
				&& cell[1][2].getMark() == cell[3][3].getMark()) {
			return true;
		} else
			return false;
	}


}
