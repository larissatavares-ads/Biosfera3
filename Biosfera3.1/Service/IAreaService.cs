using Biosfera3.Models;

namespace Biosfera3.Service;

public interface IAreaService
{
    void Jardim(Sensor sensor);
    void Dormitorio(Sensor sensor);
    void Laboratorio(Sensor sensor);
}