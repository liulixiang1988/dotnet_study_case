using System.Linq;
using TheBookStore.Models;

namespace TheBookStore.Contracts
{
    public interface IAuthorRepository
    {
        IQueryable<Author> All { get; }
    }
}