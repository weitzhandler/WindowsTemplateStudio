﻿//{**
//Test documentation
//**}

using Windows.UI.Xaml.Navigation;
//{[{
//USING
//}]}
namespace TestData
{
    sealed partial class App : Application
    {
        //{--{
        //THIS COMMENT SHOULD BE REMOVED
        //}--}

        //{[{
        //PROPERTY DEFINITION
        //}]}

        public App()
        {
            this.InitializeComponent();
            //{[{
            //AFTER INITIALIZE!!
            //}]}
        }

        protected override async void OnLaunched(LaunchActivatedEventArgs e)
        {
            //{[{

            //AFTER ONLAUNCHED!!
            //}]}
            Settings.SettingsViewModel.InitAppTheme();

            //^^
            //{[{
            //BEFORE END!!
            var s = "";

            //}]}
        }

        //{[{
        private static void ThisIsANewMethod()
        {
            //INSIDE NEW METHOD!!
        }
        //}]}

        protected override void OnActivated(IActivatedEventArgs args)
        {
            if (args.Kind == ActivationKind.ToastNotification)
            {
                //{[{
                //INSIDE IF!!
                //}]}
            }
        }

        //{[{
        private static void ThisIsAnExistingMethod()
        {
        }
        //}]}
    }
}
