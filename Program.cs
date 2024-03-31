Console.WriteLine("Tradutor Baleês");
Console.WriteLine();

Console.WriteLine("digite o texto a traduzir para o Baleês:");
Console.WriteLine();

String texto = Console.ReadLine()!;

Console.WriteLine("\nem baleês seria...:\n");

Console.WriteLine(texto
.Replace("a" , "aaa")
.Replace("e" , "eee")
.Replace("i" , "iii")
.Replace("o" , "ooo")
.Replace("u" , "uuu")
);
