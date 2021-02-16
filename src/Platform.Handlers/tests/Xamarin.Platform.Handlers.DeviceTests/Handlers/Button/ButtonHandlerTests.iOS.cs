﻿using UIKit;
using Xamarin.Forms;

namespace Xamarin.Platform.Handlers.DeviceTests
{
	public partial class ButtonHandlerTests
	{
		UIButton GetNativeButton(ButtonHandler buttonHandler) =>
			(UIButton)buttonHandler.View;

		string GetNativeText(ButtonHandler buttonHandler) =>
			GetNativeButton(buttonHandler).CurrentTitle;

		Color GetNativeTextColor(ButtonHandler buttonHandler) =>
			GetNativeButton(buttonHandler).CurrentTitleColor.ToColor();
	}
}