using Main.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Domain.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooksAsync();
        Task<Book> GetByIdAsync(int id);
        Task RemoveAsync(Book book);
        Task UpdateAsync(Book book);
        Task SaveChangesAsync();
        Task<Book> AddAsync(Book book);
    }
}
