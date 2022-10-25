Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("--- Fluxograma Da Engenharia --- \n");
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("O objeto esta se movendo:(S/N):");
bool vendoEstaSemo = Console.ReadLine()! .Trim().Substring(0,1).ToUpper()== "S";


Console.Write("Deveria?");
bool Deveria = Console.ReadLine()! .Trim().Substring(0,1).ToUpper()== "S";

Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Blue;


string mensagem;

if (!vendoEstaSemo)
{
    if (!Deveria)
    {
        mensagem = "Ótimo!";
    }
    else
    {
        mensagem = "Use WD-40.";
    }
}
else
{
    if (Deveria)
    {
        mensagem = "Ótimo!";
    }
    else
    {
        mensagem = "Use Silver Tape.";
    }
}

Console.WriteLine();
Console.WriteLine(mensagem);

Console.ResetColor();
