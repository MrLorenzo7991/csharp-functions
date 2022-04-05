/*----FUNZIONI----*/

int[] arrayDiProva = { 2, 4, 9, 13, 43, 99 };

void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

StampaArray(arrayDiProva);