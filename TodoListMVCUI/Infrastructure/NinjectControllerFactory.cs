using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TodoList.Bll.Concrete;
using TodoList.Dal.Concrete.EntityFramework;
using TodoList.Interfaces;

namespace TodoListMVCUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBllDindings();
        }

        private void AddBllDindings()
        {
            _ninjectKernel.Bind<ITaskListService>().To<TaskListManager>().WithConstructorArgument("taskListDal",new EfTaskListDal());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }

    }
}