package com.techlabs.array;

import java.lang.annotation.Annotation;
import java.lang.reflect.Constructor;
import java.lang.reflect.Method;

public class TestCount {

	// public static void main(String[] args) throws ClassNotFoundException {
	// Class<?> className = null;
	// className = Class.forName(args[0]);
	// Method[] methods = className.getMethods();
	// System.out.println("Number of methods in " + className + " = "
	// + methods.length);
	// for (int i = 0; i < methods.length; i++) {
	// System.out.println(methods[i]);
	// }
	// }
	public static void main(String args[]) {
		try {
			CountMethods count=new CountMethods();
			Class<?> className = Class.forName("com.techlabs.array.Student");
			//Class<?> className = Class.forName("java.util.Scanner");
			Method[] methods=className.getDeclaredMethods();
			@SuppressWarnings("rawtypes")
			Constructor[] constructors=className.getConstructors();
			//Annotation[] annotations=className.getDeclaredAnnotations();
			
			
			System.out.println("Number of Methods="+className+" "+methods.length);
			System.out.println("Number of Constructors="+className+" "+constructors.length);
			System.out.println("Number of Getter Method="+count.noOfGetMethod(className));
			System.out.println("Number of Setter Method="+count.noOfSetMethod(className));
			Class<? extends Annotation> NeedRefactoryAnnotation;
			System.out.println("Number of Annotation="+className+" "+count.countMethodsWithAnnotation(className, NeedRefactoryAnnotation), NeedRefactoryAnnotation);

		} catch (Exception ex) {
			ex.printStackTrace();
		}
	}
}
