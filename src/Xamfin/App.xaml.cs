using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamfin.Services;
using Xamfin.Views;
using Xamfin.Controls;
using Xamfin.PageModels;
using BottomBar.XamarinForms;
namespace Xamfin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
            {
                var tabs = new FreshMvvm.FreshTabbedNavigationContainer() { BarTextColor = Color.White, BarBackgroundColor = Color.Black };

                tabs.AddTab<MainPageModel>("Home", "icon_home.png");
                tabs.AddTab<EmptyPageModel>("Browse", "icon_browse.png");
                tabs.AddTab<EmptyPageModel>("Search", "icon_search.png");
                tabs.AddTab<EmptyPageModel>("Radio", "icon_radio.png");
                tabs.AddTab<EmptyPageModel>("Your Library", "icon_library.png");

                MainPage = tabs;
            }
            else
            {
                var bottomBarPage = new CustomNavigation() { BarTextColor = Color.White, BarBackgroundColor = Color.Black };

                bottomBarPage.FixedMode = true;
                bottomBarPage.BarTheme = BottomBarPage.BarThemeTypes.DarkWithoutAlpha;
                bottomBarPage.BarTextColor = Color.White;

                bottomBarPage.AddTab<MainPageModel>("Home", "icon_home.png");
                bottomBarPage.AddTab<EmptyPageModel>("Browse", "icon_browse.png");
                bottomBarPage.AddTab<EmptyPageModel>("Search", "icon_search.png");
                bottomBarPage.AddTab<EmptyPageModel>("Radio", "icon_radio.png");
                bottomBarPage.AddTab<EmptyPageModel>("Your Library", "icon_library.png");

                MainPage = bottomBarPage;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
