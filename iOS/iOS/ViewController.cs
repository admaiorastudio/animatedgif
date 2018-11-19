using CoreGraphics;
using Foundation;
using SDWebImage;
using System;
using UIKit;

namespace iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) 
            : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            nfloat centerX = this.View.Center.X - 100;
            nfloat centerY = this.View.Center.Y - 100;

            FLAnimatedImage animatedImage = FLAnimatedImage.AnimatedImageWithGIFData(
                NSData.FromFile(NSBundle.MainBundle.PathForResource("gattino", "gif")));

            FLAnimatedImageView imageView = new FLAnimatedImageView();
            imageView.AnimatedImage = animatedImage;
            imageView.Frame = new CGRect(centerX, centerY, 200, 200);

            this.View.AddSubview(imageView);

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}