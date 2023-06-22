using Foundation;
using UIKit;
using HelpshiftApi;
using System.Collections.Generic;

namespace XamNativeTest
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register ("AppDelegate")]
    public class AppDelegate : UIResponder, IUIApplicationDelegate {
    
        [Export("window")]
        public UIWindow Window { get; set; }

        [Export ("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
        {
            Dictionary<string, object> config = new Dictionary<string, object>()
            {
                {"enableLogging", "true"}
            };
            //Helpshift.Install("gayatri_platform_20200925124520005-083e1cad798a089", "gayatri.helpshift.com", config);
            HelpshiftCore.Initialize(HelpshiftApiProviderType.HelpshiftApiProviderTypeSupport);
            var builder = new HelpshiftInstallConfig.Builder();
            builder.SetEnableLogging(true);
            HelpshiftCore.Install("e780dbb2a9c0eca1c32510e05736d7c1", "gayatri.helpshift.com", "gayatri_platform_20200925124520005-083e1cad798a089", builder.Build());
            return true;
        }

        // UISceneSession Lifecycle

        [Export ("application:configurationForConnectingSceneSession:options:")]
        public UISceneConfiguration GetConfiguration (UIApplication application, UISceneSession connectingSceneSession, UISceneConnectionOptions options)
        {
            // Called when a new scene session is being created.
            // Use this method to select a configuration to create the new scene with.
            return UISceneConfiguration.Create ("Default Configuration", connectingSceneSession.Role);
        }

        [Export ("application:didDiscardSceneSessions:")]
        public void DidDiscardSceneSessions (UIApplication application, NSSet<UISceneSession> sceneSessions)
        {
            // Called when the user discards a scene session.
            // If any sessions were discarded while the application was not running, this will be called shortly after `FinishedLaunching`.
            // Use this method to release any resources that were specific to the discarded scenes, as they will not return.
        }
    }
}
