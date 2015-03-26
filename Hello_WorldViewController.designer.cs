// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Hello_World
{
	[Register ("Hello_WorldViewController")]
	partial class Hello_WorldViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btn_Click { get; set; }

		[Action ("btn_Click_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btn_Click_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btn_Click != null) {
				btn_Click.Dispose ();
				btn_Click = null;
			}
		}
	}
}
