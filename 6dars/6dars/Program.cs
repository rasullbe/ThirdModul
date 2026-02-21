namespace _6dars;

internal class Program
{
    static void Main(string[] args)
    {

        Predicate<int> predicate;
        
        predicate = Predicate;
        predicate += Predicate2;
        predicate += Predicate3;
        predicate += Predicate4;


        predicate.Invoke(5);

        //--------------------------

        Func<string, string> func;
       
        func = Func;
        func += Func2;
        func += Func3;
        func += Func4;


        func.Invoke("Hello World");

        //--------------------------

        Action<string, int> action;
        
        action = Action;
        action += Action2;
        action += Action3;
        action += Action4;


        action.Invoke("Six Seveeeen", 67);
        


    }

    static bool Predicate(int i)
    {
        return i > 0;
    }

    static bool Predicate2(int i)
    {
        return i > 6;
    }

    static bool Predicate3(int i)
    {
        return i > 10;
    }

    static bool Predicate4(int i)
    {
        return i == 100;
    }

    //--------------------------

    static string Func(string s)
    {
        return $"String: {s}";
    }

    static string Func2(string s)
    {
        return $"String: {s}";
    }

    static string Func3(string s)
    {
        return $"String: {s}";
    }

    static string Func4(string s)
    {
        return $"String: {s}";
    }

    //--------------------------

    static void Action(string s, int i)
    {
        Console.WriteLine($"String: {s}, Int: {i}");
    }

    static void Action2(string s, int i)
    {
        Console.WriteLine($"String: {s}, Int: {i}");
    }

    static void Action3(string s, int i)
    {
        Console.WriteLine($"String: {s}, Int: {i}");
    }

    static void Action4(string s, int i)
    {
        Console.WriteLine($"String: {s}, Int: {i}");
    }

}