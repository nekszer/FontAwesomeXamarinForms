using LightForms;
using IconControl.ViewModels;
using IconControl.Views;

namespace IconControl
{
    public partial class App : LightFormsApplication
    {
        #region Initialize
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            InitializeComponent();
            Initialize<MainPage, MainViewModel>(AppRoutes.Main);
        }
        #endregion

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            base.OnSleep();
        }
    }
}