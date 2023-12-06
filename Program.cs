using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1234432", modelo: "modelos 1", imei: "09202392", memoria: 60);
nokia.Ligar();
nokia.InstalarAplicativo("Whastsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone iphone = new Nokia(numero: "12341111", modelo: "iphone 300", imei: "0182743", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");