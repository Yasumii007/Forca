string palavra, letra;
bool possuiLetra;

Console.WriteLine("Bem- vindo ao jogo da forca");
Console.WriteLine("---- Forca ----");

Console.WriteLine("Por favor digite a palavra secreta");
palavra = Console.ReadLine()!.ToLower();

Console.Clear();

Console.WriteLine("Digite uma letra: ");
letra = Console.ReadLine()!.ToLower();

possuiLetra = palavra.Contains(letra);


Console.WriteLine($"A letra digitada por você foi \"{letra}\", ela é => {possuiLetra}");