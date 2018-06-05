package lsp.voilation.test;

import lsp.refactor.Rectangle;

public class TestRectangle {
	public static void main(String args[]){
		Rectangle r=new Rectangle(100, 50);
		shouldNotChangeWidthIfHeightChanges(r);
	}
	
	public static void shouldNotChangeWidthIfHeightChanges(Rectangle r){
		int beforeWidth=r.getWidth();
		r.setHeight(20);
		int afterChangeWidth=r.getWidth();
		
		System.out.println("Before Width = "+beforeWidth);
		System.out.println("After Changing the Height = "+afterChangeWidth);
	}
}
