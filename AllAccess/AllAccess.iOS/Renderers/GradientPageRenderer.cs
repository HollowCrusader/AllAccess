using AllAccess.Controls;
using System;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using AllAccess.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.Linq;
using AllAccess.iOS.Renderers;

[assembly:ExportRenderer(typeof(GradientPage), typeof(GradientPageRenderer))]
namespace AllAccess.iOS.Renderers
{
    public class GradientPageRenderer:PageRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null) // perform initial setup
            {
                var page = e.NewElement as GradientPage;
                var gradientLayer = new CAGradientLayer();
                gradientLayer.Frame = View.Bounds;
                gradientLayer.Colors = new CGColor[] { page.StartColor.ToCGColor(), page.EndColor.ToCGColor() };
                View.Layer.InsertSublayer(gradientLayer, 0);
            }
        }
    }
}
