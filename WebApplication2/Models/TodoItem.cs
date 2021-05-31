﻿
namespace WebApplication2.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string MName { get; set; }
        public bool IsComplete { get; set; } = false;
        public string Secret { get; set; }
   

    }
    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string MName { get; set; }
        public bool IsComplete { get; set; } = false;
    }
}


