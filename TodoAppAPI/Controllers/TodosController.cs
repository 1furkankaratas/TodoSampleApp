using System;
using System.Linq;
using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using Entities.Enums;
using Microsoft.AspNetCore.Mvc;

namespace TodoAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private ITodoService _todoService;

        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _todoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _todoService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Todo todo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            todo.CreatedDate = DateTime.Now;
            var result = _todoService.Add(todo);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }


        [HttpPost("delete")]
        public IActionResult Delete(DeleteTodo deleteTodo)
        {
            Todo todo = new Todo {ID = deleteTodo.Id};
            var result = _todoService.Delete(todo);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }



        [HttpPost("update")]
        public IActionResult Update(Todo todo)
        {
            var data = _todoService.GetById(todo.ID);

            todo.CreatedDate = data.Data.CreatedDate;

            var result = _todoService.Update(todo);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getstatus")]
        public IActionResult GetStatus()
        {
            return Ok(EnumExtensions.GetValues<TodoStatus>());
        }
    }
}
