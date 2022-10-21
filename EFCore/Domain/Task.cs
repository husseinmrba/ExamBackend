using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Domain
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime CreatedAt { get; set; }


        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();

    }
}
