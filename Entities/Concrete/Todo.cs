using System;
using Core.Entities;
using Entities.Enums;

namespace Entities.Concrete
{
    public class Todo : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public TodoStatus Status { get; set; }
    }
}
