namespace Biosfera3.Models
{
    public class Area
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Sensor Sensor { get; set; }
        public Pesquisador Pesquisador_1 { get; set; }
        public Pesquisador Pesquisador_2 { get; set; }
        public Pesquisador Pesquisador_3 { get; set; }
    }
}
