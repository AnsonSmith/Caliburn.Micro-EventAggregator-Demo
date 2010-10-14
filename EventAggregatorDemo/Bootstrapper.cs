using Caliburn.Micro;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Collections;
using EventAggregatorDemo.ViewModels;

namespace EventAggregatorDemo
{
    public class Bootstrapper : Caliburn.Micro.Bootstrapper<ShellViewModel>
    {
        public Bootstrapper()
        {
            ObjectFactory.Initialize(x =>
            {
                x.For<ShellViewModel>().Singleton().Use<ShellViewModel>();

                x.For<IWindowManager>().Singleton().Use<WindowManager>();
                x.For<IEventAggregator>().Singleton().Use<EventAggregator>();


            });
            //ObjectFactory.AssertConfigurationIsValid();

        }

        protected override object GetInstance(Type serviceType, string key)
        {

            return String.IsNullOrEmpty(key) ? ObjectFactory.Container.GetInstance(serviceType) : ObjectFactory.Container.GetInstance(serviceType, key);



        }

        protected override IEnumerable<object> GetAllInstances(Type serviceType)
        {
            return ObjectFactory.Container.GetAllInstances(serviceType).AsEnumerable();
        }

        protected override void BuildUp(object instance)
        {
            ObjectFactory.Container.BuildUp(instance);
        }
    }
}
