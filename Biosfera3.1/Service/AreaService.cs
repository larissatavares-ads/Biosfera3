using Biosfera3.Models;

namespace Biosfera3.Service;

public class AreaService : IAreaService
{
    private SensorService _sensor;

    public AreaService(SensorService sensor)
    {
        _sensor = sensor;
    }

    public async Task Jardim(Sensor sensor)
    {
        var area = sensor.area;
        try
        {
            _sensor.VerificaTemperatura(area);
            _sensor.VerificaUmidade(area);
            _sensor.VerificaGasCarbonico(area);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
        
    
    public void Dormitorio(Sensor sensor)
    {
        var area = sensor.area;

        try
        {
            _sensor.VerificaTemperatura(area);
            _sensor.VerificaUmidade(area);
            _sensor.VerificaGasCarbonico(area);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
    
    public void Laboratorio(Sensor sensor)
    {
        var area = sensor.area;

        try
        {
            _sensor.VerificaTemperatura(area);
            _sensor.VerificaUmidade(area);
            _sensor.VerificaGasCarbonico(area);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}