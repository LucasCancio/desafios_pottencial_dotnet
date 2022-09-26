using DesafioPOO.Models;

var nokia = new Nokia("(11) 96990-9503", "Nokia 5.3", "508601269004273", 1000);
var iphone = new Iphone("(11) 96936-7752", "Iphone 12", "532394010460362", 20_000);

nokia.Ligar();
iphone.Ligar();

var facebook = new Aplicativo("Facebook", 200);
var codMobile = new Aplicativo("COD Mobile", 5000);

Console.WriteLine("------ Instalando aplicativos no Iphone ------");
iphone.InstalarAplicativo(facebook);
iphone.InstalarAplicativo(codMobile);

Console.WriteLine("\n------ Instalando aplicativos no Nokia ------");
nokia.InstalarAplicativo(facebook);
nokia.InstalarAplicativo(codMobile);