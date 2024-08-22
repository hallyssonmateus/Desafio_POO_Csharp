using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Testando com a classe Nokia
Smartphone nokia = new Nokia(numero: "45454545", modelo: "Nok_001", imei: "00000001", memoria: 128);
nokia.Ligar();
nokia.MensagemSistema();
nokia.InstalarAplicativo("Whattsapp");
