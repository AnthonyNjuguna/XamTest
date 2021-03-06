﻿using System;
using UIKit;
//using WEPopover;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamTest.iOS.Common;
using XamTest.iOS.Views;
using XamTest.Views.Popover;
using CoreGraphics;

[assembly:ExportRenderer (typeof(PopoverPage), typeof(PopoverPageRenderer))]
namespace XamTest.iOS.Views
{
    public class PopoverPageRenderer : ViewRenderer<PopoverPage, UIView>
    {
        private PopoverPage _formsView;
        private Popover _popover;

        protected override void OnElementChanged(ElementChangedEventArgs<PopoverPage> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _formsView = e.NewElement;
                //_popover = new Popover() { ShouldDismiss = true };

                //_popover.PopoverClosed += DidDismissPopover;
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "ContentPage" || e.PropertyName == "Renderer")
            {
                Device.BeginInvokeOnMainThread (() => CreateContentViewController(Element?.ContentPage));
                return;
            }

            if(e.PropertyName == "SetPopoverVisible")
            {
                var pageViewController = UIApplication.SharedApplication.KeyWindow.RootViewController;

                //s_popover.PresentFromRect(new CoreGraphics.CGRect(_formsView.ShowFromPoint.X, _formsView.ShowFromPoint.Y, 1, 1), pageViewController.View, UIPopoverArrowDirection.Any, true);

                return;
            }
        }
            
        /*
        private void DidDismissPopover(WEPopoverController popover)
        {
            Console.WriteLine("DidDismissPopover");
        }
        */

        private void CreateContentViewController(Page page)
        {
            /*
            if(page == null)
            {
                _popover.ContentViewController = null;
                return;
            }

            try
            {
                _popover.ContentViewController = page.CreateViewController();

                _popover.ContentViewController.ContentSizeForViewInPopover = new CGSize(_formsView.PopoverWidth, _formsView.PopoverHeight);

                if (UIDevice.CurrentDevice.CheckSystemVersion (7, 0)) {
                    _popover.ContentViewController.PreferredContentSize = _popover.ContentViewController.ContentSizeForViewInPopover;
                }

            }
            catch (Exception ex)
            {
                _popover.ContentViewController = null;
                Console.WriteLine ("Error creating ContentViewController: " + ex.Message);
            }
            */
        }
    }
}