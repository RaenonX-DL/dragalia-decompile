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
	public class GrowthUnitStatusConfirmPopup : CommonPopup, ICustomMessage
	{
		// Fields
		public UnityEngine.UI.Text beforeHpText;
		public UnityEngine.UI.Text afterHpText;
		public UnityEngine.UI.Text diffHpText;
		public UnityEngine.UI.Text beforeAtkText;
		public UnityEngine.UI.Text afterAtkText;
		public UnityEngine.UI.Text diffAtkText;
		public GameObject originCell;
		public Transform cellParentTransform;
		public CommonSlider slider;
		public Button plusButton;
		public Button minusButton;
		public UnityEngine.UI.Text useCountText;
		public UnityEngine.UI.Text totalCountText;
		public UnityEngine.UI.Text conditionText;
		public GameObject needMaterialTextObject;
		public Action reloadCanvasUICallBack;
		private int _nowValue;
		private GrowthUnitEnhanceModel model;
		private List<CraftMaterialCell> materialCells;
		private Coroutine updateUICoroutine;
		private Coroutine countCoroutine;
		private PointerEventHandler plusButtonEventHandler;
		private PointerEventHandler minusButtonEventHandler;
		private int minValue;
		private int maxValue;
		private bool isDesabledReleaseButton;
		private bool isEndInitTask;
		private bool isSkipChangeValueTask;
		private PointerEventHandler okButtonHandler;
		private readonly Color positiveColor;
		private readonly Color normalColor;
	
		// Properties
		public int nowValue { get; private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _CountSpeedCoroutine_d__42 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public bool isPlus;
			public GrowthUnitStatusConfirmPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CountSpeedCoroutine_d__42(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class _UpdatePopupUIDelay_d__43 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthUnitStatusConfirmPopup __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _UpdatePopupUIDelay_d__43(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public GrowthUnitStatusConfirmPopup();
	
		// Methods
		private void OnEnable();
		private void OnDisable();
		public static GrowthUnitStatusConfirmPopup Create();
		public void InitPopup(GrowthUnitEnhanceModel model);
		public void ChangedSliderValue(float newValue);
		public void OnPlusButtonPressed();
		public void OnMinusButtonPressed();
		public void OnValueChangeButtonLongPressed(int countInc);
		[IteratorStateMachine]
		private IEnumerator CountSpeedCoroutine(bool isPlus);
		[IteratorStateMachine]
		private IEnumerator UpdatePopupUIDelay();
		private void UpdatePopupUI();
		private void UpdateStatus();
		private void SetupMaterialCell();
		private void UpdateMaterialCell();
		private void OnMaterialIconPressed(CraftMaterialCellData cellData);
		private void DesableTutorialUI();
		public void OnMessagReceived(CustomMessageType messageType, object data);
		[CompilerGenerated]
		private void _InitPopup_b__37_0(PointerEventData data);
		[CompilerGenerated]
		private void _InitPopup_b__37_1(PointerEventData data);
	}
}
