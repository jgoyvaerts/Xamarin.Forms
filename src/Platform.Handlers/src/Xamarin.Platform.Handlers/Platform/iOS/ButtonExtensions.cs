﻿using UIKit;
using Xamarin.Forms;

namespace Xamarin.Platform
{
	public static class ButtonExtensions
	{
		public static void UpdateText(this UIButton nativeButton, IButton button) =>
			nativeButton.SetTitle(button.Text, UIControlState.Normal);

		public static void UpdateTextColor(this UIButton nativeButton, IButton button)
			=> nativeButton.UpdateTextColor(button);

		public static void UpdateTextColor(this UIButton nativeButton, IButton button, UIColor? buttonTextColorDefaultNormal, UIColor? buttonTextColorDefaultHighlighted, UIColor? buttonTextColorDefaultDisabled)
		{
			if (button.TextColor == Color.Default)
			{
				nativeButton.SetTitleColor(buttonTextColorDefaultNormal, UIControlState.Normal);
				nativeButton.SetTitleColor(buttonTextColorDefaultHighlighted, UIControlState.Highlighted);
				nativeButton.SetTitleColor(buttonTextColorDefaultDisabled, UIControlState.Disabled);
			}
			else
			{
				var color = button.TextColor.ToNative();

				nativeButton.SetTitleColor(color, UIControlState.Normal);
				nativeButton.SetTitleColor(color, UIControlState.Highlighted);
				nativeButton.SetTitleColor(color, UIControlState.Disabled);

				nativeButton.TintColor = color;
			}
		}

		public static void UpdateFont(this UIButton nativeButton, IButton button)
		{

		}

		public static void UpdateCharacterSpacing(this UIButton nativeButton, IButton button)
		{

		}

		public static void UpdateCornerRadius(this UIButton nativeButton, IButton button)
		{
		
		}

		public static void UpdateBorderColor(this UIButton nativeButton, IButton button)
		{
			
		}

		public static void UpdateBorderWidth(this UIButton nativeButton, IButton button)
		{

		}

		public static void UpdateContentLayout(this UIButton nativeButton, IButton button)
		{

		}

		public static void UpdatePadding(this UIButton nativeButton, IButton button)
		{
	
		}
	}
}