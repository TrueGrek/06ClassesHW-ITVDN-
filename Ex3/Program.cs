using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book.Notes b = new Book.Notes();
            b.Text = "GODa boook";
            b.Text = "Game of Ender";
            Console.WriteLine(b.Text);
        }

    }
    class Book
    {
        public void Find(string s)
        {
            Console.WriteLine("Search string: {0}", s);
        }
        public class Notes
        {
            string text = "";
            public string Text
            {
                get { return text; }
                set {
                    if (text != "")
                        text += "\n";
                    text += value;
                    }
            }
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
