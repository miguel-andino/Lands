﻿namespace Lands
{
    using Xamarin.Forms;
    using Views;
    using ViewModels;
    using Helpers;

    public partial class App : Application
	{
        #region Properties
        #endregion

        #region Constructors
        public App()
        {
            InitializeComponent();

            if (Settings.IsRemembered == "true")
            {
                var mainViewModel = MainViewModel.GetInstance();
                mainViewModel.Token = Settings.Token;
                mainViewModel.TokenType = Settings.TokenType;
                mainViewModel.Lands = new LandsViewModel();
                Application.Current.MainPage = new MasterPage();
            }
            else
            {
                this.MainPage = new NavigationPage(new LoginPage());
            }
        }
        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        #endregion
    }
}
