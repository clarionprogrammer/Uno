#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Connectivity
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct NetworkUsageStates 
	{
		// Forced skipping of method Windows.Networking.Connectivity.NetworkUsageStates.NetworkUsageStates()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Networking.Connectivity.TriStates Roaming;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  global::Windows.Networking.Connectivity.TriStates Shared;
		#endif
	}
}
