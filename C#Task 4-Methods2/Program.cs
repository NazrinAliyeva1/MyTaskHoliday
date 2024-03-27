////task1
//using System;
//class program
//{
//    static void Main()
//    {
//        int[] arr = { 1, -2, 3, -4, -5 };
//        IsNegative(ref arr);
//        foreach (int newArr in arr)
//        {
//            Console.WriteLine(newArr);
//        }
//    }
//    static void IsNegative(ref int[] arr)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] < 0)
//            {
//                arr[i] *= -1;
//            }
//        }
//    }
//}


////task-2
////Usul 1:
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Metn daxil edin:");
//        string inputText = Console.ReadLine();

//        bool containsChar;
//        CheckForChar(inputText, out containsChar);

//        if (containsChar)
//        {
//            Console.WriteLine("Return: " + containsChar);
//        }
//        else
//        {
//            Console.WriteLine("Return: " + containsChar);
//        }
//    }

//    static void CheckForChar(string input, out bool containsChar)
//    {
//        containsChar = false;
//        foreach (char c in input)
//        {
//            if (c == 'd' || c == 'D')
//            {
//                containsChar = true;
//                break;
//            }
//        }
//    }
//}

////Usul 2:
//using System;

//class Program
//{
//    static void Main()
//    {
//        bool result;
//        CheckIfCharExists(out result);
//        Console.WriteLine(result ? "Return: True" : "Return: False");
//    }

//    static void CheckIfCharExists(out bool result)
//    {
//        string inputText = " Menim adim Nezrindir.";
//        char targetChar = 'y';

//        result = inputText.IndexOf(targetChar) != -1;
//    }
//}

////ve ya ikinci usulla yazib yuxari hissesini 1-ci usuldaki kimi vere bilerik

//using System;
//class program
//{
//    static void Main()
//    {
//        bool result;
//        CheckIfCharExist(out result);
//        if (result)
//        {
//            Console.WriteLine("Return: " + result);
//        }
//        else
//        {
//            Console.WriteLine("Return: " + result);
//        }
//    }
//    static void CheckIfCharExist(out bool result)
//    {
//        string inputText = "Menim adim Nezrindir.";
//        char targetChar = 's';

//        result = inputText.IndexOf(targetChar) != -1;
//    }
//}

////Task 3
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 1, -200, 5, 8, 4, -10, -8, 7, -90 };
//        int minimum;
//        Min(arr, out minimum);
//        Console.WriteLine("Minimum eded: " + minimum);
//    }

//    static void Min(int[] arr, out int minimum)
//    {
//        minimum = arr[0];
//        foreach (int num in arr)
//        {
//            if (num < minimum)
//            {
//                minimum = num;
//            }
//        }
//    }
//}

////task 4

//using System;
//class program
//{
//    static void Main()
//    {
//        int num = 1234;
//        NumLength(num, out int count);
//        Console.WriteLine("Ededin reqemleri sayi: " + count);

//    }
//    static void NumLength(int number, out int count)
//    {
//        count = 0;
//        while (number != 0)
//        {
//            number /= 10;
//            count++;
//        }
//    }

//}
////Ya da yuxari hisseni ferqli usulla yaza bilerik:

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Bir eded daxil edin: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        int count;
//        NumLength(num, out count);
//        Console.WriteLine("Daxil edilen ededin reqemleri sayi: " + count);
//    }

//    static void NumLength(int num, out int count)
//    {
//        count = 0;
//        while (num != 0)
//        {
//            num /= 10;
//            count++;
//        }
//    }
//}

////task 5

//task5

//using System;
//class program
//{
//    static void Main()
//    {
//        Console.WriteLine("Metn daxil edin:");
//        string text = Console.ReadLine();

//        VowelLetter(text, out int count);
//        Console.WriteLine(count);
//    }

//    static void VowelLetter(string inputText, out int count)
//    {
//        count = 0;
//        foreach (char c in inputText)
//        {
//            if (IsVowel(c))
//            {
//                count++;
//            }
//        }

//    }

//    static bool IsVowel(char c)
//    {
//        switch (c)
//        {
//            case 'a':
//            case 'e':
//            case 'i':
//            case 'o':
//            case 'u':
//            case 'A':
//            case 'E':
//            case 'I':
//            case 'O':
//            case 'U':
//                return true;
//            default:
//                return false;

//        }
//    }
//}

////task6

//using System;
//class program
//{
//    static void Main()
//    {
//        int[] arr = { 1, 2, 3, 4 };
//        AverageOfArray(arr, out double average);
//        Console.WriteLine(average);
//    }
//    static void AverageOfArray(int[] arr, out double average)
//    {
//        int size = arr.Length;
//        int sum = 0;
//        for (int i = 0; i < size; i++)
//        {
//            sum += arr[i];

//        }
//        average = (double)sum / size;


//    }
//}

////Eger ededi ortani tapanda sadece tam hisseni isteyirikse o zaman bu cur yaziriq:

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 1, 2 };
//        AverageOfArray(arr, out int average);
//        Console.WriteLine("Massivin ededi ortasi: " + average);
//    }

//    static void AverageOfArray(int[] arr, out int average)
//    {
//        int size = arr.Length;
//        int sum = 0;

//        for (int i = 0; i < size; i++)
//        {
//            sum += arr[i];
//        }

//        average = sum / size;
//    }
//}
