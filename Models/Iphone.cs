namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {
            Console.WriteLine("Criando um iPhone...");
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo: {nomeApp}...");
            Thread.Sleep(1000);
            Console.WriteLine($"{nomeApp} instalado com sucesso");
        }
    }
}