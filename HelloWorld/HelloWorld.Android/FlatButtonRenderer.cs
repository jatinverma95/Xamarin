using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(HelloWorld.Droid.FlatButtonRenderer))]
namespace HelloWorld.Droid
{
    public class FlatButtonRenderer : ButtonRenderer
    {
        protected override void OnDraw(Android.Graphics.Canvas canvas)
        {
            base.OnDraw(canvas);
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            this.Control.SetAllCaps(false);
        }
    }
}