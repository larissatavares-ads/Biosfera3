namespace Biosfera3.Models
{
    public class Sensor
    {
        public Pesquisador pesquisador { get; set; }
        public string area { get; set; }
        public float temperatura { get; set; } // vai de 0 a 100 %
        public float umidade { get; set; } // vai de 0 a 100 %
        public ushort gasCarbonico { get; set; } // a qte max aceitavel é 1000 ppm
    }
}
