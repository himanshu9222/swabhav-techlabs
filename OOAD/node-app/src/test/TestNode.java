package test;

import components.Node;

public class TestNode {

	public static void main(String[] args) {
		Node<Integer> node1=new Node<Integer>(10);
		Node<Integer> node2=new Node<Integer>(20);
		Node<Integer> node3=new Node<Integer>(30);

		node1.setNext(node2);
		node2.setNext(node3);
		
		printDetails(node1);
	}
	
	public static <T> void  printDetails(Node<T> node){
		while(node!=null){
			System.out.println(node.getData());
			node= node.getNext();
		}
	}

}
