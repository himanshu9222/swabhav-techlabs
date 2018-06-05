package singletonpatternexample;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Client {

    public static void main(String[] args) {
        System.out.println("Enter your selection: MiniStmt OR DetailedStmt");
        BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
        String selection = null;

        try {
            selection = br.readLine();
        } catch (IOException e) {
            e.printStackTrace();
        }

        Factory factory = StatementFactory.getUniqueInstance();
        StatementType objStmtType = factory.createStatements(selection);
        System.out.println(objStmtType.print());
        //StatementFactory.getUniqueInstance();
    }
}
