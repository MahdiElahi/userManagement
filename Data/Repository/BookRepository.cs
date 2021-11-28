using Data.Context;
using Main.Domain.Interfaces;
using Main.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _db;
        public BookRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Book> AddAsync(Book book)
        {
            await _db.Books.AddAsync(book);
            return book;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync() => await _db.Books.ToListAsync();

        public async Task<Book> GetByIdAsync(int id) => await _db.Books.FindAsync(id);

        public async Task RemoveAsync(Book book) =>  _db.Books.Remove(book);

        public async Task SaveChangesAsync() => await _db.SaveChangesAsync();

        public async Task UpdateAsync(Book book) =>  _db.Books.Update(book);
    }
}
