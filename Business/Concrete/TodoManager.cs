using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class TodoManager : ITodoService
    {
        private readonly ITodoDal _todoDal;

        public TodoManager(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }


        public IDataResult<List<Todo>> GetAll()
        {
            return new SuccessDataResult<List<Todo>>(_todoDal.GetAll(), Messages.TodoListed);
        }

        public IDataResult<Todo> GetById(int id)
        {
            return new SuccessDataResult<Todo>(_todoDal.Get(x => x.ID == id));
        }

        
        public IResult Add(Todo todo)
        {

            _todoDal.Add(todo);
            return new SuccessResult(Messages.TodoAdded);



        }

        public IResult Delete(Todo todo)
        {
            _todoDal.Delete(todo);
            return new SuccessResult(Messages.TodoDeleted);
        }

        public IResult Update(Todo todo)
        {
            _todoDal.Update(todo);
            return new SuccessResult(Messages.TodoUpdate);

        }


    }

}
