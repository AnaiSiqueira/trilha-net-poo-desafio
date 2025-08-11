namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
            modelo = "iPhone";
            imei = "123456789";
            memoria = "128GB";
        }

        public sealed override void InstalarAplicativo(string nomeApp)
        {
            //Sobrescrevendo o método abstrato da classe Smartphone
            Console.WriteLine($"Instalando o aplicativo no {nomeApp} no iPhone.");
        }
    }
}