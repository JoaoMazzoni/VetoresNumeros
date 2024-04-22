int numero;
int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Digite o valor do {0}° número: ", i+1);
    numero = int.Parse(Console.ReadLine());
    numeros[i] = numero;
}

Console.WriteLine("\n");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("O {0}° número digitado é: {1}", i+1, numeros[i]);
}