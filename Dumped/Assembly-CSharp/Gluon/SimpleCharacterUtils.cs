/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class SimpleCharacterUtils
	{
		// Nested types
		public enum AnimatorType
		{
			Party = 0,
			QuestPrepare = 1,
			Mypage = 2,
			Summon = 3,
			Fort = 4
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass3_0
		{
			// Fields
			public int charaId;
			public Action<UnityEngine.Object> onLoaded;
			public Action<UnityEngine.Object> __9__1;
	
			// Constructors
			public __c__DisplayClass3_0();
	
			// Methods
			internal void _LoadMypageCharacterAnimation_b__0(UnityEngine.Object controller);
			internal void _LoadMypageCharacterAnimation_b__1(UnityEngine.Object commonController);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass4_0
		{
			// Fields
			public bool isQuestAnimation;
			public int charaId;
			public WeaponType weaponType;
			public int motionType;
			public Action<UnityEngine.Object> onLoaded;
			public Action<UnityEngine.Object> __9__1;
	
			// Constructors
			public __c__DisplayClass4_0();
	
			// Methods
			internal void _LoadAsyncPartyAnimation_b__0(UnityEngine.Object controller);
			internal void _LoadAsyncPartyAnimation_b__1(UnityEngine.Object commonController);
		}
	
		// Methods
		public static string GetMypageAnimationFileName(int charaId);
		public static string GetMypageAnimationFileNameSpecial(int charaId);
		public static void LoadMypageCharacterAnimation(int charaId, bool isSyncLoad, Action<UnityEngine.Object> onLoaded);
		public static void LoadAsyncPartyAnimation(Action<UnityEngine.Object> onLoaded, bool isQuestAnimation, int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1);
		public static RuntimeAnimatorController LoadPartyAnimation(bool isQuestAnimation, int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1);
		public static string GetPartyAnimationFileNameCommon(int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1);
		public static string GetPartyAnimationFileNameSpecial(int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1);
		private static string GetPartAnimationFilenamePrefix(WeaponType weaponType);
		public static string GetFortCharaAnimationFileName(int charaId, int personMotionType);
		public static string GetFortCharaAnimationFileNameSpecial(int charaId);
		public static string GetSummonCharaAnimationPath(int charaId, string baseFileName);
		public static string GetSummonCharaAnimationPathSpecial(int charaId, string baseFileName);
		public static void LoadOverrideMotionStateList(CharacterAnimatedAttachment attachment, AnimatorType animatorType);
	}
}
