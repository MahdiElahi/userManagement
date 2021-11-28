using AutoMapper;
using Main.Application.Interfaces;
using Main.Application.Mapper;
using Main.Application.ViewModels;
using Main.Domain.Interfaces;
using Main.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Application.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        private IMapper _mapper;
        public BookService(IBookRepository bookRepository,IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookViewModel> CreateBook(BookViewModel bookModel)
        {
            //=> Convert ViewMOdel to MOdel
            var mappedEntity = ObjectMapper.Mapper.Map<Book>(bookModel);

            //=> Add
            var newEntity = await _bookRepository.AddAsync(mappedEntity);

            //=> Convert Model to ViewModel
            var newMappedEntity = ObjectMapper.Mapper.Map<BookViewModel>(newEntity);
            return newMappedEntity;
        }

        public async Task DeleteBook(int id)
        {
            var deletedbook = await _bookRepository.GetByIdAsync(id);

            await _bookRepository.RemoveAsync(deletedbook);
        }

        public async Task EditBook(BookViewModel bookModel)
        {
            var editBook = await _bookRepository.GetByIdAsync(bookModel.BookId);
            if (editBook == null)
                throw new ApplicationException($"Entity could not be loaded.");

            ObjectMapper.Mapper.Map<BookViewModel, Book>(bookModel, editBook);

            var mappedEntity = ObjectMapper.Mapper.Map<Book>(editBook);

             await _bookRepository.UpdateAsync(mappedEntity);

        }

        public async Task<IEnumerable<BookViewModel>> GetBooks()
        {
            var list =await _bookRepository.GetBooksAsync();
            var mapped = ObjectMapper.Mapper.Map<IEnumerable<BookViewModel>>(list);
            return mapped;
        }

        public async Task<BookViewModel> GetById(int id)
        {
            var model = await _bookRepository.GetByIdAsync(id);
            var mapped = ObjectMapper.Mapper.Map<BookViewModel>(model);
            return mapped;
        }

        public async Task SaveChanges()
        {
            await _bookRepository.SaveChangesAsync();
        }
    }
}
