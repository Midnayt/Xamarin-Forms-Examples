using Android.App;
using Android.Content;
using Android.Glide;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Bumptech.Glide;
using Bumptech.Glide.Load;
using Bumptech.Glide.Load.Resource.Bitmap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace XFSamples.Droid.Helpers
{
    public class GlideHandler : IGlideHandler
    {
        public bool Build(ImageView imageView, ImageSource source, RequestBuilder builder, CancellationToken token)
        {
            if (builder != null)
            {
                var t = Glide.With(imageView).Load("https://www.telegraph.co.uk/content/dam/news/2016/09/08/107667228_beech-tree-NEWS_trans_NvBQzQNjv4BqplGOf-dgG3z4gg9owgQTXEmhb5tXCQRHAvHRWfzHzHk.jpg");
                builder.Placeholder(Resource.Drawable.abc_text_cursor_material).Thumbnail(t).Into(imageView);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}