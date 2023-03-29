List<int> notas = new List<int>();

Console.WriteLine("Coloque as suas notas para calcularmos sua média e sua aprovação!");

for (int i = 0; i < 4; i++)
{
    int nota = int.Parse(Console.ReadLine());
    notas.Add(nota);
}

float media = 0;

foreach (int nota in notas)
{
    media += nota;
}

media = media / 4;

Console.WriteLine("=====");
Console.WriteLine(media);

if (media >= 60 && media < 100)
{
    Console.WriteLine("=============================");
    Console.WriteLine("Parabéns você está aprovado!");
    Console.WriteLine("=============================");
}

else if (media == 100)
{
    Console.WriteLine("=========================================");
    Console.WriteLine("Parabéns você está aprovado com láureas!");
    Console.WriteLine("=========================================");
}

else if (media > 100)
{
    Console.WriteLine("=======================================");
    Console.WriteLine("Essa nota não é possível de alcançar!");
    Console.WriteLine("=======================================");
}

else
{
    Console.WriteLine("=========================================================================");
    Console.WriteLine("Infelizmente você está reprovado. Se esforce um pouco mais ano que vem!");
    Console.WriteLine("=========================================================================");
}