using System;
using UIKit;
using HelpshiftApi;

namespace XamNativeTest
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var btn1 = UIButton.FromType(UIButtonType.System);
            btn1.TranslatesAutoresizingMaskIntoConstraints = false;
            btn1.SetTitle("Show Conversation", UIControlState.Normal);

            btn1.TouchUpInside += (sender, e) => {
                //Helpshift.ShowConversation(this, null);
                HelpshiftSupport.ShowConversation(this, new System.Collections.Generic.Dictionary<string, object>());
            };

            var btn2 = UIButton.FromType(UIButtonType.System);
            btn2.TranslatesAutoresizingMaskIntoConstraints = false;
            btn2.SetTitle("Show FAQs", UIControlState.Normal);

            btn2.TouchUpInside += (sender, e) => {
                //Helpshift.ShowFAQs(this, null);
                HelpshiftSupport.ShowFAQs(this, new System.Collections.Generic.Dictionary<string, object>());
            };

            var stack = new UIStackView(new UIView[] { btn1, btn2 });
            stack.TranslatesAutoresizingMaskIntoConstraints = false;
            stack.Axis = UILayoutConstraintAxis.Vertical;
            stack.Alignment = UIStackViewAlignment.Center;
            View.AddSubview(stack);
            NSLayoutConstraint.ActivateConstraints(new NSLayoutConstraint[]
            {
                stack.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor),
                stack.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor)
            });
        }
    }
}
