using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("(81)99887-1360","Sansung galaxy 21", "1874", 240);

n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Temple Run");

Console.WriteLine("\n");

Iphone i1 = new Iphone("(81)99887-1350","Iphone 10", "1844", 120);

i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("League of Legends");
