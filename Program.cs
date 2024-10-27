using DesafioPOO.Models;

var celular1 = new Nokia("1234567890", "N95", "DFSSFH233SD", 512);
var celular2 = new Iphone("9876543210", "iPhone16", "KFDFSSFFA32S", 8);

Console.WriteLine($"Teste celular: {celular1.Numero}");
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Whatsapp");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"Teste celular: {celular2.Numero}");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Candy Crush");

Console.ReadLine();