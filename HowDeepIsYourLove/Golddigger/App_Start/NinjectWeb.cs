[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Golddigger.App_Start.NinjectWeb), "Start")]

namespace Golddigger.App_Start
{
    using Microsoft.Web.Infrastructure.DynamicModuleHelper;
    using Ninject.Web.Common;
    public static class NinjectWeb
    {
        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start()
        {
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
        }
    }
}