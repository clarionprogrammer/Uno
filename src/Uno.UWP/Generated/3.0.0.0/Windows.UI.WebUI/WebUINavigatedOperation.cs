#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.WebUI
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class WebUINavigatedOperation 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.UI.WebUI.WebUINavigatedDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member WebUINavigatedDeferral WebUINavigatedOperation.GetDeferral() is not implemented in Uno.");
		}
		#endif
	}
}
