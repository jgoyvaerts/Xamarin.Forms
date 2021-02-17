using Android.Text;
using Android.Widget;

namespace Xamarin.Platform
{
	public static class EntryExtensions
	{
		public static void UpdateText(this EditText editText, IEntry entry)
		{
			editText.Text = entry.Text;
		}

		public static void UpdateTextColor(this EditText editText, IEntry entry)
		{
			editText.UpdateTextColor(entry, null);
		}

		public static void UpdateTextColor(this EditText editText, IEntry entry, TextColorSwitcher? textColorSwitcher)
		{
			textColorSwitcher ??= new TextColorSwitcher(editText.TextColors);
			textColorSwitcher.UpdateTextColor(editText, entry.TextColor);
		}

		public static void UpdateFont(this EditText editText, IEntry entry)
		{

		}

		public static void UpdateTextTransform(this EditText editText, IEntry entry)
		{
			
		}

		public static void UpdateCharacterSpacing(this EditText editText, IEntry entry)
		{
	
		}

		public static void UpdatePlaceholder(this EditText editText, IEntry entry)
		{

		}

		public static void UpdatePlaceholderColor(this EditText editText, IEntry entry)
		{

		}

		public static void UpdateMaxLength(this EditText editText, IEntry entry)
		{

		}

		public static void UpdateIsReadOnly(this EditText editText, IEntry entry)
		{
	
		}

		public static void UpdateKeyboard(this EditText editText, IEntry entry)
		{
		
		}

		public static void UpdateIsSpellCheckEnabled(this EditText editText, IEntry entry)
		{
		
		}

		public static void UpdateHorizontalTextAlignment(this EditText editText, IEntry entry)
		{
		
		}

		public static void UpdateVerticalTextAlignment(this EditText editText, IEntry entry)
		{
	
		}

		public static void UpdateIsPassword(this EditText editText, IEntry entry)
		{
			editText.SetInputType(entry);
		}

		public static void UpdateReturnType(this EditText editText, IEntry entry)
		{
			
		}

		public static void UpdateCursorPosition(this EditText editText, IEntry entry)
		{
			
		}

		public static void UpdateSelectionLength(this EditText editText, IEntry entry)
		{
		
		}

		public static void UpdateIsTextPredictionEnabled(this EditText editText, IEntry entry)
		{
			
		}

		public static void UpdateClearButtonVisibility(this EditText editText, IEntry entry)
		{

		}

		internal static void SetInputType(this EditText editText, IEntry entry)
		{
			editText.InputType = InputTypes.ClassText;
			editText.InputType |= InputTypes.TextFlagMultiLine;

			if (entry.IsPassword && ((editText.InputType & InputTypes.ClassText) == InputTypes.ClassText))
				editText.InputType |= InputTypes.TextVariationPassword;

			if (entry.IsPassword && ((editText.InputType & InputTypes.ClassNumber) == InputTypes.ClassNumber))
				editText.InputType |= InputTypes.NumberVariationPassword;
		}
	}
}