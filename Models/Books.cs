using System;

namespace Fisher.Bookstore.Models
{
    public class Books
    {
        public int BookId {get; set;}

        public string Title {get; set;}

        public Authors Author {get; set;}

        public void SellBook()
        {
            //code to sell book goes here
        }
    }
}