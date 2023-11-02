using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;

//TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
 Smartphone nokia = new Nokia(numero: "986543", "modelo: 01", imei: "3333333", memoria:64);
 nokia.ReceberLigacao();
 nokia.Ligar();
 nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
 Smartphone iphone = new Iphone(numero: "98565", "modelo: 6", imei: "666666", memoria:128);
 iphone.Ligar();
 iphone.ReceberLigacao();
 iphone.InstalarAplicativo("Github");
 Console.WriteLine("\n");



