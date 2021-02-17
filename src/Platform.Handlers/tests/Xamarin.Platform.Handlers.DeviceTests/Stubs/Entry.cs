using System.Windows.Input;
using Xamarin.Forms;

namespace Xamarin.Platform.Handlers.DeviceTests.Stubs
{
	public partial class EntryStub : StubBase, IEntry
	{
		public bool IsPassword { get; set; }

		public ReturnType ReturnType { get; set; }

		public ICommand ReturnCommand { get; set; }

		public object ReturnCommandParameter { get; set; }

		public int CursorPosition { get; set; }

		public int SelectionLength { get; set; }

		public bool IsTextPredictionEnabled { get; set; }

		public ClearButtonVisibility ClearButtonVisibility { get; set; }

		public Keyboard Keyboard { get; set; }

		public bool IsSpellCheckEnabled { get; set; }

		public int MaxLength { get; set; }

		public string Placeholder { get; set; }

		public Color PlaceholderColor { get; set; }

		public bool IsReadOnly { get; set; }

		public string Text { get; set; }

		public Color TextColor { get; set; }

		public TextTransform TextTransform { get; set; }

		public double CharacterSpacing { get; set; }

		public FontAttributes FontAttributes { get; set; }

		public string FontFamily { get; set; }

		public double FontSize { get; set; }

		public TextAlignment HorizontalTextAlignment { get; set; }

		public TextAlignment VerticalTextAlignment { get; set; }

		public void Completed() { }
	}
}