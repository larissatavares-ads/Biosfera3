namespace Biosfera3.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        public float Temperatura { get; set; } // vai de 0 a 100 %
        public float Umidade { get; set; } // vai de 0 a 100 %
        public ushort GasCarbonico { get; set; } // a qte max aceitavel é 1000 ppm
    }
}
