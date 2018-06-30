package com.techlabs;

import java.sql.Connection;
import java.sql.DriverManager;

public class TestConnection {

	public static void main(String[] args) {
		try{
		String url ="jdbc:sqlserver://HP-PC\\SQLEXPRESS;databaseName=AurionPro;integratedSecurity=true";
		Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		Connection conn = DriverManager.getConnection(url);
		}catch(Exception ex){
			ex.printStackTrace();
		}

	}

}
