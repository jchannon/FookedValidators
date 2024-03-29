﻿using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace FookedValidators
{
    using Nancy;

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

        protected override void ConfigureApplicationContainer(TinyIoCContainer container)
        {
            base.ConfigureApplicationContainer(container);
        }

        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            AppDomainAssemblyTypeScanner.LoadAssemblies("DataLibrary");

            base.ApplicationStartup(container, pipelines);
        }
    }
}