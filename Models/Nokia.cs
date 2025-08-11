using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {
            modelo = "Nokia";
            imei = "963214785";
            memoria = "64GB";
        }
        public sealed override void InstalarAplicativo(string nomeApp)
        {
            //Sobrescrevendo o método abstrato da classe Smartphone
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}