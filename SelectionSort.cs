using System;
using System.Diagnostics;

public class SelectionSort
{
    private static int equalOperationCounter;

    public void SelectionSortAlgorithm(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            int smallest = i;
            for (int j = i + 1; j < tab.Length; j++)
            {

                equalOperationCounter++;

                if (tab[j] < tab[smallest])
                {
                    smallest = j;

                }
            }
            int temp = tab[smallest];
            tab[smallest] = tab[i];
            tab[i] = temp;
        }

    }


    public void PrintTabBeforeSort()
    {
        Table table = new Table();
        int[] tab = table.TableRandom();

        Console.WriteLine("Tablica elementów do posortowania: \n");
        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write("{0}, ", tab[i]);
        }
        Console.WriteLine();
        Console.WriteLine("\n ======================================== \n");
    }

    public void PrintTabAfterSort()
    {
        Table table = new Table();
        int[] tab = table.TableRandom();

        SelectionSortAlgorithm(tab);

        Console.WriteLine("Sortowanie przez wybieranie: ");
        Console.WriteLine("Tablica posortowana: \n");
        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write("{0}, ", tab[i]);
        }
        Console.WriteLine();
        Console.WriteLine("\n ======================================== \n");


        uint iterationsNumber = 10;
        long elapsedTime = 0;
        long minTime = long.MaxValue;
        long maxTime = long.MinValue;
        for (int n = 0; n < (iterationsNumber + 1 + 1); ++n)
        {
            long startingTime = Stopwatch.GetTimestamp();

            // Poniżej wywołujemy metodę sortowania, która jest w pętli 10 - ciu powtórzeń.
            SelectionSortAlgorithm(tab);

            long endingTime = Stopwatch.GetTimestamp();
            long iterationElapsedTime = endingTime - startingTime;
            elapsedTime += iterationElapsedTime;
            if (iterationElapsedTime < minTime)
            {
                minTime = iterationElapsedTime;
            }
            if (iterationElapsedTime > maxTime)
            {
                maxTime = iterationElapsedTime;
            }
        }

        elapsedTime -= (minTime + maxTime);
        double elapsedSeconds = elapsedTime * (1.0 / (iterationsNumber * Stopwatch.Frequency));

        Console.WriteLine("Sortowanie przez wstawianie:" +
            "\n Liczba operacji sortowania: {0}. Średni czas przebiegu operacji: {1} [s]," +
            "\n zakładając odrzucenie czasów skrajnych.", equalOperationCounter, elapsedSeconds.ToString("F8"));

        Console.WriteLine();
    }
}
