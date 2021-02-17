using Android.Widget;

namespace Xamarin.Platform.Handlers
{
	public partial class EntryHandler : AbstractViewHandler<IEntry, EditText>
	{
		static TextColorSwitcher? TextColorSwitcher { get; set; }

		protected override EditText CreateNativeView()
		{
			return new EditText(Context);
		}

		protected override void SetupDefaults(EditText nativeView)
		{
			base.SetupDefaults(nativeView);

			TextColorSwitcher = new TextColorSwitcher(nativeView.TextColors);
		}

		public static void MapText(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateText(entry);
		}

		public static void MapTextColor(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateTextColor(entry, TextColorSwitcher);
		}

		public static void MapFont(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateFont(entry);
		}

		public static void MapTextTransform(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateTextTransform(entry);
		}

		public static void MapCharacterSpacing(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateCharacterSpacing(entry);
		}

		public static void MapPlaceholder(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdatePlaceholder(entry);
		}

		public static void MapPlaceholderColor(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdatePlaceholderColor(entry);
		}

		public static void MapMaxLength(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateMaxLength(entry);
		}

		public static void MapIsReadOnly(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateIsReadOnly(entry);
		}

		public static void MapKeyboard(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateKeyboard(entry);
		}

		public static void MapIsSpellCheckEnabled(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateIsSpellCheckEnabled(entry);
		}

		public static void MapHorizontalTextAlignment(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateHorizontalTextAlignment(entry);
		}

		public static void MapVerticalTextAlignment(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateVerticalTextAlignment(entry);
		}

		public static void MapIsPassword(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateIsPassword(entry);
		}

		public static void MapReturnType(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateReturnType(entry);
		}

		public static void MapCursorPosition(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateCursorPosition(entry);
		}

		public static void MapSelectionLength(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateSelectionLength(entry);
		}

		public static void MapIsTextPredictionEnabled(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateIsTextPredictionEnabled(entry);
		}

		public static void MapClearButtonVisibility(EntryHandler handler, IEntry entry)
		{
			ViewHandler.CheckParameters(handler, entry);

			handler.TypedNativeView?.UpdateClearButtonVisibility(entry);
		}
	}
}