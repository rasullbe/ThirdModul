namespace _7dars;

internal class Program
{
    static void Main(string[] args)
    {

        //1
        var func = (int a, int b, int c) => 
        {
            if (a > b && a > c)
                return a;
            else if (b > a && b > c)
                return b;
            else
                return c;
        };

        var answer = func.Invoke(5, 20, 15);
        Console.WriteLine(answer);

        //2
        Action<string, string> action = (str1, str2) =>
        {
            Console.WriteLine($"{str1.Length + str2.Length}"); 
        };
        action.Invoke("Hello", "World");

        //3
        List<Book> books = new List<Book> 
        {
            new Book { Name = "Book1", Author = "Author1", Price = 10 },
            new Book { Name = "Book2", Author = "Author2", Price = 20 },
            new Book { Name = "Book3", Author = "Author3", Price = 30 }
        };

        Func<List<Book>, Book> func2 = (bookList) =>
        {
            return bookList.MaxBy(b => b.Price);
        };
        Console.WriteLine(func2(books));

        //4
        Action<Book> actionn = (bookList) =>
        {
            Console.WriteLine(bookList.Price * 10);
        };

    }



}
