using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModel: Module  //DI was made using autofac model

    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserForManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<ContentsManager>().As<IContentsService>();
            builder.RegisterType<EfContentsDal>().As<IContentsDal>();

            builder.RegisterType<UserContentsManager>().As<IUserContentsService>();
            builder.RegisterType<EfUserContentsDal>().As<IUserContentsDal>();
        }
    }
}
