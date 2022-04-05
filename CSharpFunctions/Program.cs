/*----FUNZIONI----*/

int[] arrayDiProva = { 2, 4, 9, 13, 43, 99 };
int numeroDiProva = 27;

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

int Quadrato(int numero)
{
    int numeroAlQuadrato = (int)Math.Pow(numero, 2);
    return numeroAlQuadrato;
}

Console.WriteLine(Quadrato(numeroDiProva));