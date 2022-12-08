using Biosfera3.Models;

namespace Biosfera3.Service;

public interface IAreaService
{
    Task<Area> Jardim(Area area);
    Task<Area> Dormitorio(Area area);
    Task<Area> Laboratorio(Area area);
}