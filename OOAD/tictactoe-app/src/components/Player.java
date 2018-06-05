package components;

import components.enums.Mark;

public class Player {
	private Mark mark;
	private String name;

	public Player(String name,Mark mark) {
		this.setMark(mark);
		this.name=name;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Mark getMark() {
		return mark;
	}

	public void setMark(Mark mark) {
		this.mark = mark;
	}
	
	@Override
	public String toString(){
		return this.name;
	}
}
