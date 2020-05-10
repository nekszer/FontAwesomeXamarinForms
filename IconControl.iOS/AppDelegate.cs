using FFImageLoading.Forms.Platform;
using Foundation;
using LightForms;
using IconControl.iOS.Services;
using IconControl.Services;
using Rg.Plugins.Popup;
using UIKit;

namespace IconControl.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate, IPlatformInitializer
    {

        public LocalNotificationImplementation LocalNotification { get; private set; }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Popup.Init();
            CachedImageRenderer.Init();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new IconControl.App());
            LocalNotification?.OnLaunching(options);
            return base.FinishedLaunching(app, options);
        }

        public async void RegisterTypes(ICrossContainer container)
        {
            container.Register<ILocalNotification, LocalNotificationImplementation>(FetchTarget.Singleton);
            LocalNotification = container.Create<ILocalNotification>() as LocalNotificationImplementation;
            await LocalNotification.Init();
        }
    }
}