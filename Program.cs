using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Skapa en instans av klassen och lägg till namn i listan
        CustomNameList<string> nameList = new CustomNameList<string>();
        nameList.Add("Jonathan");
        nameList.Add("Johannes");
        nameList.Add("Emil");
        nameList.Add("Daniel");
        nameList.Add("Morris");
        nameList.Add("Sam");
        nameList.Add("Findus");

        // Skriv ut inmatade ord.
        Console.WriteLine("Inmatad namn:");
        nameList.Print();

        // Sortera listan
        nameList.Sort();

        // Skriv ut sorterade namn
        Console.WriteLine("\nEfter Sorting:");
        nameList.Print();

        // Ta bort Let från listan
        nameList.Remove("Emil");

        // Skriv ut namn efter borttagning
        Console.WriteLine("\nTa bort Emil:");
        nameList.Print();

        // Infoga "You" på position 3
        nameList.Insert(2, "Oliver");

        // Skriv ut ord efter infogning
        Console.WriteLine("\nInfoga Oliver på position 3:");
        nameList.Print();

        CustomNumberList<int> numberList = new CustomNumberList<int> { };

        //Lägger toll siffror.
        numberList.Add(14);
        numberList.Add(5);
        numberList.Add(22);
        numberList.Add(5);
        numberList.Add(18);
        numberList.Add(7);
        numberList.Add(15);

        Console.WriteLine("\nInmatade Nummer");
        numberList.Print();

        //Efter sortering
        Console.WriteLine("\nEfter sortering");
        numberList.Sort();
        numberList.Print();
        //Tar bort
        Console.WriteLine("\nListan efter bortagna siffror");
        numberList.Remove(7);
        numberList.Remove(5);

        numberList.Print();
        Console.ReadKey();
    }
}



