/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MenuPlayerInfoPopup : CommonPopup
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text profileText;
		[SerializeField]
		private UnityEngine.UI.Text stampText;
		[SerializeField]
		private UnityEngine.UI.Text achievementText;
		[SerializeField]
		private Image achievementImage;
		[SerializeField]
		private Sprite googleAchievementImage;
		[SerializeField]
		private Sprite appleAchievementImage;
		[SerializeField]
		private Button missionDrillButton;
		[SerializeField]
		private Button logoutButton;
		public MenuPopup menuPopup;
		private bool isAchievementOn;
		private Coroutine checkSigninOutCoroutine;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public MenuPlayerInfoPopup __4__this;
			public CommonPopup popup;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _OnLogoutButtonPressed_b__0();
			internal void _OnLogoutButtonPressed_b__2();
			internal void _OnLogoutButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _SocailLoginFailedPopup_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__21_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _ReleaseAllAchievement_b__21_0();
		}
	
		[CompilerGenerated]
		private sealed class _CheckSignInOut_d__23 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public MenuPlayerInfoPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CheckSignInOut_d__23(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public MenuPlayerInfoPopup();
	
		// Methods
		public static MenuPlayerInfoPopup Create();
		public void InitSetting();
		public void OnProfileButtonPressed();
		public void OnStampButtonPressed();
		public void OnAchievementButtonPressed();
		public void OnLogoutButtonPressed();
		public void OnDrillMissionButtonPressed();
		private void SocailLoginFailedPopup();
		private void GetAchievementList();
		private void OnSuccess(PlatformAchievementGetPlatformAchievementListResponse res);
		private void ReleaseAllAchievement(PlatformAchievementGetPlatformAchievementListResponse res);
		private void OnApplicationPause(bool pause);
		[IteratorStateMachine]
		private IEnumerator CheckSignInOut();
		[CompilerGenerated]
		private void _OnProfileButtonPressed_b__13_0();
		[CompilerGenerated]
		private void _OnStampButtonPressed_b__14_0();
		[CompilerGenerated]
		private void _OnAchievementButtonPressed_b__15_0();
		[CompilerGenerated]
		private void _OnAchievementButtonPressed_b__15_1();
		[CompilerGenerated]
		private void _OnDrillMissionButtonPressed_b__17_0();
	}
}
