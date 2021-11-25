using UnityEngine;
using UnityEngine.EventSystems;

namespace Gluon
{
	public class EdgeToEdgeUtil
	{
		private static bool isIPhoneXCheckDone;

		private static bool isIPhoneX;

		public static float iPhoneXFooterMargin;

		public static float iPhoneXHeaderMargin;

		public static float iPhoneXRawScreenWidth;

		public static float iPhoneXRawScreenHeight;

		private const float BaseAspectRatio = 0.5625f;

		public static float iPhoneXNormalizedHeight;

		public static float iPhoneXNormalizedHeightWithBleeding;

		public static float NoStatusBarHeaderMargin;

		public static float NoStatusBarFooterMargin;

		private static bool isNoStatusBar;

		private static bool isNoStatusBarCheckDone;

		public static float currentFooterMargin => default(float);

		public static float currentHeaderMargin => default(float);

		public static Vector2 GetFullScreenSize(bool excludeXMargins = true)
		{
			return default(Vector2);
		}

		public static float GetNormalizedScreenHeight(bool excludeXMargins)
		{
			return default(float);
		}

		public static float ConvertFovToMatchWidth(float currentFov, bool excludeXMargins)
		{
			return default(float);
		}

		private static void CheckNoStatusBar()
		{
		}

		public static void CheckIPhoneX()
		{
		}

		public static bool IsLongDevice()
		{
			return default(bool);
		}

		public static bool IsIPhoneXSafeArea(PointerEventData eventData)
		{
			return default(bool);
		}

		public static bool IsIPhoneXSafeArea(float screenX, float screenY)
		{
			return default(bool);
		}

		public static bool IsIPhoneXSaveAreaTouched()
		{
			return default(bool);
		}

		public static bool IsIPhoneX()
		{
			return default(bool);
		}

		public static bool IsNoStatusBar()
		{
			return default(bool);
		}

		public static float GetIPhoneXFooterMargin()
		{
			return default(float);
		}

		public static float GetIPhoneXHeaderMargin()
		{
			return default(float);
		}
	}
}
