#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Graphics.Holographic
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class HolographicFramePrediction 
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Graphics.Holographic.HolographicCameraPose> CameraPoses
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<HolographicCameraPose> HolographicFramePrediction.CameraPoses is not implemented in Uno.");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  global::Windows.Perception.PerceptionTimestamp Timestamp
		{
			get
			{
				throw new global::System.NotImplementedException("The member PerceptionTimestamp HolographicFramePrediction.Timestamp is not implemented in Uno.");
			}
		}
		#endif
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFramePrediction.CameraPoses.get
		// Forced skipping of method Windows.Graphics.Holographic.HolographicFramePrediction.Timestamp.get
	}
}
