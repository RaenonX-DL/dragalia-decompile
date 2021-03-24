/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.LoginBonus
{
	public static class Constants
	{
		// Fields
		public const string popupPrefabPath = "Prefabs/OutGame/LoginBonus/LoginBonusPopup";
		public const string charaRootPrefabPath = "Prefabs/OutGame/LoginBonus/LoginBonusCharaRoot";
		public const string unitShaderSettingPath = "Prefabs/OutGame/LoginBonus/LoginBonusUnitShaderSettings";
		public static readonly float[] UIPlaneDistance;
		private static readonly string[] _flashResourcePaths;
	
		// Nested types
		public enum UIPlaneKind
		{
			Back = 0,
			Middle = 1,
			Front = 2,
			Nof = 3
		}
	
		public enum FlashResourceKind
		{
			GetIcon = 0,
			TodayStamp = 1,
			TomorrowStamp = 2,
			TitleBoard = 3,
			Nof = 4
		}
	
		// Constructors
		static Constants();
	
		// Methods
		public static string getFlashResourcePaths(int kindIndex);
	}
}
