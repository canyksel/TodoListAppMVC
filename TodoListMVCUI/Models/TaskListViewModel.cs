using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TodoList.Entities.Concrete;

namespace TodoListMVCUI.Models
{
    public class TaskListViewModel
    {
        public List<TaskList> TaskLists { get; internal set; }
        public PagingInfo PagingInfo { get; internal set; }
    }
}