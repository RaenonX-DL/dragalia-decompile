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
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftGradeupScene : SceneBase
	{
		// Fields
		public static int gradeupTargetId;
		public bool isChildData;
		public CraftGradeupCanvas mainCanvas;
		public Camera uiCamera;
		public Camera flashCamera;
		public Canvas bgCanvas;
		public Camera frontEffectCamera;
		public Camera backEffectCamera;
		[SerializeField]
		private Transform overlayParent;
		private BaseCanvasContents baseCanvasContents;
		private BackButton backButton;
		private GameObject craftAnimation;
		private GameObject craftHeaderAnimation;
		private EffectObject frontEffectObject;
		private EffectObject backEffectObject;
		private GameObject weaponModel;
		private bool isTapAndBackKeyLockFlag;
		private List<FlMotion> outMotionList;
		private int effectSkipSortOderKey;
		private bool isGoToPowerup;
		private Canvas uiCanvas;
		public const string basePrefabPath = "Prefabs/OutGame/Growth/";
		private UnitDetailUnitShaderSettings growthWeaponShaderSetting;
		private static readonly string shaderSettingPath;
	
		// Nested types
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<bool> __9__25_0;
			public static Action __9__40_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _Start_b__25_0();
			internal void _CloseCraftEffect_b__40_0();
		}
	
		[CompilerGenerated]
		private sealed class _Start_d__25 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftGradeupScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _Start_d__25(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _LoadMaterialData_d__28 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftGradeupScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _LoadMaterialData_d__28(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public bool isFirstLoaded;
			public CraftGradeupScene __4__this;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _OnCraftButtonPressed_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass36_0
		{
			// Fields
			public CraftGradeupScene __4__this;
			public FlMotion craftAnimeMotion;
			public string resultLabelName;
			public UnityAction __9__2;
			public UnityAction __9__3;
			public Action __9__1;
			public Action __9__4;
	
			// Constructors
			public __c__DisplayClass36_0();
	
			// Methods
			internal void _ShowCraftEffect_b__0();
			internal void _ShowCraftEffect_b__1();
			internal void _ShowCraftEffect_b__2();
			internal void _ShowCraftEffect_b__3();
			internal void _ShowCraftEffect_b__4();
		}
	
		[CompilerGenerated]
		private sealed class _StartAnimationDelay_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftGradeupScene __4__this;
			public int rarity;
			public int matCount;
			public FlMotion craftAnimeMotion;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAnimationDelay_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartHeaderAnimationDelay_d__38 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftGradeupScene __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartHeaderAnimationDelay_d__38(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass41_0
		{
			// Fields
			public Image blackImage;
			public CraftGradeupScene __4__this;
	
			// Constructors
			public __c__DisplayClass41_0();
	
			// Methods
			internal void _PlayNextEffect_b__0();
		}
	
		// Constructors
		public CraftGradeupScene();
		static CraftGradeupScene();
	
		// Methods
		private void Awake();
		[IteratorStateMachine]
		private IEnumerator Start();
		private void OnPrevSceneExitDone();
		private void OnInitReady();
		[IteratorStateMachine]
		private IEnumerator LoadMaterialData();
		private void OnEnterScene();
		private void OnDestroy();
		public override void OnPresentReceived();
		public void BackButtonPressed();
		private void OnCraftButtonPressed();
		private GrowMaterialList[] GetMaterialListData();
		private AtgenWeaponSetList[] GetMaterialWeaponSendData();
		private void ShowCraftEffect();
		[IteratorStateMachine]
		private IEnumerator StartAnimationDelay(FlMotion craftAnimeMotion, int matCount, int rarity);
		[IteratorStateMachine]
		private IEnumerator StartHeaderAnimationDelay();
		private void SetupAwakeEffect();
		private void CloseCraftEffect();
		private void PlayNextEffect(bool isBackKey = false);
		[CompilerGenerated]
		private void _OnCraftButtonPressed_b__33_0(CraftAssembleResponse res);
		[CompilerGenerated]
		private void _SetupAwakeEffect_b__39_0();
		[CompilerGenerated]
		private void _SetupAwakeEffect_b__39_1();
	}
}
