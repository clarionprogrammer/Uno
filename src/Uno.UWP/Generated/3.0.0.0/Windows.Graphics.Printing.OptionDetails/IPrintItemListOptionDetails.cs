#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Printing.OptionDetails
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial interface IPrintItemListOptionDetails : global::Windows.Graphics.Printing.OptionDetails.IPrintOptionDetails
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		global::System.Collections.Generic.IReadOnlyList<object> Items
		{
			get;
		}
		#endif
		// Forced skipping of method Windows.Graphics.Printing.OptionDetails.IPrintItemListOptionDetails.Items.get
	}
}
