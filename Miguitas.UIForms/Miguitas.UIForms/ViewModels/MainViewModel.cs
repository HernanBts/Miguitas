namespace Miguitas.UIForms.ViewModels
{
    using Miguitas.Common.Models;
    public class MainViewModel
    {
        private static MainViewModel instance;

        public LoginViewModel Login { get; set; }

        public TokenResponse Token { get; set; }

        public ProductsViewModel Products { get; set; }

        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
    }

}
