#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Capture
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public   enum CameraCaptureUIPhotoFormat 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Jpeg,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		Png,
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		JpegXR,
		#endif
	}
	#endif
}
