using System;
using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using SoaDemo.Business.Repositories;
using SoaDemo.Services.Common.Interfaces;

namespace SoaDemo.Services
{
    public class UnityServiceHost : ServiceHost
    {
        public UnityServiceHost(IUnityContainer container, Type serviceType, params Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
            if (container == null)
            {
                throw new ArgumentException("container");
            }
            foreach (var contractDescription in ImplementedContracts.Values)
            {
                contractDescription.Behaviors.Add(new UnityInstanceProvider(container));
            }

        }
    }

    public class UnityInstanceProvider : IInstanceProvider, IContractBehavior
    {
        private readonly IUnityContainer _container;

        public UnityInstanceProvider(IUnityContainer container)
        {
            if (container == null)
            {
                throw new ArgumentException("container");
            }
            _container = container;
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return _container.Resolve(instanceContext.Host.Description.ServiceType);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return GetInstance(instanceContext);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance) { }

        public void Validate(ContractDescription contractDescription, ServiceEndpoint endpoint) { }

        public void ApplyDispatchBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, DispatchRuntime dispatchRuntime)
        {
            dispatchRuntime.InstanceProvider = this;
        }

        public void ApplyClientBehavior(ContractDescription contractDescription, ServiceEndpoint endpoint, ClientRuntime clientRuntime) { }

        public void AddBindingParameters(ContractDescription contractDescription, ServiceEndpoint endpoint, BindingParameterCollection bindingParameters) { }
    }

    public class UnityServiceHostFactory : ServiceHostFactory
    {
        private readonly IUnityContainer _container;

        public UnityServiceHostFactory()
        {
            _container = new UnityContainer();
            RegisterTypes(_container);
        }

        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new UnityServiceHost(_container, serviceType, baseAddresses);
        }

        private void RegisterTypes(IUnityContainer container)
        {
            // registration by configuration
            //var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //section.Configure(container);

            // registration by convention
            //container.RegisterTypes(
            //   AllClasses.FromAssembliesInBasePath(),
            //   WithMappings.FromMatchingInterface,
            //   WithName.Default,
            //   WithLifetime.ContainerControlled);

            // registration by code
            container.RegisterType<ICogRepository, CogRepository>();
        }
    }

}