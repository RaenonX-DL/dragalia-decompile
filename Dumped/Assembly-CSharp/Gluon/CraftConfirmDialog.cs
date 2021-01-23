/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CraftConfirmDialog : CommonPopup, ICustomMessage
	{
		// Fields
		public Image targetWeaponIcon;
		public UnityEngine.UI.Text message;
		public CraftMaterialCell originCell;
		public UnityEngine.UI.Text needCoinText;
		public UnityEngine.UI.Text totalCoin;
		public UnityEngine.UI.Text breforeCoin;
		public UnityEngine.UI.Text afterCoin;
		public UnityEngine.UI.Text craftCount;
		public UnityEngine.UI.Text craftMaxCount;
		public Slider craftSlider;
		public int totalCraftCount;
		public Button plusButton;
		public Button minusButton;
		public GameObject sliberBase;
		public UnityEngine.UI.Text errorMessage;
		public GameObject sortDecoAttachNode;
		public List<CraftMaterialCell> materialCellList;
		public GameObject autoLimitBreakBase;
		public Toggle autoLimitBreakToggle;
		public UnityEngine.UI.Text autoLimitBreakText;
		[CompilerGenerated]
		private bool _isItemUpdate_k__BackingField;
		private PointerEventHandler plusButtonEventHandler;
		private PointerEventHandler minusButtonEventHandler;
		private Coroutine countCoroutine;
		private int assembleCoin;
		private int targetId;
		private bool isMuteSliderSe;
		private WeaponCraftDataElement craftData;
	
		// Properties
		public bool isItemUpdate { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _SliderSeActiveDelay_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CraftConfirmDialog __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _SliderSeActiveDelay_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _CountSpeedCoroutine_d__41 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPlus;
			public CraftConfirmDialog __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CountSpeedCoroutine_d__41(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CraftConfirmDialog();
	
		// Methods
		public static CraftConfirmDialog Create(bool showBlackLayer = true);
		private void OnEnable();
		private void OnDisable();
		protected override void Start();
		public void InitPop(WeaponCraftDataElement craftData);
		private void UpdatePopup();
		[IteratorStateMachine]
		private IEnumerator SliderSeActiveDelay();
		public void SliderValueChanged();
		public void OnValueChangeButtonPressed(int value);
		public void OnValueChangeButtonLongPressed(int countInc);
		[IteratorStateMachine]
		private IEnumerator CountSpeedCoroutine(bool isPlus);
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		public void OnToggleClickedAutoLimitBreak(bool bOn);
		public override void OnOkButtonPressed();
		public override void OnCancelButtonPressed();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _Start_b__34_0(PointerEventData data);
		[CompilerGenerated]
		private void _Start_b__34_1(PointerEventData data);
	}
}
