using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia");
Nokia c1= new Nokia("123456", "Modelo teste", "ImeiTeste",64);
c1.Ligar();
// c1.Modelo();--> privado então nao tem como exibir
// c1.Imei(); --> privado então nao tem como exibir
// c1.Memoria();--> privado então nao tem como exibir
c1.ReceberLigacao();
c1.InstalarAplicativo("App1");

Console.WriteLine("\nSmartphone Iphone");
Nokia c2= new Nokia("654321", "Modelo teste2", "ImeiTeste2",128);
c2.Ligar();
// c1.Modelo();--> privado então nao tem como exibir
// c1.Imei(); --> privado então nao tem como exibir
// c1.Memoria();--> privado então nao tem como exibir
c2.ReceberLigacao();
c2.InstalarAplicativo("App2");