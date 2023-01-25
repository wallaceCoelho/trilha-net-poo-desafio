using DesafioPOO.Models;

Nokia nokia1 = new Nokia("1234321", "Nokia A34", "1DEW2JE9KKE3", 128);

Console.WriteLine(nokia1.Numero);
nokia1.InstalarAplicativo("Facebook");
nokia1.ReceberLigacao();
nokia1.Ligar();

Iphone iphone13 = new Iphone("5677658", "Iphone 13", "7VPO5JE9L6G3", 64);

Console.WriteLine(nokia1.Numero);
iphone13.InstalarAplicativo("Whatsapp");
iphone13.ReceberLigacao();
iphone13.Ligar();