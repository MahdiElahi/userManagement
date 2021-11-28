using Main.Application.ViewModels;
using Main.Domain.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Application.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookViewModel>> GetBooks();
        Task<BookViewModel> GetById(int id);
        Task<BookViewModel> CreateBook(BookViewModel bookModel);
        Task EditBook(BookViewModel bookModel);
        Task DeleteBook(int id);
        Task SaveChanges();
    }

}
