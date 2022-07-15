using Desafio_Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_sharp.src.Entities;

Knight arus = new Knight("Arus", 23, "Knight");
Ninja wedge = new Ninja("Wedge", 42, "Ninja");
WhiteWizard jenica = new WhiteWizard("Jenica", 23, "White Wizard");
BlackWizard topapa = new BlackWizard("Topapa", 53, "Black Wizard");



Console.WriteLine();
Console.WriteLine(wedge.Attack() +" enquanto " + arus.Attack());
Console.WriteLine();

Console.WriteLine(jenica.Attack(1));
Console.WriteLine(topapa.Attack(8));

Console.WriteLine();

Console.WriteLine(topapa.Attack(2));
Console.WriteLine(jenica.Attack(7));

Console.WriteLine();
