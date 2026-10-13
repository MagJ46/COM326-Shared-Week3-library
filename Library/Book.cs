using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return Title; }
            set { Title = value; }
        }
        public string Author
        {
            get { return Author; }
            set { Author = value; }
        }
        public string ISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }

        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
} 
    
