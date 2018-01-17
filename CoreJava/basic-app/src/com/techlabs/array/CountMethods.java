package com.techlabs.array;

import java.lang.annotation.Annotation;
import java.lang.reflect.Method;

public class CountMethods {
	
		public int noOfGetMethod(Class<?> c){
			int getMethod=0;
			for(java.lang.reflect.Method m:c.getMethods()){
				if(m.getName().startsWith("get")){
					getMethod++;
				}
			}
			return getMethod;
		}
		
		public int noOfSetMethod(Class<?> c){
			int setMethod=0;
			for(java.lang.reflect.Method m:c.getMethods()){
				if(m.getName().startsWith("set")){
					setMethod++;
				}
			}
			return setMethod;
		}
		
		public static int countMethodsWithAnnotation(Class<?> klass,
                Class<? extends Annotation> annotation) {
				int count = 0;
					for (Method m : klass.getMethods()) {
							if (m.isAnnotationPresent(annotation)) {
									count++;
							}
					}
					return count;
		}
}