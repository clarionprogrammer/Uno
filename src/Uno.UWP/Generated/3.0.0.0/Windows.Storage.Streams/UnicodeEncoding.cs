#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Storage.Streams
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum UnicodeEncoding 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Utf8,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Utf16LE,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Utf16BE,
		#endif
	}
	#endif
}
