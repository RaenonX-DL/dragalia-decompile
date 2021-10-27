/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Social;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SocialPlatformManager
	{
		// Fields
		private Achievement achievement;
		private const string SOCIAL_ACCOUNT_SIGNIN = "SOCIAL_ACCOUNT_SIGNIN";
		private static SocialPlatformManager instance;
	
		// Properties
		public static SocialPlatformManager Instance { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass6_0
		{
			// Fields
			public Action<bool> callback;
			public SocialPlatformManager __4__this;
	
			// Constructors
			public __c__DisplayClass6_0();
	
			// Methods
			internal void _SignIn_b__0(bool success);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass7_0
		{
			// Fields
			public SocialPlatformManager __4__this;
			public Action callback;
	
			// Constructors
			public __c__DisplayClass7_0();
	
			// Methods
			internal void _SignOut_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public SocialPlatformManager __4__this;
			public Action AchievementCheckEvent;
			public Action SignInFailedEvent;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _ShowAchievementUI_b__0();
			internal void _ShowAchievementUI_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass13_0
		{
			// Fields
			public Action onSuccess;
			public Action onfailed;
	
			// Constructors
			public __c__DisplayClass13_0();
	
			// Methods
			internal void _ReleaseAchievement_b__0(bool success);
		}
	
		// Constructors
		public SocialPlatformManager();
		static SocialPlatformManager();
	
		// Methods
		public void Initialize();
		public void SignIn(Action<bool> callback = null);
		public void SignOut(Action callback = null);
		public void SetUserSignInStatusbySocailAccount();
		private bool IsUserSignedInFromSocialPlatform();
		public void SetUserSigninStatus(bool signin);
		public bool IsUserSignedIn();
		public void ShowAchievementUI(Action AchievementCheckEvent, Action SignInFailedEvent);
		public void ReleaseAchievement(string achievement_id, double progress, Action onSuccess, Action onfailed);
	}
}
