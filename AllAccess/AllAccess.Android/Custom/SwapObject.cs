using System;
namespace AllAccess.Droid.Custom
{
    public class SwapObject:Java.Lang.Object
    {
        public object Item { get; private set; }
        public Android.Views.View View { get; private set; }

        public SwapObject(Android.Views.View v, object i)
        {
            View = v;
            Item = i;
        }
    }
}
