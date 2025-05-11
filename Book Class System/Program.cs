namespace Book_Class_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Math", "Ali", 1990, "18e738790");
            Book book2 = new Book("Arabic", "Waleed", 1988, "098876631");
            Book book3 = new Book("Islamic", "Raya", 2000, "83298298");
            book1.PrintBookInfo();
            book2.PrintBookInfo();
            book3.PrintBookInfo();
            Console.WriteLine(book1.Older());
            Console.WriteLine(book2.Older());
            Console.WriteLine(book3.Older());

        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public Book(string title, string author, int year, string iSBN)
        {
            Title = title;
            Author = author;
            Year = year;
            ISBN = iSBN;
        }
        public void PrintBookInfo()
        {
            Console.WriteLine($"Title: {Title},Author: {Author}, Year: {Year}, ISBN: {ISBN}");

        }
        public bool Older()
            
            {
            
            return 1999> Year; 
        }

    }
}
