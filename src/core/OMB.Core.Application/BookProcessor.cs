
using AutoMapper;
using OMB.Adapter.Repository;
using OMB.Adapter.Repository.Entites;
using OMB.Core.Domain;
using System.Collections.Generic;
using System;

namespace OMB.Core.Application
{    
    public class BookProcessor : IBookProcessor
    {
        private readonly IUserBookshelfRepository _bookshelfRepository;
        private readonly IMapper _mapper;
        public BookProcessor(IUserBookshelfRepository bookshelfRepository,
            IMapper mapper)
        {
            _bookshelfRepository = bookshelfRepository;
            _mapper = mapper;
        }

        public List<UserBookshelf> GetUserBookshelve()
        {

            var result = _bookshelfRepository.GetBookshelf().Response.ToList();
            var value = _mapper.Map<List<UserBookRegistryEntity>,List<UserBookshelf>>(result);

            return value;
        }

        public UserBookshelf GetNextBookToRead()
        {
            var result = GetUserBookshelve().Where(x => x.WantToRead);
            int index = new Random().Next(result.Count());

            return result.ToArray()[index];
        }
    }
}

