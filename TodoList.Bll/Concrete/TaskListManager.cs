using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Dal.Abstract;
using TodoList.Entities.Concrete;
using TodoList.Interfaces;

namespace TodoList.Bll.Concrete
{
    public class TaskListManager : ITaskListService
    {
        //Instance Provider ile ezilecek.
        private ITaskListDal _taskListDal;

        public TaskListManager(ITaskListDal taskListDal)
        {
            _taskListDal = taskListDal;
        }

        public void Add(TaskList taskItem)
        {
            _taskListDal.Add(taskItem);
        }

        public void Delete(int taskId)
        {
            _taskListDal.Delete(taskId);
        }

        public TaskList Get(int taskId)
        {
            return _taskListDal.Get(taskId);
        }

        public List<TaskList> GetAll()
        {
            return _taskListDal.GetAll();
        }

        public void Update(TaskList taskItem)
        {
            _taskListDal.Update(taskItem);
        }
    }
}
