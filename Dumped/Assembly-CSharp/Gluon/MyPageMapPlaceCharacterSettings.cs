/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageMapPlaceCharacterSettings : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private List<IgnorePlaceCharacterSetting> ignorePlaceCharacterTable;
	
		// Nested types
		[Serializable]
		private class IgnorePlaceCharacterSetting
		{
			// Fields
			[Tooltip]
			public IgnorePlaceMapModeFlags mapMode;
			[Tooltip]
			public List<int> characterIdList;
	
			// Constructors
			public IgnorePlaceCharacterSetting();
		}
	
		[Flags]
		public enum IgnorePlaceMapModeFlags
		{
			Sit = 1,
			Drink = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public IgnorePlaceMapModeFlags flag;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal bool _IsIgnorePlaceCharacter_b__0(IgnorePlaceCharacterSetting ignorePlaceCharacterSetting);
		}
	
		// Constructors
		public MyPageMapPlaceCharacterSettings();
	
		// Methods
		public bool IsIgnorePlaceCharacter(int characterId, [IsReadOnly] in MyPageSkitMapCharaInfo currentSkitMapCharacterInfo);
		private IgnorePlaceMapModeFlags CreateIgnorePlaceMapModeFlag([IsReadOnly] in MyPageSkitMapCharaInfo urrentSkitMapCharacterInfo);
		private bool IsDrinkMotion(MyPageMapAnimations.Motion motion);
		private bool IsSitMotion(MyPageMapAnimations.Motion motion);
	}
}
