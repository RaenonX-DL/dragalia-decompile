/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthUnitEnhanceListCell : MonoBehaviour
	{
		// Fields
		public UnitEnhanceListCellType cellType;
		public Image iconImage;
		public CommonSlider slider;
		public UnityEngine.UI.Text releaseCountText;
		public Button releaseButton;
		public Button checkMaterialButton;
		public GameObject lockObject;
		public GameObject lockIconObject;
		public UnityEngine.UI.Text lockText;
		public Image[] skinIcons;
		public GameObject skinIconRoot;
		public Transform[] blackMaskTransforms;
		public GameObject completeObject;
		public LayoutElement cellLayoutElement;
		public float cellHeightNoSkin;
		public Image bgImage;
		public Image bgImageNoSkin;
		public Action<UnitEnhanceListCellType> cellButtonPressedCallBack;
		[CompilerGenerated]
		private bool _isDesabledCell_k__BackingField;
		[CompilerGenerated]
		private bool _isComplete_k__BackingField;
		private GrowthUnitEnhanceModel model;
		private GrowthWeaponSkinConfirmData[] skinConfirmDatas;
		private GrowthUnitEnhanceMainCanvas mainCanvas;
		private bool isLoadingEnhancementFlash;
		private float cellHeightDefault;
	
		// Properties
		public bool isDesabledCell { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isComplete { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass35_0
		{
			// Fields
			public GrowthWeaponSkinConfirmPopup popup;
	
			// Constructors
			public __c__DisplayClass35_0();
	
			// Methods
			internal void _OnSkinIconPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass53_0
		{
			// Fields
			public GrowthUnitEnhanceListCell __4__this;
			public FlashPlayer flashPlayer;
	
			// Constructors
			public __c__DisplayClass53_0();
	
			// Methods
			internal bool _PreLoadEnhancementFlash_b__0();
			internal void _PreLoadEnhancementFlash_b__1(int index);
		}
	
		[CompilerGenerated]
		private struct _PreLoadEnhancementFlash_d__53 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder __t__builder;
			public GrowthUnitEnhanceListCell __4__this;
			public FlashPlayer flashPlayer;
			private __c__DisplayClass53_0 __8__1;
			private string _path_5__2;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public GrowthUnitEnhanceListCell __4__this;
			public bool isPlaying;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal bool _PlayEnhancementFlash_b__0();
			internal void _PlayEnhancementFlash_b__1();
			internal bool _PlayEnhancementFlash_b__2();
		}
	
		[CompilerGenerated]
		private struct _PlayEnhancementFlash_d__54 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncTaskMethodBuilder __t__builder;
			public GrowthUnitEnhanceListCell __4__this;
			private __c__DisplayClass54_0 __8__1;
			public FlashPlayer flashPlayer;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthUnitEnhanceListCell();
	
		// Methods
		private void Awake();
		public void InitCell(GrowthUnitEnhanceModel model, GrowthUnitEnhanceMainCanvas mainCanvas);
		public void UpdateCell();
		public void OnCellButtonPressed();
		public void OnSkinIconPressed(int index);
		private void UpdateStatusCell();
		private void UpdateLimitBreakCell();
		private void UpdateLimitOverCell();
		private void UpdateWeaponPassiveAbilityCell();
		private void ResetCellHeight(bool isGetSkin);
		private void UpdateSlotCell();
		private void UpdateWeaponBonusCell();
		private void UpdateAddEquipCoountCell();
		private void SetupReleaseSlider(int nowCount, int maxCount);
		private void SetupCellButton(bool canRelease);
		private void SetConditionLevelText(int conditionLevel);
		private void SetConditionLimitBreakText(int conditionLimitBreak);
		private void SetConditionLimitOverText(int conditionLimitOver);
		private void SetCompleteLockCell();
		private void SetCellIcon();
		private void SetTutorial();
		private string GetEnhancementFlashPath();
		public async Task PreLoadEnhancementFlash(FlashPlayer flashPlayer);
		public async Task PlayEnhancementFlash(FlashPlayer flashPlayer);
		public void SetCellButtonHandlerEnable(bool enable);
	}
}
