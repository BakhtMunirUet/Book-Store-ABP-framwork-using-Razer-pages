using Acme.BookStore.Book;
using AutoMapper;

namespace Acme.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {
            CreateMap<Books, BooksDto>();
            CreateMap<CreateUpdateBookDto, Books>();
        }
    }
}
