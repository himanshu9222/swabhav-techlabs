package com.techlabs;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.ResultSetMetaData;
import java.sql.Statement;

public class TestSQLInjection {

	public static void main(String[] args) {
		InputStreamReader r = new InputStreamReader(System.in);
		BufferedReader br = new BufferedReader(r);
		Connection comm;
		Statement stm = null;
		ResultSet resultSet = null;
		try {
			Class.forName("com.mysql.jdbc.Driver").newInstance();
			//:4040 is port for connection , techlabs is database
			comm = DriverManager
					.getConnection("jdbc:mysql://localhost:4040/techlabs?allowMultiQueries=true&"
							+ "user=root&password=root");

			stm = comm.createStatement();
			System.out.println("Enter id You Want to View");
			String id = br.readLine();
			resultSet = stm.executeQuery("SELECT * FROM DEPT WHERE DEPTNO ="
					+ id);

			if (stm.execute("SELECT * FROM DEPT WHERE DEPTNO =" + id)) {
				resultSet = stm.getResultSet();
			}
			/*
			 * ResultSetMetaData rsmd = resultSet.getMetaData();
			 * 
			 * int columnsNumber = rsmd.getColumnCount();
			 * 
			 * while (resultSet.next()) { for (int i = 1; i <= columnsNumber;
			 * i++) { if (i > 1) System.out.print(",  "); String columnValue =
			 * resultSet.getString(i); System.out.print("\n"+columnValue + " " +
			 * rsmd.getColumnName(i)); } }
			 */
			while (resultSet.next()) {
				System.out.println(resultSet.getString("DEPTNO") + " "
						+ resultSet.getString("DNAME") + " "
						+ resultSet.getString("LOC"));
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
