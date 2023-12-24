namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    //✔
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"INICIANDO AS CONFIGURAÇOES DE SEU {this.GetType().Name.ToUpper()}");
            Console.WriteLine($"Numero de série: {numero}");
            Console.WriteLine($"Seu modelo é: {modelo}");
            Console.WriteLine($"Seu IMEI é: {imei}");
            Console.WriteLine($"Sua memoria maxima é: {memoria} Gb");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        //✔
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando SO: {nomeApp}");
            Console.WriteLine("------------------------------");

        }
    }
}