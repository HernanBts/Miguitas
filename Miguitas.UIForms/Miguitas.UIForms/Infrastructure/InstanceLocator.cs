namespace Miguitas.UIForms.Infrastructure
{
    using Miguitas.UIForms.ViewModels;

    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
    }

}
