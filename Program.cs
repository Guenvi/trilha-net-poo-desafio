using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Teste smartphone Nokia

Smartphone nokia = new Nokia(numero: "981100", modelo: "Tijolão", imei: "443334513", memoria: 1);
nokia.Ligar();
nokia.InstalarAplicativo("Agenda");

// Teste smartphone Iphone

Smartphone iphone = new Iphone(numero: "984422", modelo: "iPhone 15", imei: "89777632", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");