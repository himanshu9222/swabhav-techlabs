package lsp.voilation.test;

import lsp.voilation.Rectangle;
import lsp.voilation.Square;

public class TestLSPVoilation {
	public static void main(String args[]){
		Rectangle r=new Rectangle(100, 50);
		shouldNotChangeWidthIfHeightChanges(r);
		
		Square s=new Square(100);
		shouldNotChangeWidthIfHeightChanges(s);
		
	}
	
	public static void shouldNotChangeWidthIfHeightChanges(Rectangle r){
		int beforeWidth=r.getWidth();
		r.setHeight(20);
		int afterChangeWidth=r.getWidth();
		
		System.out.println("Before Width = "+beforeWidth);
		System.out.println("After Changing the Height = "+afterChangeWidth);
	}
}
