using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoApp.Helpers
{
    public static class Animate
	{
		public static Task<bool> ColorTo(this VisualElement self, Color fromColor, Color toColor, Action<Color> callback, uint length = 250, Easing easing = null)
		{
			Func<double, Color> transform = (t) =>
				Color.FromRgba(fromColor.R + t * (toColor.R - fromColor.R),
							   fromColor.G + t * (toColor.G - fromColor.G),
							   fromColor.B + t * (toColor.B - fromColor.B),
							   fromColor.A + t * (toColor.A - fromColor.A));
			return ColorAnimation(self, "ColorTo", transform, callback, length, easing);
		}

		public static void CancelAnimation(this VisualElement self)
		{
			self.AbortAnimation("ColorTo");
		}

		static Task<bool> ColorAnimation(VisualElement element, string name, Func<double, Color> transform, Action<Color> callback, uint length, Easing easing)
		{
			easing = easing ?? Easing.Linear;
			var taskCompletionSource = new TaskCompletionSource<bool>();

			element.Animate<Color>(name, transform, callback, 16, length, easing, (v, c) => taskCompletionSource.SetResult(c));
			return taskCompletionSource.Task;
		}

		public static async Task BallAnimate(View view, int Top, int reduce, int time)
		{
			
			await view.RelRotateTo(360, 1000);
		
			do
			{
				await view.TranslateTo(view.TranslationX, view.TranslationY - Top, 500, Easing.CubicOut);

				await view.TranslateTo(view.TranslationX, view.TranslationY + Top, 300, Easing.CubicIn);

				Top = Top - reduce;
				time--;
			} while (time != 0);

			/*
            await view.TranslateTo(view.TranslationX, view.TranslationY - 50, 500, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 50, 300, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY - 20, 300, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 20, 150, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY - 10, 150, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 10, 100, Easing.Linear);

            await view.FadeTo(-0, 1000);
            */
		}
	}
}
