using Biosfera3.Models;

namespace Biosfera3.Service;

public class AreaService : IAreaService
{
    private SensorService _sensor;

    public AreaService(SensorService sensor)
    {
        _sensor = sensor;
    }

    public Task<Area> Jardim(Area area)
    {
        area.Nome = "Jardim";
        area.Sensor = new Sensor();
        area.Pesquisador_1 = new Pesquisador();
        area.Pesquisador_2 = new Pesquisador();
        area.Pesquisador_3 = new Pesquisador();

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
        
        return 
    }
        
    
    public Task<Area> Dormitorio(Area area)
    {
        area.Nome = "Dormitorio";
        area.Sensor = new Sensor();
        area.Pesquisador_1 = new Pesquisador();
        area.Pesquisador_2 = new Pesquisador();
        area.Pesquisador_3 = new Pesquisador();

        _sensor.VerificaTemperatura(area);
        _sensor.VerificaUmidade(area);
        _sensor.VerificaGasCarbonico(area);
    }
    
    public Task<Area> Laboratorio(Area area)
    {
        area.Nome = "Dormitorio";
        area.Sensor = new Sensor();
        area.Pesquisador_1 = new Pesquisador();
        area.Pesquisador_2 = new Pesquisador();
        area.Pesquisador_3 = new Pesquisador();

        _sensor.VerificaTemperatura(area);
        _sensor.VerificaUmidade(area);
        _sensor.VerificaGasCarbonico(area);
    }
}