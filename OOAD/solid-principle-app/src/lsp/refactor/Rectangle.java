package lsp.refactor;

public class Rectangle implements Polygon{
	private int height;
	private int width;
	
	public Rectangle(int height,int width){
		this.height=height;
		this.width=width;
	}
	
	public int getWidth() {
		return width;
	}
	public void setWeight(int width) {
		this.width = width;
	}
	public int getHeight() {
		return height;
	}
	public void setHeight(int height) {
		this.height = height;
	}

	@Override
	public double calculateArea() {
		int area=this.height*this.width;
		return area;
	}
}
