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

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponScene : CraftEffectSceneBase
	{
		// Fields
		public static WeaponSceneState weaponSceneState;
		public static int weaponSeriesIndex;
		public static int weaponTypeIndex;
		public Transform overlayParent;
		[HideInInspector]
		public bool isTutorialRequired;
		private TouchGuardObject uiLoadTouchGuard;
		private GrowthWeaponMainCanvas growthWeaponMainCanvas;
		private GrowthWeaponSeriesListCanvas growthWeaponSeriesListCanvas;
		private AnimationUICanvas currentAnimationUICanvas;
		private int goEnhanceWeaponId;
		public const string prefabPath = "Prefabs/OutGame/Growth/GrowthWeapon/";
	
		// Nested types
		public enum WeaponSceneState
		{
			None = 0,
			SeriesList = 1,
			WeaponList = 2
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__13_0;
			public static Action __9__26_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__13_0();
			internal void _GoFortScene_b__26_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__13 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthWeaponScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__13(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public bool isFirstLoaded;
			public GrowthWeaponScene __4__this;
			public int weaponId;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _SendCraftData_b__0();
		}
	
		[CompilerGenerated]
		private struct _SendCraftData_d__27 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthWeaponScene __4__this;
			public int weaponId;
			private __c__DisplayClass27_0 __8__1;
			private TaskAwaiter<WeaponBodyCraftResponse> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass31_0
		{
			// Fields
			public PointerEventHandler skipHandler;
			public GrowthWeaponScene __4__this;
	
			// Constructors
			public __c__DisplayClass31_0();
	
			// Methods
			internal void _AfterResultAction_b__0();
			internal void _AfterResultAction_b__1();
			internal void _AfterResultAction_b__2();
		}
	
		// Constructors
		public GrowthWeaponScene();
		static GrowthWeaponScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnDestroy();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		private void OnEnterScene();
		public override void OnPresentReceived();
		public void SetupModelViewImage(bool enableAlphaBlend);
		public static void SetupSceneByWeaponBodyId(int weaponId);
		public void SetBackButton(Canvas uiCanvas);
		public void CreateUILoadTouchGuard();
		public void RemoveUILoadTouchGuard();
		public void ChangeSceneState(WeaponSceneState nextState);
		public void GoWeaponEnhanceScene(int weaponId);
		public void GoFortScene();
		public async void SendCraftData(int weaponId);
		private void OnBackButtonPressed();
		private void LoadUICanvas();
		private void SetupCraftEffectData(int weaponId);
		private void AfterResultAction();
		protected override void CloseCraftEffect();
		protected override bool PlayNextEffect(bool isBackKey = false);
		[CompilerGenerated]
		private void _ChangeSceneState_b__24_0();
		[CompilerGenerated]
		private void _ChangeSceneState_b__24_1();
	}
}
