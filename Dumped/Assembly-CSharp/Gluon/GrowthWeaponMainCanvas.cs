/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponMainCanvas : CraftEffectMainCanvas
	{
		// Fields
		public TabBase weaponTypeTabBase;
		public UnityEngine.UI.Text seriesTitle;
		public Transform cellParentTransform;
		public Button weaponBonusButton;
		public Button weaponAbilityButton;
		public DragEventScrollRect scrollRect;
		public GameObject emptyWeaponTextObject;
		public Badge[] weaponTypeGrowBadges;
		[HideInInspector]
		public GrowthWeaponScene scene;
		[HideInInspector]
		public int prevCraftTargetWeaponId;
		private List<int> seriesWeaponIdList;
		private const int totorialTargetWeaponId = 30139901;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass15_0
		{
			// Fields
			public GrowthWeaponTypeAbilityPopup popup;
	
			// Constructors
			public __c__DisplayClass15_0();
	
			// Methods
			internal void _OnAbilityButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass16_0
		{
			// Fields
			public GrowthWeaponTypeBonusPopup popup;
	
			// Constructors
			public __c__DisplayClass16_0();
	
			// Methods
			internal void _OnBonusButtonPressed_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass17_0
		{
			// Fields
			public GrowthWeaponCraftConfirmPopup popup;
			public GrowthWeaponMainCanvas __4__this;
			public int weaponId;
	
			// Constructors
			public __c__DisplayClass17_0();
	
			// Methods
			internal void _ShowCraftPopup_b__0();
			internal void _ShowCraftPopup_b__1();
			internal void _ShowCraftPopup_b__2();
			internal void _ShowCraftPopup_b__3(int targetWeaponId);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public GrowthWeaponMainCanvas __4__this;
			public bool initUIManager;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _StartBlacksmithTutorial_b__0();
			internal bool _StartBlacksmithTutorial_b__1();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Action __9__18_2;
			public static Action __9__23_2;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _StartBlacksmithTutorial_b__18_2();
			internal void _ShowTutorialPopup_b__23_2();
		}
	
		[CompilerGenerated]
		private struct _StartBlacksmithTutorial_d__18 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthWeaponMainCanvas __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public CommonPopup popup;
	
			// Constructors
			public __c__DisplayClass22_0();
	
			// Methods
			internal void _ShowConditionPopup_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass23_0
		{
			// Fields
			public GrowthWeaponMainCanvas __4__this;
			public bool initUIManager;
	
			// Constructors
			public __c__DisplayClass23_0();
	
			// Methods
			internal void _ShowTutorialPopup_b__0();
			internal bool _ShowTutorialPopup_b__1();
		}
	
		[CompilerGenerated]
		private struct _ShowTutorialPopup_d__23 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public GrowthWeaponMainCanvas __4__this;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		public GrowthWeaponMainCanvas();
	
		// Methods
		protected override void Start();
		public void ReloadList();
		public void UpdateUICanvas();
		public void OnAbilityButtonPressed();
		public void OnBonusButtonPressed();
		public void ShowCraftPopup(int weaponId);
		public async void StartBlacksmithTutorial();
		public void SetLockTutorialUI(bool isLock);
		private void weaponTypeSelected(int index);
		private void OnWeaponCellPressed(int weaponId);
		private void ShowConditionPopup(int weaponId);
		private async void ShowTutorialPopup();
		public void SetWeaponTypeGrowBadge();
	}
}
