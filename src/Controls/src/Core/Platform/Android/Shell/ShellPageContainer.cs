using Android.Content;
using Microsoft.Maui.Graphics;
using AView = Android.Views.View;

namespace Microsoft.Maui.Controls.Platform
{
	internal class ShellPageContainer : PageContainer
	{
		public ShellPageContainer(Context context, IViewHandler child, bool inFragment = false) : base(context, child, inFragment)
		{
		}

		protected override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			var width = r - l;
			var height = b - t;

			if (changed && Child.NativeView is AView aView)
				aView.Layout(0, 0, width, height);
		}
	}
}