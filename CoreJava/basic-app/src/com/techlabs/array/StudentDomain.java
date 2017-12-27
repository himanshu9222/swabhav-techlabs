package com.techlabs.array;

//http://www.Swabhavtechlabs.com?student=himanshu"
public class StudentDomain {
	public static void main(String urls[]) {

		if (urls.length == 0) {
			System.out.println("Enter the url");
		}

		for (String str : urls) {
			String domainName = str.substring(str.indexOf(".") + 1,str.lastIndexOf("."));
			
			if (domainName.equals("")) {
				System.out.println("Enter a proper domain");
			} else {
				System.out.println(domainName);
			}
			
			String argumentName = str.substring(str.indexOf("=") + 1);
			
			if (argumentName.equals("")) {
				System.out.println("Enter a proper domain");
			} else {
				System.out.println(argumentName);
			}
		}

	}
}
