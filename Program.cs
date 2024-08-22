using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Testando com a classe Nokia
Smartphone iphone = new Iphone(numero: "12121212", modelo: "Nok_001", imei: "00000001", memoria: 128);
iphone.Ligar();
iphone.MensagemSistema();
iphone.InstalarAplicativo("Uber");
