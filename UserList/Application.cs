using Ninject;
using System;
using System.Windows.Forms;
using UserList.Models.Objects;
using UserList.Models.Repositories;
using UserList.Models.Validators;
using UserList.Presenters;
using UserList.Views;

namespace UserList
{
    internal sealed class Application
    {
        private readonly Lazy<IKernel> container;

        public Application()
        {
            container = new Lazy<IKernel>(CreateContainer);
        }

        private IKernel CreateContainer()
        {
            var container = new StandardKernel();

            container.Bind<ApplicationContext>().To<ApplicationContext>().InSingletonScope();
            container.Bind<IRepositoryProvider<User>>().To<RepositoryProvider>().InSingletonScope();
            container.Bind<IAuthenticationView>().To<AuthenticationView>().InSingletonScope();
            container.Bind<IRegistrationView>().To<RegistrationView>().InSingletonScope();
            container.Bind<IUserListView>().To<UserListView>().InSingletonScope();
            container.Bind<ILoginValidatorProvider, IRegistrationValidatorProvider>().To<ValidatorProvider>().InSingletonScope();
            container.Bind<IPresenter>().To<AuthenticationPresenter>().InSingletonScope();

            return container;
        }

        public void Run()
        {
            AuthenticationPresenter presenter = container.Value.Get<AuthenticationPresenter>();
            presenter.Run();
        }
    }
}