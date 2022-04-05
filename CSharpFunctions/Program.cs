/*----FUNZIONI----*/
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

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayClonato = (int[])array.Clone();
    for (int i = 0; i < arrayClonato.Length; i++)
    {
        arrayClonato[i] = Quadrato(arrayClonato[i]);
    }
    return arrayClonato;
}

int SommaElementiArray(int[] array)
{
    int somma = 0;
    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}

/*---------------ESERCIZIO-----------------*/
int[] numeri = {2, 6, 7, 5, 3, 9 };
StampaArray(numeri);

int[] numeriAlQuadrato = ElevaArrayAlQuadrato(numeri);
StampaArray(numeriAlQuadrato);
StampaArray(numeri);

int sommaNumeri = SommaElementiArray(numeri);
Console.WriteLine(sommaNumeri);

int sommaNumeriAlQuadrato = SommaElementiArray(numeriAlQuadrato);
Console.WriteLine(sommaNumeriAlQuadrato); 
