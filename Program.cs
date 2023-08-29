using DesafioPOO.Models;


Iphone iphone1 = new Iphone("1111-2222", "iphone 14pro max", "1111", 364);
Nokia nokia1 = new Nokia("5555-6666", "Nokia Tijolao", "9999", 64);

nokia1.mostrarModelo();
nokia1.Ligar();
nokia1.InstalarAplicativo("facebook");

Console.WriteLine("Iphone");
iphone1.Ligar();
iphone1.InstalarAplicativo("Instagram");


