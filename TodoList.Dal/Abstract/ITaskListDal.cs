using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Entities.Concrete;

namespace TodoList.Dal.Abstract
{
    public interface ITaskListDal
    {
        List<TaskList> GetAll();
        TaskList Get(int taskId);
        void Add(TaskList taskItem);
        void Delete(int taskId);
        void Update(TaskList taskItem);
    }
}
