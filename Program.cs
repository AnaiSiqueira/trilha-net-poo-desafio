using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456789", "Nokia", "963214785", "64GB");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone("987654321", "iPhone", "123456789", "128GB");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram"); 
// TODO: Realizar os testes com as classes Nokia e Iphone