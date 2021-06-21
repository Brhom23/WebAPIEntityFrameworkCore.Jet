using System.ComponentModel.DataAnnotations;
namespace WebAPIEntityFrameworkCoreJet.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string MName { get; set; }
        public bool IsComplete { get; set; } = false;
        [MaxLength(100)]
        public string Secret { get; set; }
   

    }
    public class TodoItemDTO
    {
        public int Id { get; set; }
        public string MName { get; set; }
        public bool IsComplete { get; set; } = false;
    }
}


