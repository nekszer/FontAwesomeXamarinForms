using FFImageLoading.Forms.Platform;
using Foundation;
using Rg.Plugins.Popup;
using UIKit;

namespace IconControl.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Popup.Init();
            CachedImageRenderer.Init();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            return base.FinishedLaunching(app, options);
        }
    }
}