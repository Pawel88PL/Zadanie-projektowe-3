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
            HeapSort heapSort = new HeapSort();


            Console.WriteLine("Przedmiot: Algorytmy i struktury danych" +
                "\n Zadanie projektowe 3: \n Algorytmy sortowania.");

            Console.WriteLine("\n===========================================\n");

            Console.WriteLine("Jaki algorytm chcesz wybrać?" +
                "\n 1. Sortowanie przez wybieranie (Selection Sort)." +
                "\n 2. Sortowanie przez wstawianie (Insertion Sort)." +
                "\n 3. Sortowanie stogowe (Heap Sort)." +
                "\n 4. Sortowanie koktajlowe (Coctail Sort)." +
                "\n 5. Sortowanie szybkie (Quick Sort).");
            Console.WriteLine();

            string? n = Console.ReadLine();

            switch (n)
            {
                case "1":
                    Console.WriteLine();
                    selectionSort.SortRandomTable();
                    selectionSort.SortIncreaseTable();
                    selectionSort.SortDecreaseTable();
                    selectionSort.PrintTable();
                    break;
                case "2":
                    Console.WriteLine();
                    insertionSort.SortRandomTable();
                    insertionSort.SortIncreaseTable();
                    insertionSort.SortDecreaseTable();
                    insertionSort.PrintTable();
                    break;
                case "3":
                    Console.WriteLine();
                    heapSort.SortRandomTable();
                    heapSort.SortIncreaseTable();
                    heapSort.SortDecreaseTable();
                    heapSort.PrintTable();
                    break;
                case "4":
                    
                    break;
            }
            Console.WriteLine();
        }


        static bool EndProgram()
        {
            string? end;
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