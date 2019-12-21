using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using System;
using System.IO;
using System.Reflection;
using UdemyXamarin.CustomControls;
using UdemyXamarin.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CircularImage), typeof(CustomImageRenderer))]
namespace UdemyXamarin.Droid.CustomRenderer
{
    public class CustomImageRenderer : ImageRenderer
    {
        public CustomImageRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
        {
            base.OnElementChanged(e);
            
            if(Control != null)
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(typeof(UdemyXamarin.EmbeddedResource.EmbeddedImage)).Assembly;
                var stream = assembly.GetManifestResourceStream("UdemyXamarin.Images.background.jpg");
                
                var img = BitmapFactory.DecodeStream(stream);
                var output = Bitmap.CreateBitmap(img.Height/2, img.Height/2, Bitmap.Config.Argb8888);
                var canvas = new Canvas(output);

                var paint = new Paint();
                var rect = new Rect(0, 0, img.Height/2, img.Height/2);
                var rectF = new RectF(rect);
                var roundPx = img.Height/2;

                paint.AntiAlias = true;
                canvas.DrawARGB(0, 0, 0, 0);
                canvas.DrawRoundRect(rectF, roundPx, roundPx, paint);

                paint.SetXfermode(new PorterDuffXfermode(PorterDuff.Mode.SrcIn));
                canvas.DrawBitmap(img, rect, rect, paint);

                Control.SetScaleType(Android.Widget.ImageView.ScaleType.FitCenter);
                Control.SetImageBitmap(output);
            }
        }
    }
}
