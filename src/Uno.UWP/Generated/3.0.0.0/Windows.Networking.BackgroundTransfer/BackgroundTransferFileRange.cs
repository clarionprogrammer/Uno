#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.BackgroundTransfer
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial struct BackgroundTransferFileRange 
	{
		// Forced skipping of method Windows.Networking.BackgroundTransfer.BackgroundTransferFileRange.BackgroundTransferFileRange()
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong Offset;
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		public  ulong Length;
		#endif
	}
}
