namespace Biosfera3.Models
{
    public class Monitoramento
    {
        public string area { get; set; }
        public float temperatura { get; set; }
        public float umidade { get; set; }
        public ushort gasCarbonico { get; set; }
    }
}
