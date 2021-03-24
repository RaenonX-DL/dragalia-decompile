/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using FLATOUT.Main;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class GrowthUnitEnhanceMainCanvas : MonoBehaviour
	{
		// Fields
		public GrowthUnitEnhanceStatusController controller;
		public GameObject[] disableUIObjects;
		public Sprite equipCountIconSprite;
		public Material equipCountIconMaterial;
		public Button autoButton;
		[HideInInspector]
		public GrowthUnitEnhanceScene scene;
		[HideInInspector]
		public GrowthUnitEnhanceModel model;
		public const string prefabPath = "Prefabs/OutGame/Growth/GrowthUnitEnhance/";
		public const string flashPrefabPath = "Prefabs/OutGame/Growth/GrowthUnitEnhance/Flash/";
		protected bool isAutoEnhanceResult;
		protected TouchGuardObject unitResultEffectTouchGuard;
	
		// Nested types
		public enum FlashTextType
		{
			None = 0,
			LimitBreak = 1,
			LimitOver = 2,
			Complete = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass19_0
		{
			// Fields
			public bool isPlayCompleteEffect;
	
			// Constructors
			public __c__DisplayClass19_0();
	
			// Methods
			internal void _PlayResultEffects_b__0();
			internal bool _PlayResultEffects_b__1();
		}
	
		[CompilerGenerated]
		private struct _PlayResultEffects_d__19 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthUnitEnhanceMainCanvas __4__this;
			private __c__DisplayClass19_0 __8__1;
			public Action completeCallBack;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public GrowthUnitEnhanceMainCanvas __4__this;
			public int beforeCount;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal void _SendEquipCountData_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass26_0
		{
			// Fields
			public GrowthUnitStatusResultPopup popup;
			public Action closeActionCallBack;
	
			// Constructors
			public __c__DisplayClass26_0();
	
			// Methods
			internal void _ShowBuildupResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public GrowthWeaponEquipCountResultPopup popup;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _ShowEquipableCountResultPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public FlMotion completeEffectMotion;
			public GameObject completeEffectObj;
			public GrowthUnitEnhanceMainCanvas __4__this;
			public Canvas mainCanvas;
			public BaseCanvasContents baseCanvasContents;
			public TouchGuardObject touchGuardObject;
			public Action playEndCallBack;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal void _PlayFlashTextEffect_b__0();
		}
	
		[CompilerGenerated]
		private struct _PlayFlashTextEffect_d__28 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthUnitEnhanceMainCanvas __4__this;
			public Action playEndCallBack;
			public FlashTextType textType;
			private __c__DisplayClass28_0 __8__1;
			private UniTask<int> __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public Dictionary<UnitEnhanceListCellType, Task> enhanceEffectTask;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal bool _PlayCellEnhancementEffects_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Func<KeyValuePair<UnitEnhanceListCellType, Task>, bool> __9__30_1;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal bool _PlayCellEnhancementEffects_b__30_1(KeyValuePair<UnitEnhanceListCellType, Task> t);
		}
	
		[CompilerGenerated]
		private struct _PlayCellEnhancementEffects_d__30 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder __t__builder;
			public GrowthUnitEnhanceSendData[] sendDatas;
			public GrowthUnitEnhanceMainCanvas __4__this;
			private __c__DisplayClass30_0 __8__1;
			private GrowthUnitEnhanceSendData[] __7__wrap1;
			private int __7__wrap2;
			private UnitEnhanceListCellType _cellType_5__4;
			private GrowthUnitEnhanceListCell _cell_5__5;
			private FlashPlayer _flashPlayer_5__6;
			private TaskAwaiter __u__1;
			private UniTask.Awaiter __u__2;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		protected GrowthUnitEnhanceMainCanvas();
	
		// Methods
		protected abstract GrowthUnitEnhanceListCell GetEnhanceListCell(UnitEnhanceListCellType type);
		protected abstract void UpdateCell();
		public abstract void OnAutoButtonPressed();
		protected abstract bool IsAllCellComplete();
		protected abstract bool IsUsableAutoButton();
		public static T LoadUICanvas<T>(Transform parentTransform)
			where T : GrowthUnitEnhanceMainCanvas;
		public virtual void InitCanvas(GrowthUnitEnhanceScene scene, GrowthUnitEnhanceModel model);
		public virtual async void PlayResultEffects(GrowthUnitEnhanceSendData[] sendDatas, Action completeCallBack = null);
		public void UpdateUnitInfo();
		protected void UpdateUIRelatedInMaterial();
		protected void SendBuildupData(int builidup, Action resultAction);
		protected GrowthUnitEnhanceSendData[] CreateSendBuildupData(int builidup);
		protected void SendLimitBreakData(int limitBreak, int useItemCount, Action resultAction);
		protected void SendEquipCountData(int count);
		protected void ShowBuildupResultPopup(int beforeBuilup, int beforePower, Action closeActionCallBack = null);
		private void ShowEquipableCountResultPopup(int beforeCount);
		protected async void PlayFlashTextEffect(FlashTextType textType, Action playEndCallBack);
		protected static UnitEnhanceListCellType GetEnhanceListCellType(BuildupPieceType pieceType);
		protected async Task PlayCellEnhancementEffects(GrowthUnitEnhanceSendData[] sendDatas);
		protected TouchGuardObject CreateResultEffectTouchGuard();
		protected void RemoveResultEffectTouchGuard();
	}
}
