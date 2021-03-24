/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.SocialPlatforms;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Social
{
	public class Achievement
	{
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass1_0
		{
			// Fields
			public Action successCallback;
			public Action failedCallback;
	
			// Constructors
			public __c__DisplayClass1_0();
	
			// Methods
			internal void _ShowAchievementsUI_b__0(bool success);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action<bool> __9__3_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ProceedAchievement_b__3_0(bool success);
		}
	
		// Constructors
		public Achievement();
	
		// Methods
		public void ShowDefaultAchievementCompletionBanner(bool show);
		public void ShowAchievementsUI(Action successCallback = null, Action failedCallback = null);
		public void ReleaseAchievement(string id, double progress, Action<bool> onFinish);
		public void ProceedAchievement(string id, float value);
		public void ResetAchievements(Action<bool> callback);
		public void LoadAchievements(Action<IAchievement[]> callback);
		public void LoadAchievementDescriptions(Action<IAchievementDescription[]> callback);
	}
}
