using Biosfera3.Models;

namespace Biosfera3.Service
{
    public class SensorService
    {
        public Area _area { get; set; }
        public Sensor _sensor { get; set; }
        public Pesquisador _pesquisador { get; set; }

        public SensorService(Area area, Sensor sensor, Pesquisador pesquisador)
        {
            _area = area;
            _sensor = sensor;
            _pesquisador = pesquisador;
        }

        public void VerificaTemperaturaJardim(Sensor sensor)
        {
            var local = _area.Nome;
            var temperaturaAtual = _sensor.Temperatura;
            if (temperaturaAtual < 10)
            {
                Console.WriteLine($"Cuidado a temperatura do {local} está baixa!");
                Console.WriteLine($"Temperatura Atual:: {temperaturaAtual} ºC");
            }
            if (temperaturaAtual < 20)
            {
                Console.WriteLine($"Cuidado a temperatura do {local} está ficando baixa!");
                Console.WriteLine($"Temperatura Atual:: {temperaturaAtual} ºC");
            }
            if (temperaturaAtual > 30.0 && temperaturaAtual <= 40.0)
            {
                Console.WriteLine($"Cuidado a temperatura do {local} está alta!");
                Console.WriteLine($"Temperatura Atual:: {temperaturaAtual} ºC");
            }
            if (temperaturaAtual > 40.0 && temperaturaAtual <= 50.0)
            {
                Console.WriteLine($"Cuidado a temperatura do {local} está muito alta!");
                Console.WriteLine($"Temperatura Atual:: {temperaturaAtual} ºC");
            }
            if (temperaturaAtual > 50.0)
            {
                Console.WriteLine($"ALERTA!! ALERTA!! O {local} deve ser evacuado imediatamente. A temperatura está extremamente alta!");
                Console.WriteLine($"Temperatura Atual:: {temperaturaAtual} ºC");
            }
            else
            {
                Console.WriteLine($"A temperatura do {local} está adequada.");
                Console.WriteLine($"Temperatura Atual:: {temperaturaAtual} ºC");
            }
        }

        public void VerificaUmidadeJardim()
        {
            var local = _area.Nome;
            var umidadeAtual = _sensor.Umidade;
            if (umidadeAtual <= 10)
            {
                Console.WriteLine($"Cuidado! A umidade do {local} está muito baixa!");
                Console.WriteLine($"Umidade Atual:: {umidadeAtual} %");
            }
            if (umidadeAtual <= 20)
            {
                Console.WriteLine($"A umidade do {local} está baixa!");
                Console.WriteLine($"Umidade Atual:: {umidadeAtual} %");
            }
            if (umidadeAtual > 20 && umidadeAtual < 100)
            {
                Console.WriteLine($"A umidade do {local} está adequada.");
                Console.WriteLine($"Umidade Atual:: {umidadeAtual} %");
            }
        }

        public void VerificaGasCarbonicoJardim()
        {
            var local = _area.Nome;
            var gasCarbonicoAtual = _sensor.GasCarbonico;
            if (gasCarbonicoAtual >= 800 && gasCarbonicoAtual <= 999)
            {
                Console.WriteLine($"Cuidado! O gás carbonico do {local} está alto!");
                Console.WriteLine($"Gás Carbonico Atual:: {gasCarbonicoAtual} ppm");
            }
            if (gasCarbonicoAtual >= 1000)
            {
                Console.WriteLine($"ALERTA!! ALERTA!! O {local} deve ser evacuado imediatamente. O gás carbônico está em quantidades inaceitáveis para o ser humano!");
                Console.WriteLine($"Gás Carbonico Atual:: {gasCarbonicoAtual} ppm");
            }
            else
            {
                Console.WriteLine($"Gás carbonico do {local} está em quantidades adequadas.");
                Console.WriteLine($"Gás Carbonico Atual:: {gasCarbonicoAtual} ppm");
            }
        }
    }
}
