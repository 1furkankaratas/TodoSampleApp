using DataAccess.Abstract;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTodoDal : EfEntityRepositoryBase<Todo, TodoContext>, ITodoDal
    {
        
    }
}
