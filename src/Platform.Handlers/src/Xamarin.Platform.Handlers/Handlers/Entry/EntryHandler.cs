namespace Xamarin.Platform.Handlers
{
	public partial class EntryHandler
	{
		public static PropertyMapper<IEntry, EntryHandler> EntryMapper = new PropertyMapper<IEntry, EntryHandler>(ViewHandler.ViewMapper)
		{
			[nameof(IText.Text)] = MapText,
			[nameof(IText.TextColor)] = MapTextColor,
			[nameof(IText.TextTransform)] = MapTextTransform,
			[nameof(IText.CharacterSpacing)] = MapCharacterSpacing,

			[nameof(ITextInput.Placeholder)] = MapPlaceholder,
			[nameof(ITextInput.PlaceholderColor)] = MapPlaceholderColor,
			[nameof(ITextInput.MaxLength)] = MapMaxLength,
			[nameof(ITextInput.IsReadOnly)] = MapIsReadOnly,
			[nameof(ITextInput.Keyboard)] = MapKeyboard,
			[nameof(ITextInput.IsSpellCheckEnabled)] = MapIsSpellCheckEnabled,

			[nameof(ITextAlignment.HorizontalTextAlignment)] = MapHorizontalTextAlignment,
			[nameof(ITextAlignment.VerticalTextAlignment)] = MapVerticalTextAlignment,

			[nameof(IFont.FontSize)] = MapFont,
			[nameof(IFont.FontAttributes)] = MapFont,

			[nameof(IEntry.IsPassword)] = MapIsPassword,
			[nameof(IEntry.ReturnType)] = MapReturnType,
			[nameof(IEntry.CursorPosition)] = MapCursorPosition,
			[nameof(IEntry.SelectionLength)] = MapSelectionLength,
			[nameof(IEntry.IsTextPredictionEnabled)] = MapIsTextPredictionEnabled,
			[nameof(IEntry.ClearButtonVisibility)] = MapClearButtonVisibility
		};
				
		public EntryHandler() : base(EntryMapper)
		{

		}

		public EntryHandler(PropertyMapper mapper) : base(mapper ?? EntryMapper)
		{

		}
	}
}
