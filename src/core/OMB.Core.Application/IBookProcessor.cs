using OMB.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMB.Core.Application
{
    public interface IBookProcessor
    {
        List<UserBookshelf> GetUserBookshelve();
        UserBookshelf GetNextBookToRead();
    }
}
