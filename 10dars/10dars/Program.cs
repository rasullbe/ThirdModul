namespace _10dars;

internal class Program
{
    static void Main(string[] args)
    {
        //5 задание 
        Dictionary<Book, string> dict = new Dictionary<Book, string>();
        Book book1 = new Book()
        {
            BookId = Guid.NewGuid(),
            Name = "The Great Gatsby",
            Year = 1925
        };
        var book2 = new Book()
        {
            BookId = Guid.NewGuid(),
            Name = "To Kill a Mockingbird",
            Year = 1960
        };
        var book3 = new Book()
        {
            BookId = Guid.NewGuid(),
            Name = "1984",
            Year = 1949
        };
        var book4 = new Book()
        {
            BookId = Guid.NewGuid(),
            Name = "Pride and Prejudice",
            Year = 1813
        };

        dict.Add(book1, book1.Name.ToString());
        dict.Add(book2, book2.Name.ToString());
        dict.Add(book3, book3.Name.ToString());
        dict.Add(book4, book4.Name.ToString());

        









        //Stack<int> stack = new Stack<int>();
        //stack.Push(42);
        //stack.Push(73);
        //stack.Push(99);
        //stack.Push(959);
        //stack.Push(123);
        //stack.Push(456);
        //stack.Push(789);
        //stack.Push(321);    
        //stack.Push(654);
        //stack.Push(987);

        //foreach (int item in stack)
        //{
        //    if (item % 2 == 0)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}


    }
}
