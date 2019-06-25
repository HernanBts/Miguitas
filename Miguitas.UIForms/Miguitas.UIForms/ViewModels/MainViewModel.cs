namespace Miguitas.UIForms.ViewModels
{
    using Miguitas.Common.Models;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    public class MainViewModel
    {
        private static MainViewModel instance;

        public LoginViewModel Login { get; set; }

        public TokenResponse Token { get; set; }

        public ProductsViewModel Products { get; set; }

        public ObservableCollection<MenuItemViewModel> Menus { get; set; }

        //public MainViewModel()
        //{
        //    instance = this;
        //    this.Login = new LoginViewModel();
        //}

        public MainViewModel()
        {
            instance = this;
            this.LoadMenus();
        }

        private void LoadMenus()
        {
            var menus = new List<Menu>
            {
                new Menu
                {
                    Icon = "ic_info_outline",
                    PageName = "AboutPage",
                    Title = "About"
                },

                new Menu
                {
                    Icon = "ic_settings",
                    PageName = "SetupPage",
                    Title = "Setup"
                },

                new Menu
                {
                    Icon = "ic_exit_to_app",
                    PageName = "LoginPage",
                    Title = "Close session"
                }
            };

            this.Menus = new ObservableCollection<MenuItemViewModel>(menus.Select(m => new MenuItemViewModel
            {
                Icon = m.Icon,
                PageName = m.PageName,
                Title = m.Title
            }).ToList());
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
