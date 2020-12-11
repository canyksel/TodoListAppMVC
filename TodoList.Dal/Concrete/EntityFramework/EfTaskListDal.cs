using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Dal.Abstract;
using TodoList.Entities.Concrete;

namespace TodoList.Dal.Concrete.EntityFramework
{
    public class EfTaskListDal : ITaskListDal
    {
        //private TodoListContext _context = new TodoListContext();
        public readonly TodoListContext _context = new TodoListContext();

        public void Add(TaskList taskItem)
        {
            _context.TaskLists.Add(taskItem);
            _context.SaveChanges();
        }

        public void Delete(int taskId)
        {
            _context.TaskLists.Remove(_context.TaskLists.FirstOrDefault(t => t.TaskId == taskId));
            _context.SaveChanges();
        }

        public TaskList Get(int taskId)
        {
            return _context.TaskLists.FirstOrDefault(t => t.TaskId == taskId);
        }

        public List<TaskList> GetAll()
        {
            return _context.TaskLists.ToList();
        }

        public void Update(TaskList taskItem)
        {
            TaskList taskToUpdate = _context.TaskLists.FirstOrDefault(t => t.TaskId == taskItem.TaskId);
            taskToUpdate.CreatorName = taskItem.CreatorName;
            taskToUpdate.TaskDescription = taskItem.TaskDescription;
            taskToUpdate.IsComplete = taskItem.IsComplete;
            taskToUpdate.CreateTime = taskItem.CreateTime;
            taskToUpdate.TaskTime = taskItem.TaskTime;

            _context.SaveChanges();
        }
    }
}
