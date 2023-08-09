using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMB.Core.Domain
{
    public class UserBookshelf
    {
        public DateTime ReadedDate { get; private set; }
        public bool Favorite { get; private set; }
        public bool HaveReaded { get; private set; }
        public bool WantToRead { get; private set; }
        public bool Reading { get; private set; }
        public Book Book { get; private set; }

        public UserBookshelf()
        {

        }

        public void SetAsFavorite()
        {
            Favorite = true;
        }

        public void SetAsHaveReaded(DateTime readedDate)
        {
            ReadedDate = readedDate;
            HaveReaded = true;
            WantToRead = false;
            Reading = false;
        }

        public void SetAsWantToRead()
        {
            Reading = false;
            WantToRead = true;
        }

        public void SetAsReading()
        {
            Reading = true;
            WantToRead = false;
        }

        public void SetBook(Book book)
        {
            Book = book;
        }
    }
}
