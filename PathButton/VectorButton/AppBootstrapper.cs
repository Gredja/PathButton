
using System.Windows;
using Caliburn.Micro;
using VectorButton.ViewModel;

namespace VectorButton
{
    public class AppBootstrapper : BootstrapperBase
    {
        public AppBootstrapper()
        {
            var config = new TypeMappingConfiguration
            {
                DefaultSubNamespaceForViewModels = "ViewModels",
                DefaultSubNamespaceForViews = "Views"
            };
            ViewModelLocator.ConfigureTypeMappings(config);
            ViewLocator.ConfigureTypeMappings(config);

            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainWindowViewModel>();
        }
    }
}
