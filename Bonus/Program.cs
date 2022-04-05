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

int SceltaDimensioneArrayUtente()
{
    int sceltaUtente = 0;
    bool flag = false;
    do
    {
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            flag = true;
            sceltaUtente = numero;
        }
        else
        {
            Console.WriteLine("Perfavore inserisci un numero intero");
        }
    } while (flag == false);
    return sceltaUtente;
}

int[] SceltaNumeriArrayUtente(int dimensioneArray)
{
    int[] numeri = new int[dimensioneArray];
    for (int i = 0; i < dimensioneArray; i++)
    {
        Console.WriteLine("Inserisci il " + (i + 1) + "° numero");
        bool flag = false;
        do
        {
            if (int.TryParse(Console.ReadLine(), out int numeroScelto))
            {
                numeri[i] = numeroScelto;
                flag = true;
            }
            else
            {
                Console.WriteLine("Perfavore inserisci un numero intero");
            }
        } while (flag == false);
    }
    return numeri;
}
/*---------------ESERCIZIO CON BONUS-----------------*/
Console.WriteLine("Indica la dimensione dell'array: ");
int dimensioneArrayUtente = SceltaDimensioneArrayUtente();
int [] numeri = SceltaNumeriArrayUtente(dimensioneArrayUtente);

Console.WriteLine("Il tuo array è:");
StampaArray(numeri);

Console.WriteLine("Il quadrato dei numeri del tuo array sono:");
int[] numeriAlQuadrato = ElevaArrayAlQuadrato(numeri);
StampaArray(numeriAlQuadrato);
Console.WriteLine("L'array iniziale è rimasto invariato:");
StampaArray(numeri);

Console.WriteLine("La somma dei numeri del tuo array è:");
int sommaNumeri = SommaElementiArray(numeri);
Console.WriteLine(sommaNumeri);

Console.WriteLine("La somma dei numeri al quadrato del tuo array è:");
int sommaNumeriAlQuadrato = SommaElementiArray(numeriAlQuadrato);
Console.WriteLine(sommaNumeriAlQuadrato);
