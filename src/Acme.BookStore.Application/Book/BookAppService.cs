using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Book
{
    public class BookAppService :
        CrudAppService<
            Books, 
            BooksDto, 
            Guid, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateBookDto>,
        IBookAppService
    {

        public BookAppService(IRepository<Books, Guid> repository)
            : base(repository)
        {

        }
    }
}
