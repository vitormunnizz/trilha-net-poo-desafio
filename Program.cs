using DesafioPOO.Models;
using System;


Nokia nokia = new Nokia(
    numero: "123456789",
    modelo: "Nokia C20 Plus",
    imei: "123",
    memoria: 64
);

nokia.Ligar();
nokia.InstalarAplicativo("Dio");

Console.WriteLine("\n");

Iphone iphone = new Iphone(
    numero: "987654321",
    modelo: "iPhone 12",
    imei: "321",
    memoria: 64
);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Dio");