package com.techlabs.array;

public class Student {

			private String Fname;
			private String Lname;
			private String Email;
			
			@NeedRefactoryAnnotation
			public String getName(){
				return Fname;
			}
			
			public String setName(String name){
				return this.Fname =name;
			}
			
			public String getLName(){
				return Lname;
			}
			
			public String setLName(String lname){
				return this.Lname =lname;
			}
			public String getEmail(){
				return Email;
			}

			public String setEmail(String mail){
				return this.Email=mail;
			}
			
			
			public String BuildResume() {
				System.out.println();
				
				
				String resume="----------------------Resume----------------------------";
				
				resume+="   \nName\t\t"+getName();
				resume+="   \nLastName\t"+getLName();
				resume+="   \nEmail\t\t"+getEmail();
				return resume;
			}
}
