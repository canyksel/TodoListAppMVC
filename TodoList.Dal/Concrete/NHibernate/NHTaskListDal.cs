using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoList.Dal.Abstract;
using TodoList.Entities.Concrete;

namespace TodoList.Dal.Concrete.NHibernate
{
    public class NHTaskListDal : ITaskListDal
    {
        public void Add(TaskList taskItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int taskId)
        {
            throw new NotImplementedException();
        }

        public TaskList Get(int taskId)
        {
            throw new NotImplementedException();
        }

        public List<TaskList> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(TaskList taskItem)
        {
            throw new NotImplementedException();
        }
    }
}
