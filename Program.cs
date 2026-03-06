using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "1234", modelo: "Modelo1", imei: "0000", memoria: 128);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");


Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "4321", modelo: "Modelo2", imei: "1111", memoria: 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsApp");