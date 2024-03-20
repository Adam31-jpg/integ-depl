using System.ComponentModel.DataAnnotations;

namespace ProbabilityX_API.Models
{
    public class TodoModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    
    }

}
