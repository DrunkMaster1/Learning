


using Learning;

public class Program
{
     static void Main(string[] args)
    {

       Calculater calc = new Calculater();
        double square2 = calc.Calculater11(10, 20);
        double square1 = calc.Calculater11(10, 20, 30);
        Console.WriteLine($" Square1 = {square1},Square2 = {square2}");
    }
    static void forCycl()
    {
        int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, 3, 2, 7, -1, -3, 1, 7 };
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int atI = numbers[i];
                int atj = numbers[j];
                if (atI + atj == 0)
                {

                    Console.WriteLine($"Pair {atI};{atj}. Indexes {i};{j}");
                }
            }

        }
        Console.WriteLine();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {

                for (int k = j + 1; k < numbers.Length; k++)
                {
                    int atI = numbers[i];
                    int atj = numbers[j];
                    int atk = numbers[k];
                    if (atI + atj + atk == 0)
                    {

                        Console.WriteLine($"Triplets {atI};{atj};{atk}. Indexes {i};{j};{k}");
                    }

                }

            }

        }
    }
    static void arrays()
    {
        var intList = new List<int> { 1, 2, 3 };
        intList.Add(17);
        int[] intArray = { 1, 2, 3 };
        intList.AddRange(intArray);
        if (intList.Remove(1)) // first occurence 
        {

            Console.WriteLine(intArray.Length);
        }
        intList.RemoveAt(0);
        intList.Reverse();
        int min = intList.Min();
        int max = intList.Max();
        Console.WriteLine($"Min={min} and Max = {max}");
        int indexOf = intList.IndexOf(2);
        int lastIndexOf = intList.LastIndexOf(2);
        Console.WriteLine($"IndexOf2={indexOf} and LastIndexOf2 = {lastIndexOf}");
        for (int i = 0; i < intList.Count; i++)
        {

            Console.WriteLine(intList[i]);
        }
        Console.WriteLine();

        var stack = new Stack<int>();
        stack.Push(1);

    }
    static void character()
    {

        Character c = new Character();
        c.Hit(120);
        Console.WriteLine(c.Health);
    }
   
 
}