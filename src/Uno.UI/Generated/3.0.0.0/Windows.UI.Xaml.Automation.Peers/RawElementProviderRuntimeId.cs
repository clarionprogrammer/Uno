#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct RawElementProviderRuntimeId 
	{
		// Forced skipping of method Windows.UI.Xaml.Automation.Peers.RawElementProviderRuntimeId.RawElementProviderRuntimeId()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint Part1;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  uint Part2;
		#endif
	}
}
