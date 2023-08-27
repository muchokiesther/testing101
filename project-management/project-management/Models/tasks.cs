using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_management.Models
{
    public class tasks
    {
        [Key]
        public int TaskId { get; set; }
        public string TaskName { get; set; } = string.Empty;

    }
}
