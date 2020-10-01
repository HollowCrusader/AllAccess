using System;
using Android.Widget;
using System.Collections;
using AllAccess.Droid.Renderers;

namespace AllAccess.Droid.Custom
{
    public class ItemDragListener: Java.Lang.Object, Android.Views.View.IOnDragListener
    {
        Android.Views.View associatedView;

        public ItemDragListener(Android.Views.View view)
        {
            associatedView = view;
        }

        #region IOnDragListener implementation
        public bool OnDrag(Android.Views.View v, Android.Views.DragEvent e)
        {
            switch (e.Action)
            {
                case Android.Views.DragAction.Started:
                    break;
                case Android.Views.DragAction.Entered:
                    v.SetBackgroundColor(Android.Graphics.Color.Blue);
                    break;
                case Android.Views.DragAction.Exited:
                    v.SetBackgroundColor(Android.Graphics.Color.Transparent);
                    break;
                case Android.Views.DragAction.Drop:
                    v.SetBackgroundColor(Android.Graphics.Color.Transparent);
                    SwapObject tmpObj = (SwapObject)e.LocalState;
                    Android.Views.View view = tmpObj.View;
                    object passedItem = tmpObj.Item;
                    ListView oldParent = (ListView)view.Parent;
                    BaseAdapter sourceAdapter = (oldParent.Adapter is IWrapperListAdapter) ? ((IWrapperListAdapter)oldParent.Adapter).WrappedAdapter as BaseAdapter : ((BaseAdapter)oldParent.Adapter);


                    Console.WriteLine(v.Parent.Parent);
                    ListView newParent = (ListView)v.Parent.Parent;


                    BaseAdapter destinationAdapter = (oldParent.Adapter is IWrapperListAdapter) ? ((IWrapperListAdapter)newParent.Adapter).WrappedAdapter as BaseAdapter : ((BaseAdapter)oldParent.Adapter);


                    int removeLocation = oldParent.GetPositionForView(view);
                    int insertLocation = newParent.GetPositionForView(associatedView);


                    /*
                     * If drag and drop on the same list, same position, ignore
                     */
                    if (DragDropListRenderer.ListMap.ContainsKey(oldParent.Id.ToString()) && DragDropListRenderer.ListMap.ContainsKey(newParent.Id.ToString()))
                    {
                        var sourceList = (IList)DragDropListRenderer.ListMap[oldParent.Id.ToString()];
                        var destinationList = (IList)DragDropListRenderer.ListMap[newParent.Id.ToString()];
                        if (!oldParent.Equals(newParent) || removeLocation != insertLocation)
                        {
                            if (sourceList.Contains(passedItem))
                            {
                                //sourceList.Remove(passedItem);
                                destinationList.Insert(insertLocation, passedItem);
                                sourceList.Remove(passedItem);
                            }
                            destinationAdapter.NotifyDataSetChanged();
                            sourceAdapter.NotifyDataSetChanged();
                        }
                    }


                    break;
                case Android.Views.DragAction.Ended:
                    break;
            }
            return true;
        }
        #endregion
    }
}
