using Xamarin.Platform;

namespace Xamarin.Forms
{
	public partial class Entry : IEntry
	{
		void IEntry.Completed()
		{
			(this as IEntryController).SendCompleted();
		}
	}
}