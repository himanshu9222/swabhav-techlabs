package com.techlabs;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.Statement;

public class TestStatement {

	public static void main(String[] args) {
		Connection comm;
		Statement stm = null;
		ResultSet resultSet = null;
		try {
			Class.forName("com.mysql.jdbc.Driver").newInstance();
			comm = DriverManager
					.getConnection("jdbc:mysql://localhost/techlabs?"
							+ "user=root&password=root");

			System.out.println(comm.getCatalog());
			// System.out.println(comm.);
			System.out.println(comm.getClass());

			stm = comm.createStatement();
			resultSet = stm.executeQuery("SELECT * FROM DEPT");

			if (stm.execute("SELECT * FROM DEPT")) {
				resultSet = stm.getResultSet();
			}
			
			ResultSetMetaData rsmd = resultSet.getMetaData();
			int columnsNumber = rsmd.getColumnCount();
			while (resultSet.next()) {
			    for (int i = 1; i <= columnsNumber; i++) {
			        if (i > 1) System.out.print(",  ");
			        String columnValue = resultSet.getString(i);
			        System.out.print("\n"+columnValue + " " + rsmd.getColumnName(i));
			    }
			}
			
		} catch (Exception ex) {
			ex.printStackTrace();
		} finally {

			if (resultSet != null) {
				try {
					resultSet.close();
				} catch (Exception ex) {
				}
				resultSet = null;
			}

			if (stm != null) {
				try {
					stm.close();
				} catch (Exception ex) {
				}
				stm = null;
			}
		}

	}

}
