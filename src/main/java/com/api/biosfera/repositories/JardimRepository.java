package com.api.biosfera.repositories;

import com.api.biosfera.connection.ConnectionFactory;
import com.api.biosfera.models.SensorModel;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class JardimRepository {
    public void insertWithQuery(SensorModel sensor) throws SQLException {
        Connection con = new ConnectionFactory().getConnection();
        PreparedStatement smt = con.prepareStatement(
                "INSERT INTO dormitorio (dataAtual, localizacao, temperatura, umidade, gascarbonico) " +
                        "VALUES (GETDATE(),?,?,?,?)");

        smt.setString(1, sensor.getLocalSensor());
        smt.setLong  (2, sensor.getValorTemperatura());
        smt.setLong  (3, sensor.getValorUmidade());
        smt.setLong  (4, sensor.getValorGasCarbonico());
    }

}
