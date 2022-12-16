using System;
using System.Diagnostics;

public class Quicksort
{
    private static int equalOperationCounter;

    private void QsortIteration(int[] tab)
    {
        int i, j, l, p, sp;
        int[] stos_l = new int[tab.Length];
        int[] stos_p = new int[tab.Length];
        sp = 0; stos_l[sp] = 0; stos_p[sp] = tab.Length - 1;
        do
        {
            l = stos_l[sp]; p = stos_p[sp]; sp--;
            do
            {
                int x;
                i = l; j = p; x = tab[(l + p) / 2];
                do
                {
                    while (tab[i] < x)
                    {
                        i++;
                    }
                    while (x < tab[j])
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        int buf = tab[i]; tab[i] = tab[j]; tab[j] = buf;
                        i++; j--;
                    }
                } while (i <= j);
                if (i < p)
                {
                    sp++; stos_l[sp] = i; stos_p[sp] = p;
                }
                p = j;
            } while (l < p);
        } while (sp >= 0);
    }



    public void SortRandomTable()
    {
        Table table = new Table();
        int[] tab = table.TableRandom();

        equalOperationCounter = 0;
        uint iterationsNumber = 10;
        long elapsedTime = 0;
        long minTime = long.MaxValue;
        long maxTime = long.MinValue;
        for (int n = 0; n < (iterationsNumber + 1 + 1); ++n)
        {
            long startingTime = Stopwatch.GetTimestamp();

            // Poniżej wywołujemy metodę sortowania, która jest w pętli 10 - ciu powtórzeń.
            QsortIteration(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb losowych iteracyjnym algorytmem Quick Sort:" +
            "\n Liczba operacji sortowania: {0}. Średni czas przebiegu operacji: {1} [s]," +
            "\n zakładając odrzucenie czasów skrajnych.", equalOperationCounter, elapsedSeconds.ToString("F8"));

        Console.WriteLine();
        Console.WriteLine("\n===========================================\n");
    }




    public void SortIncreaseTable()
    {
        Table table = new Table();
        int[] tab = table.TableIncrease();

        equalOperationCounter = 0;
        uint iterationsNumber = 10;
        long elapsedTime = 0;
        long minTime = long.MaxValue;
        long maxTime = long.MinValue;
        for (int n = 0; n < (iterationsNumber + 1 + 1); ++n)
        {
            long startingTime = Stopwatch.GetTimestamp();

            // Poniżej wywołujemy metodę sortowania, która jest w pętli 10 - ciu powtórzeń.
            QsortIteration(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb od najmniejszej do największej algorytmem Quick Sort:" +
            "\n Liczba operacji sortowania: {0}. Średni czas przebiegu operacji: {1} [s]," +
            "\n zakładając odrzucenie czasów skrajnych.", equalOperationCounter, elapsedSeconds.ToString("F8"));

        Console.WriteLine();
        Console.WriteLine("\n===========================================\n");
    }




    public void SortDecreaseTable()
    {
        Table table = new Table();
        int[] tab = table.TableDecrease();

        equalOperationCounter = 0;
        uint iterationsNumber = 10;
        long elapsedTime = 0;
        long minTime = long.MaxValue;
        long maxTime = long.MinValue;
        for (int n = 0; n < (iterationsNumber + 1 + 1); ++n)
        {
            long startingTime = Stopwatch.GetTimestamp();

            // Poniżej wywołujemy metodę sortowania, która jest w pętli 10 - ciu powtórzeń.
            QsortIteration(tab);

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

        Console.WriteLine("Sortowanie tablicy liczb od największej do najmniejszej algorytmem Quick Sort:" +
            "\n Liczba operacji sortowania: {0}. Średni czas przebiegu operacji: {1} [s]," +
            "\n zakładając odrzucenie czasów skrajnych.", equalOperationCounter, elapsedSeconds.ToString("F8"));

        Console.WriteLine();
        Console.WriteLine("\n===========================================\n");
    }



    public void PrintTable()
    {
        Console.WriteLine("Wyświetlić tablicę liczb? T/N \n");
        string? choice = Console.ReadLine();

        if (choice == "t")
        {
            Table table = new Table();

            // Deklarujemy tablicę liczb losowych
            int[] tabR = table.TableRandom();

            Console.WriteLine("Tablica liczb losowych: \n");
            for (int i = 0; i < tabR.Length; i++)
            {
                Console.Write("{0}, ", tabR[i]);
            }
            Console.WriteLine("\n ======================================== \n");

            // Deklarujemy tablicę liczb od największej do najmniejszej
            int[] tabD = table.TableDecrease();

            Console.WriteLine("Tablica liczb od największej do najmniejszej: \n");
            for (int i = 0; i < tabD.Length; i++)
            {
                Console.Write("{0}, ", tabD[i]);
            }
            Console.WriteLine("\n ======================================== \n");

            // Sortujemy tablicę liczb losowych.
            QsortIteration(tabR);

            Console.WriteLine("Sortowanie algorytmem Quick Sort: " +
                "\n Posortowana tablica liczb losowych: \n");
            for (int i = 0; i < tabR.Length; i++)
            {
                Console.Write("{0}, ", tabR[i]);
            }
            Console.WriteLine("\n ======================================== \n");


            // Sortujemy tablicę liczb od największej do najmniejszej.
            QsortIteration(tabD);

            Console.WriteLine("Sortowanie algorytmem Quick Sort: " +
                "\n Posortowana tablica liczb od największej do najmniejszej: \n");
            for (int i = 0; i < tabD.Length; i++)
            {
                Console.Write("{0}, ", tabD[i]);
            }
            Console.WriteLine();
            Console.WriteLine("\n ======================================== \n");
        }
    }
}
