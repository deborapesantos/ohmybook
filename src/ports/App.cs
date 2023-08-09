using OMB.Core.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohmybook
{
    public class App
    {
        private static IBookProcessor _bookProcessor;

        public App(IBookProcessor bookProcessor)
        {
            _bookProcessor = bookProcessor;
        }

        public void Run(string[] args)
        {
           var Bookshelve = _bookProcessor.GetNextBookToRead();

            Console.WriteLine($"Title: {Bookshelve.Book.Title}");
            Console.WriteLine($"Autor: {Bookshelve.Book.Autor}");
        }
    }
}
