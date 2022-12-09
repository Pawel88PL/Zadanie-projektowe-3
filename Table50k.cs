using System;

public class Table50k
{
    public int[] TableRandom()
    {
        int[] table = new int[5000];
        Random rnd = new Random();
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = rnd.Next(1, 5000);
        }
        return table;
    }



    public int[] TableIncrease()
    {
        int[] table = new int[50000];
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = i;
        }
        return table;
    }


    public int[] TableDecrease()
    {
        int[] table = new int[50000];
        for (int i = 50000; i > 1; i--)
        {
            table[i] = i;
        }
        return table;
    }
}
