package components;

import components.enums.Mark;
import components.enums.Result;

public class ThreeDResultAnalyser implements IResultAnalyser{
	private ThreeDBoard board;
	private Cell cell[][];

	public ThreeDResultAnalyser(IBoard board) {
		this.board = (ThreeDBoard) board;
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
		if (horizontal(0) || horizontal(1) || horizontal(2)) {
			return true;
		} else if (vertical(0) || vertical(1) || vertical(2)) {
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
				&& cell[1][1].getMark() == cell[2][2].getMark()) {
			return true;
		} else if (cell[1][1].getMark() != Mark.EMPTY
				&& cell[2][0].getMark() == cell[1][1].getMark()
				&& cell[1][1].getMark() == cell[0][2].getMark()) {
			return true;
		} else
			return false;
	}
}
