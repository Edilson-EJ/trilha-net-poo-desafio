using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111111", memoria: 64 );

nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "5987",modelo: "Modelo 2", imei: "34343434", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("");