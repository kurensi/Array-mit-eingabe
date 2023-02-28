try
{
    Console.Write($"Geben sie die Grösse des int Arrays ein: ");
    int wahl = Convert.ToInt32(Console.ReadLine());
    if (wahl > 0 && wahl <= 12)
    {
        int[] array1 = new int[wahl];
        int[] array2 = new int[wahl];
        int[] array = new int[wahl];
        double d = 0;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Geben sie die {i + 1} des int Arrays ein: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
            d+=array[i];
        }
        int max = array[0], min = array[0], l=0, b = 0; ;
        foreach ( int x in array)
        {
            if (x > max)
            {
                max = x;
            }
            if (x < min)
            {
                min = x;
                
            }
            if (x % 2 != 1)
            {
                array1[l] = x;
               // Console.Write($"\nGerade {array1[l]}, ");
                l++;
            }
            else
            {
                array2[b] = x;
                //Console.Write($"\nungerade {array2[b]}, ");
                b++;
            }
           // Console.Write(x + " ");
        }
        Console.WriteLine($"gerade: ");
        foreach (int x in array1)
        {
            Console.Write($"{x} ");
        }
        Console.WriteLine($"\nUngerade: ");
        foreach (int x in array2)
        {
            Console.Write($"{x} ");
        }
        Console.WriteLine($"\nMax : {max} \nMin : {min} \nDurchschnitt : {d/array.Length}");

        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Leider falsche eingabe");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}