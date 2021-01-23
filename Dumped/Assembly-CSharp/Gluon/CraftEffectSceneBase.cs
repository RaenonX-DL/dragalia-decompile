/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class CraftEffectSceneBase : SceneBase
	{
		// Fields
		public Camera effectUiCamera;
		public Camera effectFlashCamera;
		public Camera frontEffectBaseCamera;
		public Camera backEffectBaseCamera;
		public Camera render3dCamera;
		public Canvas effectBgCanvas;
		protected GrowthWeaponObjectsSettings objectsSettings;
		protected List<CraftStepupConfirmPopupBackupData> craftPopupBackupDataList;
		protected Canvas uiCanvas;
		protected int craftEffectWeaponId;
		protected int[] cfartEffectMaterialIds;
		protected ulong[] cfartEffectMaterialWeaponIds;
		protected bool isTargetLimitBreak;
		protected int craftCount;
		protected UnityAction resultEndCallBack;
		protected CraftEffectMainCanvas effectMainCanvas;
		protected BackButton backButton;
		private GameObject craftAnimation;
		private GameObject craftHeaderAnimation;
		private GameObject weaponModel;
		private BaseCanvasContents baseCanvasContents;
		private EffectObject frontEffectObject;
		private EffectObject backEffectObject;
		private List<FlMotion> outMotionList;
		private int effectSkipSortOderKey;
		private bool isTapAndBackKeyLockFlag;
		private const int columnMax = 2;
		[SerializeField]
		protected RawImageWithAlphaBlend modelViewImage;
	
		// Nested types
		public enum LimitBreakMotionLabel
		{
			disable = 0,
			normal = 1,
			max = 2
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public CraftEffectSceneBase __4__this;
			public FlMotion craftAnimeMotion;
			public string resultLabelName;
			public Action __9__1;
			public Action __9__2;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal void _ShowCraftEffect_b__0();
			internal void _ShowCraftEffect_b__1();
			internal void _ShowCraftEffect_b__2();
		}
	
		[CompilerGenerated]
		private sealed class _StartAnimationDelay_d__36 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftEffectSceneBase __4__this;
			public int rarity;
			public int matCount;
			public FlMotion craftAnimeMotion;
			private int _i_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartAnimationDelay_d__36(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _StartHeaderAnimationDelay_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftEffectSceneBase __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _StartHeaderAnimationDelay_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass40_0
		{
			// Fields
			public Image blackImage;
			public CraftEffectSceneBase __4__this;
	
			// Constructors
			public __c__DisplayClass40_0();
	
			// Methods
			internal void _PlayNextEffect_b__0();
		}
	
		// Constructors
		protected CraftEffectSceneBase();
	
		// Methods
		public void UpdateObjectsParameters();
		protected void SetupFlashCamera();
		protected void SetUpRenderCamera();
		protected virtual void SetupCraftEffectData();
		protected void ShowCraftEffect(bool isLimitBreak);
		private void CreateWeaponModel();
		public void InitWeaponTransform(WeaponType weaponType);
		[IteratorStateMachine]
		private IEnumerator StartAnimationDelay(FlMotion craftAnimeMotion, int matCount, int rarity);
		[IteratorStateMachine]
		private IEnumerator StartHeaderAnimationDelay();
		private void SetupAwakeEffect();
		protected virtual void CloseCraftEffect();
		protected virtual bool PlayNextEffect(bool isBackKey = false);
		public static LimitBreakMotionLabel[] GetLimitBreakMotionLabels(int columnNum, int reminder);
		[CompilerGenerated]
		private void _SetupAwakeEffect_b__38_0();
		[CompilerGenerated]
		private void _SetupAwakeEffect_b__38_1();
	}
}
