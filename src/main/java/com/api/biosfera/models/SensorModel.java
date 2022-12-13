package com.api.biosfera.models;

public class SensorModel {
    private String localSensor;
    private Integer valorTemperatura;
    private Integer valorUmidade;
    private Integer valorGasCarbonico;

    public String getLocalSensor() {
        return localSensor;
    }

    public void setLocalSensor(String localSensor) {
        this.localSensor = localSensor;
    }

    public Integer getValorTemperatura() {
        return valorTemperatura;
    }

    public void setValorTemperatura(Integer valorTemperatura) {
        this.valorTemperatura = valorTemperatura;
    }

    public Integer getValorUmidade() {
        return valorUmidade;
    }

    public void setValorUmidade(Integer valorUmidade) {
        this.valorUmidade = valorUmidade;
    }

    public Integer getValorGasCarbonico() {
        return valorGasCarbonico;
    }

    public void setValorGasCarbonico(Integer valorGasCarbonico) {
        this.valorGasCarbonico = valorGasCarbonico;
    }

    @Override
    public String toString() {
        return "SensorModel{" +
                ", localSensor='" + localSensor + '\'' +
                ", valorTemperatura=" + valorTemperatura +
                ", valorUmidade=" + valorUmidade +
                ", valorGasCarbonico=" + valorGasCarbonico +
                '}';
    }
}
