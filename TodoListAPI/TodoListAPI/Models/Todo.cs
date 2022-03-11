using System;

namespace TodoListAPI.Models
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}