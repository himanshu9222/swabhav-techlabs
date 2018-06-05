package components;

import java.util.Iterator;
import java.util.LinkedList;

public class SwabhavQ<T> implements Iterable<T>{
	private LinkedList<T> list;
	
	public SwabhavQ(){
		list=new LinkedList<T>();
	}
	
	@SuppressWarnings("unchecked")
	public void enqueue(Object obj){
		if(list.isEmpty()){
			list.add((T) obj);
		}
		else
			list.addLast((T) obj);
	}
	
	public T  dequeue(){
		return list.removeFirst();	
	}
	
	public int size(){
		return list.size();
	}
	
	@Override
	public Iterator<T> iterator() {
		return list.listIterator();
	}
}
