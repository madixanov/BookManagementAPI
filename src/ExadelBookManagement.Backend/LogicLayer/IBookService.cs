using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface IBookService
    {
        
            Task<IEnumerable<Book>> GetBooksAsync();
            //Task<Book> GetBookByIdAsync(int id);
            //Task<Book> AddBookAsync(Book book);
            //Task UpdateBookAsync(Book book);
            //Task DeleteBookAsync(int id);
     
    }
}
