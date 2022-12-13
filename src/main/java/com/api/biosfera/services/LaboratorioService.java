package com.api.biosfera.services;

import com.api.biosfera.models.SensorModel;
import com.api.biosfera.repositories.LaboratorioRepository;

import java.sql.SQLException;

public class LaboratorioService {
    private LaboratorioRepository laboratorioRepository;

    public LaboratorioService(LaboratorioRepository laboratorioRepository) {
        this.laboratorioRepository = laboratorioRepository;
    }

    public void verificaParametros(SensorModel sensorModel) throws SQLException {
        sensorModel.setLocalSensor("laboratorio");
        sensorModel.setValorTemperatura(30);
        sensorModel.setValorUmidade(80);
        sensorModel.setValorGasCarbonico(500);

        if(sensorModel.getLocalSensor() == "laboratorio"){
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
        laboratorioRepository.insertWithQuery(sensorModel);
    }
}
