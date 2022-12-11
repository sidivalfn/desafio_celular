using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("12345678", "Nokia", "zzzz1234", 50);
Iphone iphone = new Iphone("012345678", "Iphone", "4321wwww", 60);

nokia.InstalarAplicativo("Facebook");
nokia.Ligar();
nokia.ReceberLigacao();

iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();