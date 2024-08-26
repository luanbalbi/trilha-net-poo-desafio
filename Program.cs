using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "21999999999", modelo: "Modelo A", imei: "7894561320", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "11888888888", modelo: "Modelo B", imei: "1023456789", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");