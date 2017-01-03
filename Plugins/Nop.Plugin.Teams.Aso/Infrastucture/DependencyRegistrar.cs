using Autofac;
using Autofac.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Teams.Aso.Data;
using Nop.Web.Framework.Mvc;

namespace Nop.Plugin.Teams.Aso.Infrastucture
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        private const string CONTEXT_NAME = "nop_object_context_product_view_tracker";

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            //data context
            this.RegisterPluginDataContext<FieldWordRecordContext>(builder, CONTEXT_NAME);

            //override required repository with our custom context
            builder.RegisterType<EfRepository<FieldWorkRecord>>()
                .As<IRepository<FieldWorkRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
                .InstancePerLifetimeScope();

            builder.RegisterType<EfRepository<DownLoadRecord>>()
              .As<IRepository<DownLoadRecord>>()
              .WithParameter(ResolvedParameter.ForNamed<IDbContext>(CONTEXT_NAME))
              .InstancePerLifetimeScope();
        }

        public int Order
        {
            get { return 1; }
        }
    }
}