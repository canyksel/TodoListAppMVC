using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TodoList.Entities.Concrete;

namespace TodoList.Interfaces
{
    [ServiceContract]
    public interface ITaskListService
    {
        [OperationContract]
        List<TaskList> GetAll();
        [OperationContract]

        TaskList Get(int taskId);
        [OperationContract]

        void Add(TaskList taskItem);
        [OperationContract]

        void Delete(int taskId);
        [OperationContract]

        void Update(TaskList taskItem);
    }
}
