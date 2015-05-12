using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Moq;
using GameStore.Domain.Abstract;
using GameStore.Domain.Entities;
using GameStore.Domain.Concreate;

namespace GameStore.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory 
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {

            return controllerType == null? null: (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
             ninjectKernel.Bind<IGameRepository>().To<EFProductRepository>();
        } 
    }
}