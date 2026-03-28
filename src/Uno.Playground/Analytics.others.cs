#if !__WASM__

namespace Uno.UI.Demo
{
	static partial class Analytics
	{
		static partial void InnerReportPageView(string pageName, string? pageParam)
		{
			Microsoft.AppCenter.Analytics.Analytics.TrackEvent(
				"Navigate",
				new Dictionary<string, string> { 
					{ "PageName", pageName },
					{ "Arguments", arguments }
				}
			);
		}
	}
}
#endif