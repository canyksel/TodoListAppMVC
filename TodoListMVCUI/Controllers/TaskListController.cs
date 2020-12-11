using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoList.Bll.Concrete;
using TodoList.Dal.Concrete.EntityFramework;
using TodoList.Entities.Concrete;
using TodoList.Interfaces;
using TodoListMVCUI.Models;

namespace TodoListMVCUI.Controllers
{
    public class TaskListController : Controller
    {
        // GET: TaskList
        private ITaskListService _taskListService;

        public TaskListController(ITaskListService taskListService)
        {
            _taskListService = taskListService;
        }

        public int PageSize = 8;

        public ActionResult Index(int page = 1)
        {
            List<TaskList> taskLists = _taskListService.GetAll();
            return View(new TaskListViewModel
            {
                TaskLists = taskLists.Skip((page - 1) * PageSize).Take(8).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = PageSize,
                    TotalItems = taskLists.Count,
                    CurrentPage = page
                }
            });
        }

        public ActionResult CreateNew()
        {
            return View(new TaskList());
        }

        [HttpPost]
        public ActionResult CreateNew(TaskList taskItem)
        {
            if (ModelState.IsValid)
            {
                _taskListService.Add(taskItem);
                return RedirectToAction("Index");
            }
            return View(taskItem);
        }

        public ActionResult Edit(int taskId)
        {
            TaskList taskItem = _taskListService.Get(taskId);
            return View(taskItem);
        }

        [HttpPost]
        public ActionResult Edit(TaskList taskItem)
        {
            if (ModelState.IsValid)
            {
                _taskListService.Update(taskItem);
                return RedirectToAction("Index");
            }
            return View(taskItem);
        }

        public ActionResult Delete(int taskId)
        {

            TaskList taskItem = _taskListService.Get(taskId);
            return View(taskItem);

        }

        [HttpPost]
        public ActionResult Delete(int taskId, TaskList taskItem)
        {
            if (ModelState.IsValid)
            {
                _taskListService.Delete(taskId);
                return RedirectToAction("Index");
            }
            return View(taskItem);
        }
    }
}