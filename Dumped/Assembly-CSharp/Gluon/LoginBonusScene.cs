/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using Gluon.Http;
using Gluon.LoginBonus;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class LoginBonusScene : SceneBase
	{
		// Fields
		[SerializeField]
		private Camera _mainCamera;
		[SerializeField]
		private Camera _backCamera;
		[SerializeField]
		private Camera _flashCamera;
		[SerializeField]
		private Camera _sparkCamera;
		[HideInInspector]
		public FlashPlayerManager flashPlayerManager;
		public float[] flashPlayScale;
		private FlashPlayer[] flashPlayers;
		[SerializeField]
		private GameObject effectRoot;
		private Color storedCameraClearColor;
		private int currentLoginBonusIndex;
		private List<AtgenLoginBonusList> loginBonusList;
		private EffectObject[] spfxEffect;
		private Phase phase;
		private const string loginBonusBGM = "BGM_IN_STORY_0004_01";
		public const string nhaamVoiceGroup = "VO_CHR_100007_01_OUT";
		public static readonly float SPFX_WIPE_EFFECT_START_TIME;
		public static readonly float SPFX_WIPE_EFFECT_END_TIME;
	
		// Properties
		public Camera mainCamera { get; }
		public Camera backCamera { get; }
		public Camera flashCamera { get; }
		public Camera sparkCamera { get; }
	
		// Nested types
		private enum Phase
		{
			Na = 0,
			Init = 1,
			MainBonus = 2,
			EventBonus = 3,
			Flash = 4,
			End = 5
		}
	
		public enum SpfxEffectKind
		{
			Wipe = 0,
			BgParticle = 1,
			Nof = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<AtgenLoginBonusList> __9__38_0;
			public static Func<bool> __9__39_0;
			public static Func<bool> __9__43_0;
			public static Func<bool> __9__43_1;
			public static Func<bool> __9__43_2;
			public static Func<bool> __9__46_0;
			public static Func<bool> __9__46_1;
			public static Func<bool> __9__47_0;
			public static Func<bool> __9__47_1;
			public static Func<bool> __9__48_0;
			public static Func<bool> __9__48_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _UpdateLoginBonusList_b__38_0(AtgenLoginBonusList a, AtgenLoginBonusList b);
			internal bool _Start_b__39_0();
			internal bool _LoadScene_b__43_0();
			internal bool _LoadScene_b__43_1();
			internal bool _LoadScene_b__43_2();
			internal bool _GotoMainPage_b__46_0();
			internal bool _GotoMainPage_b__46_1();
			internal bool _GotoEventPage_b__47_0();
			internal bool _GotoEventPage_b__47_1();
			internal bool _GotoSpecialFlashPage_b__48_0();
			internal bool _GotoSpecialFlashPage_b__48_1();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__39 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__39(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_0
		{
			// Fields
			public LoginBonusScene __4__this;
			public bool isLoaded;
			public Func<bool> __9__4;
	
			// Constructors
			public __c__DisplayClass43_0();
	
			// Methods
			internal bool _LoadScene_b__4();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_1
		{
			// Fields
			public int i;
			public __c__DisplayClass43_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass43_1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass43_2
		{
			// Fields
			public FlashPlayer flashPlayer;
			public __c__DisplayClass43_1 CS___8__locals2;
	
			// Constructors
			public __c__DisplayClass43_2();
	
			// Methods
			internal void _LoadScene_b__3(int index);
		}
	
		[CompilerGenerated]
		private sealed class _LoadScene_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
			private __c__DisplayClass43_0 __8__1;
			private __c__DisplayClass43_1 __8__2;
			private bool _isExistMainBonus_5__2;
			private SceneNameDefine.PageName _firstPagePrefabPath_5__3;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadScene_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _ChangeLocalizeTextPositionCoroutine_d__44 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
			public FlashPlayer flashPlayer;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _ChangeLocalizeTextPositionCoroutine_d__44(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoMainPage_d__46 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoMainPage_d__46(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoEventPage_d__47 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoEventPage_d__47(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoSpecialFlashPage_d__48 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoSpecialFlashPage_d__48(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoNextScene_d__58 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoNextScene_d__58(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoShooting_d__59 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoShooting_d__59(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoMyPage_d__60 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoMyPage_d__60(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoSummonUpdated_d__61 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
			public int encounterStoryId;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoSummonUpdated_d__61(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _GotoLotteryUpdated_d__62 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public LoginBonusScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GotoLotteryUpdated_d__62(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public LoginBonusScene();
		static LoginBonusScene();
	
		// Methods
		public FlashPlayer getFlashPlayer(Constants.FlashResourceKind kind);
		public AtgenLoginBonusList GetCurrentLoginBonus();
		public LoginBonusDataElement GetCurrentLoginBonusMasterDataElement();
		private void Awake();
		public override void StartExitAnimation();
		public FlashPlayer PlayFlash(Constants.FlashResourceKind kind, Vector3 pos, Constants.UIPlaneKind planeKind);
		private static void DisableFlPlane(FlashPlayer player, string planeName);
		private static FlPlane FindFlPlane(FlashPlayer player, string planeName);
		public void HideAllFlash();
		public void HideFlash(Constants.FlashResourceKind kind);
		public void DetachFlash(Constants.FlashResourceKind kind);
		public static bool CheckPlayLoginBonusDemo();
		private void ClearLoginBonusList();
		private void UpdateLoginBonusList();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnEnterScene();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		[IteratorStateMachine]
		private IEnumerator LoadScene();
		[IteratorStateMachine]
		private IEnumerator ChangeLocalizeTextPositionCoroutine(FlashPlayer flashPlayer);
		private void ChangeLocalizeTextPosition(float addX, float addY, FlashPlayer flashPlayer);
		[IteratorStateMachine]
		private IEnumerator GotoMainPage();
		[IteratorStateMachine]
		private IEnumerator GotoEventPage();
		[IteratorStateMachine]
		private IEnumerator GotoSpecialFlashPage();
		public void PlaySpfxEffect(SpfxEffectKind kind);
		public void PlaySpfxEffect(SpfxEffectKind kind, Vector3 pos, Vector3 scale);
		public void TriggerNextSpfxEffect(SpfxEffectKind kind);
		public void TriggerStopSpfxEffect(SpfxEffectKind kind);
		public void StopSpfxEffect(SpfxEffectKind kind);
		public void OnPageDemoFinished();
		public override void OnBeforeLeaving();
		[IteratorStateMachine]
		private IEnumerator GotoNextScene();
		[IteratorStateMachine]
		private IEnumerator GotoShooting();
		[IteratorStateMachine]
		private IEnumerator GotoMyPage();
		[IteratorStateMachine]
		private IEnumerator GotoSummonUpdated(int encounterStoryId);
		[IteratorStateMachine]
		private IEnumerator GotoLotteryUpdated();
	}
}
