package com.api.biosfera.connection;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class ConnectionFactory {
    public Connection getConnection(){
        try{
            return DriverManager.getConnection(
                    "jdbc:sqlserver://localhost:1433;" +
                            "databaseName=biosfera_DB;" +
                            "trustServerCertificate=true;" +
                            "user=sa;" +
                            "password=adminWEB123#"
            );
        } catch (SQLException e){
            throw new RuntimeException(e);
        }
    }
}
