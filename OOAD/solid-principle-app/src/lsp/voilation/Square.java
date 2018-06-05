package lsp.voilation;

public class Square extends Rectangle{

	public Square(int side) {
		super(side, side);
	}
	
	@Override
	public void setWidth(int w){
		width=height=w;
	}
	
	@Override
	public void setHeight(int h){
		this.width=this.height=h;
	}

}
