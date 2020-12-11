using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Bll.Concrete;
using TodoList.Dal.Concrete.EntityFramework;
using TodoList.Entities.Concrete;
using TodoList.Interfaces;

namespace TodoList.Library.Concrete
{
    public class TaskListService : ITaskListService
    {
        private TaskListManager _taskListManager = new TaskListManager(new EfTaskListDal());

        public void Add(TaskList taskItem)
        {
            _taskListManager.Add(taskItem);
        }

        public void Delete(int taskId)
        {
            _taskListManager.Delete(taskId);
        }

        public TaskList Get(int taskId)
        {
            return _taskListManager.Get(taskId);
        }

        public List<TaskList> GetAll()
        {
            return _taskListManager.GetAll();
        }

        public void Update(TaskList taskItem)
        {
            _taskListManager.Update(taskItem);
        }
    }
}
