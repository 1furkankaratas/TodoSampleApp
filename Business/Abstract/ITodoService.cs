using Core.Utilities.Results;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITodoService
    {
        IDataResult<List<Todo>> GetAll();
        IDataResult<Todo> GetById(int id);
        IResult Add(Todo todo);
        IResult Delete(Todo todo);
        IResult Update(Todo todo);


    }
}
