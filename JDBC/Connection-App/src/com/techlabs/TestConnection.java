package com.techlabs;

import java.sql.DriverManager;

import java.sql.Connection;

public class TestConnection {

	
	public static void main(String[] args) {
		Connection comm;
		try{
				Class.forName("com.mysql.jdbc.Driver").newInstance();
				comm = DriverManager.getConnection("jdbc:mysql://localhost/techlabs?" +
						"user=root&password=root");
				
				System.out.println(comm.getCatalog());
				//System.out.println(comm.);
			System.out.println(comm.getClass());
		}catch(Exception ex){
			ex.printStackTrace();
		}

	}
}
