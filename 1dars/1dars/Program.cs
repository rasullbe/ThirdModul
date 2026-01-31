namespace _1dars;

internal class Program
{
    static void Main(string[] args)
    {



        MyList myList = new MyList(3);
        myList.Add(77);
        myList.Add(71);
        myList.Add(73);
        myList.DisplayElements();
        myList.RemoveAt(1);
        Console.WriteLine("");
        myList.DisplayElements();   



        // Boxing and Unboxing Example
        //Object obj = new Object();
        //int num = 42;
        //obj = num; 
        //int num2 = (int)obj;
        //Console.WriteLine(num2);
    }
}
