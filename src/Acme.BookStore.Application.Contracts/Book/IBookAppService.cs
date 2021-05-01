using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Book
{
    public interface IBookAppService : ICrudAppService<BooksDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateBookDto>
    {

    }
}
