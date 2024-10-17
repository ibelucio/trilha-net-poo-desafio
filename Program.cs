using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone s1 = new Nokia("123456", "N1", "654321", 64);
Console.WriteLine("SMARTPHONE NOKIA");
s1.Ligar();
s1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Smartphone s2 = new Iphone("123456", "Iphone 12", "654321", 128);
Console.WriteLine("SMARTPHONE IPHONE 12");
s2.ReceberLigacao();
s2.InstalarAplicativo("Telegram");
