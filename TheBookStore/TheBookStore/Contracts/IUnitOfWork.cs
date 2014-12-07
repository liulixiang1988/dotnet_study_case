using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookStore.Contracts
{
    interface IUnitOfWork
    {
        void Commit();

        IBookRepository Books { get; set; }

        IAuthorRepository Authors { get; set; }

        IReviewRepository Reviews { get; set; }
    }
}
