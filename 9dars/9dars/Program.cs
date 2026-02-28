using System.Collections;
using System.Linq;

namespace _9dars;

internal class Program
{
    static void Main(string[] args)
    {
        //12 пример
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(7);
        arrayList.Add(4);
        arrayList.Add(5);
        var max = arrayList.Cast<int>().Max();
        Console.WriteLine(max);

        //11 пример 
        ArrayList arrayList1 = new ArrayList();
        arrayList1.Add(1);
        arrayList1.Add(2);
        arrayList1.Add(7);
        arrayList1.Add(4);
        arrayList1.Add(5);
        var summ = arrayList1.Cast<int>().Sum();
        Console.WriteLine(summ);
    }
}
