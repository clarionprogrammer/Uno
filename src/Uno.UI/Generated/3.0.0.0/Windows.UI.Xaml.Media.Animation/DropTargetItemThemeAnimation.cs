#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Media.Animation
{
	#if __ANDROID__ || __IOS__ || NET46 || __WASM__
	[global::Uno.NotImplemented]
	#endif
	public  partial class DropTargetItemThemeAnimation : global::Windows.UI.Xaml.Media.Animation.Timeline
	{
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public  string TargetName
		{
			get
			{
				return (string)this.GetValue(TargetNameProperty);
			}
			set
			{
				this.SetValue(TargetNameProperty, value);
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public static global::Windows.UI.Xaml.DependencyProperty TargetNameProperty { get; } = 
		Windows.UI.Xaml.DependencyProperty.Register(
			"TargetName", typeof(string), 
			typeof(global::Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation), 
			new FrameworkPropertyMetadata(default(string)));
		#endif
		#if __ANDROID__ || __IOS__ || NET46 || __WASM__
		[global::Uno.NotImplemented]
		public DropTargetItemThemeAnimation() : base()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation", "DropTargetItemThemeAnimation.DropTargetItemThemeAnimation()");
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation.DropTargetItemThemeAnimation()
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation.TargetName.get
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation.TargetName.set
		// Forced skipping of method Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation.TargetNameProperty.get
	}
}
