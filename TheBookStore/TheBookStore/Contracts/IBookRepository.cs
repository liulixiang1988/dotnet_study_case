using System.Linq;
using TheBookStore.Models;

namespace TheBookStore.Contracts
{
    public interface IBookRepository
    {
        IQueryable<Book> All { get; }

        IQueryable<Book> Search(string criteria);

        Book GetOne(int id);
    }
}
