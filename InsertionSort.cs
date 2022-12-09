using System;
using System.Diagnostics;

public class InsertionSort
{
    public int equalOperationCounter = 0;

    public void InsertionSortAlgorithm(int[] tab)
    {
        for (int i = 1; i < tab.Length; i++)
        {
            int j = i;
            int temp = tab[j];
            while ((j > 0) && (tab[j - 1]) > temp)
            {
                equalOperationCounter++;
                tab[j] = tab[j - 1];
                j--;
            }
            tab[j] = temp;
        }

    }

    public void PrintTabBeforeSort()
    {
        Table50k table = new Table50k();
        int[] tab = table.TableRandom();

        Console.WriteLine("Tablica elementów do posortowania: \n");
        for (int i = 0; i < table.TableRandom().Length; i++)
        {
            Console.Write("{0}, ", tab[i]);
        }
        Console.WriteLine();
        Console.WriteLine("\n ======================================== \n");
    }

    public void PrintTabAfterSort()
    {
        Table50k table = new Table50k();
        int[] tab = table.TableRandom();

        InsertionSortAlgorithm(tab);

        Console.WriteLine("Sortowanie przez wybieranie: ");
        Console.WriteLine("Tablica posortowana: \n");
        for (int i = 0; i < tab.Length; i++)
        {
            Console.Write("{0}, ", tab[i]);
        }
        Console.WriteLine();
        Console.WriteLine("\n ======================================== \n");


        for (int i = 1; i < 10; i++)
        {
            uint iterationsNumber = 10;
            long elapsedTime = 0;
            long minTime = long.MaxValue;
            long maxTime = long.MinValue;
            for (int n = 0; n < (iterationsNumber + 1 + 1); n++)
            {
                long startingTime = Stopwatch.GetTimestamp();
                InsertionSortAlgorithm(tab);
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

            Console.WriteLine("Licza operacji sortowania: {0}. Średni czas przebiegu operacji: {1} [s]," +
                "zakładając odrzucenie czasów skrajnych.", equalOperationCounter, elapsedSeconds.ToString("F8"));

            Console.WriteLine();
        }


    }
}
