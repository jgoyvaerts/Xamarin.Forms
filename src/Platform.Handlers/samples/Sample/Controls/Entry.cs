using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Platform;

namespace Sample
{
	public class Entry : Xamarin.Forms.View, IEntry
	{
		public bool IsPassword { get; set; }

		public ReturnType ReturnType { get; set; } = ReturnType.Default;

		public ICommand ReturnCommand { get; set; }

		public object ReturnCommandParameter { get; set; }

		public int CursorPosition { get; set; }

		public int SelectionLength { get; set; }

		public bool IsTextPredictionEnabled { get; set; }

		public ClearButtonVisibility ClearButtonVisibility { get; set; } = ClearButtonVisibility.Never;

		public Keyboard Keyboard { get; set; } = Keyboard.Default;

		public bool IsSpellCheckEnabled { get; set; } = true;

		public int MaxLength { get; set; } = int.MaxValue;

		public string Placeholder { get; set; }

		public Color PlaceholderColor { get; set; }

		public bool IsReadOnly { get; set; }

		public string Text { get; set; }

		public Color TextColor { get; set; } = Color.Default;

		public TextTransform TextTransform { get; set; }

		public double CharacterSpacing { get; set; } = 0.0d;

		public FontAttributes FontAttributes { get; set; }

		public string FontFamily { get; set; }

		public double FontSize { get; set; }

		public Action Completed { get; set; }

		void IEntry.Completed()
		{
			Completed?.Invoke();
		}

		public new double Width
		{
			get { return WidthRequest; }
			set { WidthRequest = value; }
		}

		public new double Height
		{
			get { return HeightRequest; }
			set { HeightRequest = value; }
		}
	}
}