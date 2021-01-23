/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class EdgeToEdgeUtil
	{
		// Fields
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
	
		// Properties
		public static float currentFooterMargin { get; }
		public static float currentHeaderMargin { get; }
	
		// Constructors
		public EdgeToEdgeUtil();
		static EdgeToEdgeUtil();
	
		// Methods
		public static Vector2 GetFullScreenSize(bool excludeXMargins = true);
		public static float GetNormalizedScreenHeight(bool excludeXMargins);
		public static float ConvertFovToMatchWidth(float currentFov, bool excludeXMargins);
		private static void CheckNoStatusBar();
		public static void CheckIPhoneX();
		public static bool IsLongDevice();
		public static bool IsIPhoneXSafeArea(PointerEventData eventData);
		public static bool IsIPhoneXSafeArea(float screenX, float screenY);
		public static bool IsIPhoneXSaveAreaTouched();
		public static bool IsIPhoneX();
		public static bool IsNoStatusBar();
		public static float GetIPhoneXFooterMargin();
		public static float GetIPhoneXHeaderMargin();
	}
}
