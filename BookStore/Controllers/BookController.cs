using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class BookController
    {
        private static List<Book> BookList = new List<Book>()
       {
           new Book
           {
               Id=1,
               Title="Hello World",
               GenreId=1,
               //Personel Growth
               PageCount=200,
               PublishDate=new System.DateTime (2001,06,12)
           },
               new Book
           {
               Id=2,
               Title="Herland",
               GenreId=2,
               PageCount=250,
               PublishDate=new System.DateTime (2002,07,13)
           },
                     new Book
           {
               Id=3,
               Title="Dune",
               GenreId=3,
               PageCount=540,
               PublishDate=new System.DateTime (2004,04,14)
           }
       };
        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
            return bookList;
        }
    }
}
