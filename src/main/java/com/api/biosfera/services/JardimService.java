package com.api.biosfera.services;

import com.api.biosfera.models.SensorModel;
import com.api.biosfera.repositories.JardimRepository;

import java.sql.SQLException;

public class JardimService {
    private JardimRepository jardimRepository;

    public JardimService(JardimRepository jardimRepository) {
        this.jardimRepository = jardimRepository;
    }

    public void verificaParametros(SensorModel sensorModel) throws SQLException {
        sensorModel.setLocalSensor("jardim");
        sensorModel.setValorTemperatura(30);
        sensorModel.setValorUmidade(80);
        sensorModel.setValorGasCarbonico(500);

        if(sensorModel.getLocalSensor() == "jardim"){
            if(sensorModel.getValorTemperatura() <= 30)
                System.out.println("A temperatura está adequada");
            if(sensorModel.getValorTemperatura() > 30)
                System.out.println("Cuidado a temperatura está aumentado");
            if(sensorModel.getValorTemperatura() > 40)
                System.out.println("Cuidado a temperatura está alta");
            if(sensorModel.getValorTemperatura() > 45)
                System.out.println("Cuidado a temperatura está muito alta, evacuar o local");

            if(sensorModel.getValorUmidade() <= 30)
                System.out.println("A umidade esta baixa");
            if(sensorModel.getValorUmidade() > 30)
                System.out.println("Umidade está adequada");
            if(sensorModel.getValorUmidade() > 90)
                System.out.println("Cuidado a umidade está alta");

            if(sensorModel.getValorGasCarbonico() <= 400)
                System.out.println("O gas carbonico esta aceitavel");
            if(sensorModel.getValorGasCarbonico() > 400)
                System.out.println("O gas carbonico esta aumentando");
            if(sensorModel.getValorGasCarbonico() > 900)
                System.out.println("Gas carbonico em condiçoes elevadas, evacuar o local");
        }

        salvarParametros(sensorModel);
    }

    public void salvarParametros(SensorModel sensorModel) throws SQLException {
        jardimRepository.insertWithQuery(sensorModel);
    }
}
