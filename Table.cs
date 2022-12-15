using System;

public class Table
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
        int[] table = new int[5000];
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = i;
        }
        return table;
    }


    public int[] TableDecrease()
    {
        int n = 5000;
        int[] table = new int[n];
        for (int i = 0; i < table.Length; i++)
        {
            table[i] = n-1-i;
        }
        return table;
    }
}
