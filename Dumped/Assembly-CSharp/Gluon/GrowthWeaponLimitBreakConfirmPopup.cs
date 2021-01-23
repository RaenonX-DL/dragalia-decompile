/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthWeaponLimitBreakConfirmPopup : CommonPopup, ICustomMessage
	{
		// Fields
		public GameObject originCell;
		public Transform cellParentTransform;
		public CommonSlider itemSlider;
		public CommonSlider slider;
		public Button plusItemButton;
		public Button minusItemButton;
		public Button plusButton;
		public Button minusButton;
		public UnityEngine.UI.Text useItemCountText;
		public UnityEngine.UI.Text totalItemCountText;
		public UnityEngine.UI.Text useCountText;
		public UnityEngine.UI.Text totalCountText;
		public UnityEngine.UI.Text conditionText;
		public GameObject[] itemSliderBaseObjects;
		public Image itemIcon;
		public UnityEngine.UI.Text itemCountText;
		public GameObject[] abilityUIObjects;
		public Image abilityIcon1;
		public Image abilityIcon2;
		public GameObject[] dewUIObjects;
		public UnityEngine.UI.Text needDewText;
		public UnityEngine.UI.Text beforeDewText;
		public UnityEngine.UI.Text afterDewText;
		public UnityEngine.UI.Text shortDewText;
		public GameObject[] materialUIObjects;
		public GameObject rupiUIObject;
		public UnityEngine.UI.Text needRupiText;
		public UnityEngine.UI.Text beforeRupiText;
		public UnityEngine.UI.Text afterRupiText;
		public GameObject needMaterialTextObject;
		public Action reloadCanvasUICallBack;
		public Action doLimitBreakAction;
		private int _nowItemValue;
		private int _nowValue;
		private GrowthUnitEnhanceModel model;
		private List<CraftMaterialCell> materialCells;
		private Coroutine updateUICoroutine;
		private Coroutine countCoroutine;
		private PointerEventHandler itemPlusButtonEventHandler;
		private PointerEventHandler itemMinusButtonEventHandler;
		private PointerEventHandler plusButtonEventHandler;
		private PointerEventHandler minusButtonEventHandler;
		private int itemMinValue;
		private int itemMaxValue;
		private int minValue;
		private int maxValue;
		private bool isDesabledReleaseButton;
		private bool isEndInitTask;
		private bool isSkipChangeValueTask;
		private bool isSkipChangeItemValueTask;
		private bool isShortageRupi;
		private PointerEventHandler okButtonHandler;
	
		// Properties
		public int nowItemValue { get; private set; }
		public int nowValue { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CountSpeedCoroutine_d__71 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPlus;
			public bool isItemSlider;
			public GrowthWeaponLimitBreakConfirmPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CountSpeedCoroutine_d__71(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UpdatePopupUIDelay_d__72 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthWeaponLimitBreakConfirmPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdatePopupUIDelay_d__72(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass85_0
		{
			// Fields
			public GrowthUnitLimitBreakFinalCheckPopup popup;
			public GrowthWeaponLimitBreakConfirmPopup __4__this;
	
			// Constructors
			public __c__DisplayClass85_0();
	
			// Methods
			internal void _ShowFinalCheckPopup_b__0();
			internal void _ShowFinalCheckPopup_b__1();
		}
	
		// Constructors
		public GrowthWeaponLimitBreakConfirmPopup();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public static GrowthWeaponLimitBreakConfirmPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		private void SetupRupi();
		public void ChangedSliderValue(float newValue);
		public void ChangedItemSliderValue(float newValue);
		public void OnPlusButtonPressed();
		public void OnMinusButtonPressed();
		public void OnItemPlusButtonPressed();
		public void OnAbilityIconPressed(int index);
		public void OnItemMinusButtonPressed();
		public void OnValueChangeButtonLongPressed(int countInc);
		[IteratorStateMachine]
		private IEnumerator CountSpeedCoroutine(bool isItemSlider, bool isPlus);
		[IteratorStateMachine]
		private IEnumerator UpdatePopupUIDelay();
		private void UpdatePopupUI();
		private void SetupMaterialCell();
		private void UpdateMaterialCell();
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		private void InitReleaseCountSlider();
		private void InitItemCountSlider();
		private void SetupAbilityUI();
		private void SetupDewUI();
		private void UpdateAbilityUI();
		private void UpdateDewUI();
		private void UpdateRupiUI();
		private void DesableTutorialUI();
		public void ShowFinalCheckPopup();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _InitReleaseCountSlider_b__77_0(PointerEventData data);
		[CompilerGenerated]
		private void _InitReleaseCountSlider_b__77_1(PointerEventData data);
		[CompilerGenerated]
		private void _InitItemCountSlider_b__78_0(PointerEventData data);
		[CompilerGenerated]
		private void _InitItemCountSlider_b__78_1(PointerEventData data);
	}
}
