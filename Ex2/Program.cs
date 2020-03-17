using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Kilimanjaro";
            FindAndReplaceManager.FindStatic(s);
        }
    }

    class Book
    {
        public void Find(string s)
        {
            Console.WriteLine("Search string: {0}",s);
        }
    }
    static class FindAndReplaceManager
    {
        public static void FindStatic(string str)
        {
            Book book = new Book();
            book.Find(str);
        }
    }
}
