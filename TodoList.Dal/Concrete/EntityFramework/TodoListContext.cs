using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Entities.Concrete;

namespace TodoList.Dal.Concrete.EntityFramework
{
    public class TodoListContext : DbContext
    {
        public DbSet<TaskList> TaskLists { get; set; }
    }
}
