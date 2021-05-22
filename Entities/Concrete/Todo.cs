using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Entities.Enums;

namespace Entities.Concrete
{
    public class Todo : IEntity
    {
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        [EnumDataType(typeof(TodoStatus))]
        [Required]
        public int Status { get; set; }
    }
}
