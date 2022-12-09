namespace Zadanie_projektowe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                RunProgram();
                Console.WriteLine();
            }
            while (EndProgram());
        }


        static void RunProgram()
        {
            SelectionSort selectionSort = new SelectionSort();
            InsertionSort insertionSort = new InsertionSort();


            Console.WriteLine("Przedmiot: Algorytmy i struktury danych" +
                "\n Zadanie projektowe 3: \n Algorytmy sortowania.");

            Console.WriteLine("\n===========================================\n");

            Console.WriteLine("Jaki algorytm chcesz wybrać?" +
                "\n 1. Sortowanie przez wybieranie (Selection Sort)." +
                "\n 2. Sortowanie przez wstawianie (Insertion Sort)." +
                "\n 3. Sortowanie bąbelkowe (Bubble Sort)." +
                "\n 4. Sortowanie koktajlowe (Shaker Sort)." +
                "\n 5. Sortowanie szybkie (Quick Sort).");
            Console.WriteLine();

            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine();
                    selectionSort.PrintTabBeforeSort();
                    selectionSort.PrintTabAfterSort();
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    insertionSort.PrintTabBeforeSort();
                    insertionSort.PrintTabAfterSort();
                    Console.WriteLine();
                    break;
                case 3:
                    // sito.CheckIsPrimeNumber();
                    break;
                case 4:
                    // bonus.CheckIsPrimeNumber();
                    break;
            }
            Console.WriteLine();
        }


        static bool EndProgram()
        {
            string end;
            Console.WriteLine("Czy chcesz zakończyć program? \n" +
                "Tak - naciśnij Enter. \n" +
                "Nie - wpisz słowo 'nie'.");
            end = Console.ReadLine();
            Console.WriteLine();

            if (end == "nie")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}