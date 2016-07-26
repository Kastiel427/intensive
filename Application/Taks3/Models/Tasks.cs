
using System.ComponentModel.DataAnnotations;

namespace Taks1
{
    public class Tasks
    {
        public int TaksID { get; set; }

        [Required(ErrorMessage = "Укажите название задачи")]
        [MinLength(1, ErrorMessage = "Название не может быть пустым")]
        public string TaskName { get; set; }
        public string DeadLine { get; set; }
    }
}
